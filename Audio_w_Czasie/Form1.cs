using Audio_w_Czasie.Audio;
using Audio_w_Czasie.DSP;
using Audio_w_Czasie.Export;
using System.IO;

namespace Audio_w_Czasie
{
    public partial class Form1 : Form
    {
        private WavData? _wav;
        private string? _loadedWavPath;

        private FrameFeatures? _feat;
        private float[][]? _frames;
        private int _frameSize, _hop;

        private PitchTrack? _pitchAcf;
        private PitchTrack? _pitchAmdf;


        public Form1()
        {
            InitializeComponent();
            cmbFeature.SelectedIndex = 0;
        }

        public void LoadWavFile(string path)
        {
            _wav = WavReader.ReadPcm16(path);
            _loadedWavPath = path;

            UpdateInfoPanel(_wav, path);
            RecomputeAndRefresh(); // 
        }
        private void openWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "WAV files (*.wav)|*.wav";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            if (_wav == null)
            {
                // current window is empty -> load here
                LoadWavFile(ofd.FileName);
            }
            else
            {
                // current window already has a file -> open new window
                var newForm = new Form1();
                newForm.LoadWavFile(ofd.FileName);
                newForm.Show();
            }
        }

        private void exportCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_wav == null || _feat == null)
            {
                MessageBox.Show("No data to export. Load WAV and compute features first.");
                return;
            }

            string defaultBaseName = "audio";

            if (!string.IsNullOrWhiteSpace(_loadedWavPath))
            {
                defaultBaseName = Path.GetFileNameWithoutExtension(_loadedWavPath);
            }

            using var sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            sfd.FileName = $"{defaultBaseName}_features.csv";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            CsvExporter.ExportFrameData(
                path: sfd.FileName,
                sampleRate: _wav.SampleRate,
                frameSize: _frameSize,
                hopSize: _hop,
                feat: _feat,
                f0Acf: _pitchAcf?.F0Hz,
                f0Amdf: _pitchAmdf?.F0Hz,
                voiced: _pitchAcf?.IsVoiced
            );

            MessageBox.Show("CSV exported successfully.");
        }

        private void PlotWaveformWithSelection()
        {
            if (_wav == null)
                return;

            int maxPoints = 200_000;
            float[] x = _wav.SamplesMono;

            double[] ys;
            if (x.Length <= maxPoints)
            {
                ys = Array.ConvertAll(x, v => (double)v);
            }
            else
            {
                int step = (int)Math.Ceiling((double)x.Length / maxPoints);
                int n = x.Length / step;
                ys = new double[n];
                for (int i = 0; i < n; i++)
                    ys[i] = x[i * step];
            }

            formsPlotWave.Plot.Clear();

            double sampleSpacing = 1.0 / _wav.SampleRate;
            formsPlotWave.Plot.Add.Signal(ys, sampleSpacing);

            formsPlotWave.Plot.Title("Waveform");
            formsPlotWave.Plot.XLabel("Time (s)");
            formsPlotWave.Plot.YLabel("Amplitude");

            if (_feat != null && chkSilence.Checked)
            {
                for (int f = 0; f < _feat.IsSilence.Length; f++)
                {
                    if (!_feat.IsSilence[f]) continue;

                    double t0 = (double)(f * _hop) / _wav.SampleRate;
                    double t1 = (double)(f * _hop + _frameSize) / _wav.SampleRate;

                    var r = formsPlotWave.Plot.Add.Rectangle(t0, t1, -1, 1);
                    r.FillStyle.Color = ScottPlot.Colors.Red.WithAlpha(0.15);
                    r.LineStyle.Width = 0;
                }
            }

            if (_frames != null && _frames.Length > 0)
            {
                int f = trackFrame.Value;
                double t0 = (double)(f * _hop) / _wav.SampleRate;
                double t1 = (double)(f * _hop + _frameSize) / _wav.SampleRate;

                var selected = formsPlotWave.Plot.Add.Rectangle(t0, t1, -1, 1);
                selected.FillStyle.Color = ScottPlot.Colors.Blue.WithAlpha(0.12);
                selected.LineStyle.Width = 1;
            }

            formsPlotWave.Plot.Axes.AutoScale();
            formsPlotWave.Refresh();
        }

        private void PlotSelectedFeature()
        {
            if (_feat == null)
                return;

            formsPlotFeat.Plot.Clear();

            double[] values;
            string title;
            string ylabel;

            switch (cmbFeature.SelectedItem?.ToString())
            {
                case "STE":
                    values = _feat.Ste;
                    title = "Short-Time Energy";
                    ylabel = "STE";
                    break;

                case "ZCR":
                    values = _feat.Zcr;
                    title = "Zero-Crossing Rate";
                    ylabel = "ZCR";
                    break;

                default:
                    values = _feat.VolumeRms;
                    title = "Volume RMS";
                    ylabel = "RMS";
                    break;
            }

            double samplePeriod = _feat.FrameShiftSeconds;
            formsPlotFeat.Plot.Add.Signal(values, samplePeriod);

            // highlight selected frame
            int f = trackFrame.Value;
            double t = f * samplePeriod;

            var line = formsPlotFeat.Plot.Add.VerticalLine(t);
            line.LineWidth = 2;
            line.Color = ScottPlot.Colors.Red;

            formsPlotFeat.Plot.Title(title);
            formsPlotFeat.Plot.XLabel("Time (s)");
            formsPlotFeat.Plot.YLabel(ylabel);
            formsPlotFeat.Plot.Axes.AutoScale();
            formsPlotFeat.Refresh();
        }

        private void RecomputeAndRefresh()
        {
            if (_wav == null)
                return;

            int frameMs = 20;
            _frameSize = Framing.FrameSizeFromMs(_wav.SampleRate, frameMs);
            _hop = _frameSize / 2;

            _frames = Framing.MakeFrames(_wav.SamplesMono, _frameSize, _hop, applyHamming: true);

            _feat = FeatureExtractor.ExtractFeatures(
                _frames,
                _wav.SampleRate,
                _hop,
                normalizeVolume: chkNormalizeVolume.Checked,
                thrVolNorm: 0.05,
                thrZcr: 0.03);

            _pitchAcf = PitchDetector.ComputeF0_Acf(_frames, _wav.SampleRate, _feat.IsSilence);
            _pitchAmdf = PitchDetector.ComputeF0_Amdf(_frames, _wav.SampleRate, _feat.IsSilence);

            SetupTrackBar();
            RefreshAllPlots();
        }

        private void PlotPitchTrack(ScottPlot.WinForms.FormsPlot plot, double[] f0, string title)
        {
            plot.Plot.Clear();

            double framePeriod = (double)_hop / _wav!.SampleRate;

            double[] xs = new double[f0.Length];
            for (int i = 0; i < f0.Length; i++)
                xs[i] = i * framePeriod;

            var sc = plot.Plot.Add.Scatter(xs, f0);
            sc.LineWidth = 2;
            sc.MarkerSize = 4;

            int f = trackFrame.Value;
            double t = f * framePeriod;

            var line = plot.Plot.Add.VerticalLine(t);
            line.LineWidth = 2;
            line.Color = ScottPlot.Colors.Red;

            plot.Plot.Title(title);
            plot.Plot.XLabel("Time (s)");
            plot.Plot.YLabel("F0 [Hz]");
            plot.Plot.Axes.SetLimitsY(0, 350);
            plot.Refresh();
        }

        private void SetupTrackBar()
        {
            if (_frames == null || _frames.Length == 0)
            {
                trackFrame.Minimum = 0;
                trackFrame.Maximum = 0;
                trackFrame.Value = 0;
                return;
            }

            trackFrame.Minimum = 0;
            trackFrame.Maximum = _frames.Length - 1;
            trackFrame.Value = 0;
            trackFrame.SmallChange = 1;
            trackFrame.LargeChange = Math.Max(1, _frames.Length / 20);
        }

        private void RefreshAllPlots()
        {
            if (_wav == null || _feat == null)
                return;

            PlotWaveformWithSelection();
            PlotSelectedFeature();

            if (_pitchAcf != null)
                PlotPitchTrack(formsPlotAcf, _pitchAcf.F0Hz, "Pitch track - Autocorrelation");

            if (_pitchAmdf != null)
                PlotPitchTrack(formsPlotAmdf, _pitchAmdf.F0Hz, "Pitch track - AMDF");

            UpdateFrameDetails();
        }

    
        private void chkSilence_CheckedChanged(object sender, EventArgs e)
        {
            RefreshAllPlots();
        }

        private void chkNormalizeVolume_CheckedChanged(object sender, EventArgs e)
        {
            RecomputeAndRefresh();
        }

        private void cmbFeature_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlotSelectedFeature();
        }



        private void UpdateInfoPanel(WavData wav, string filePath)
        {
            lblFileVal.Text = Path.GetFileName(filePath);
            lblFsVal.Text = $"{wav.SampleRate} Hz";
            lblChVal.Text = wav.Channels == 1 ? "Mono" : $"Stereo ({wav.Channels})";
            lblBitsVal.Text = $"{wav.BitsPerSample}-bit";
            lblLenVal.Text = $"{wav.DurationSeconds:F2} s";
        }

        private void UpdateFrameDetails()
        {
            if (_feat == null || _wav == null)
            {
                lblFramePos.Text = "Frame: -";
                lblFrameDetails.Text = "No frame selected";
                return;
            }

            int f = trackFrame.Value;
            double t = (double)(f * _hop) / _wav.SampleRate;

            lblFramePos.Text = $"Frame: {f}    Time: {t:F3} s";

            string acfText = "-";
            if (_pitchAcf != null)
            {
                acfText = double.IsNaN(_pitchAcf.F0Hz[f])
                    ? "unvoiced"
                    : $"{_pitchAcf.F0Hz[f]:F1} Hz ({(_pitchAcf.IsVoiced[f] ? "voiced" : "unvoiced")})";
            }

            string amdfText = "-";
            if (_pitchAmdf != null)
            {
                amdfText = double.IsNaN(_pitchAmdf.F0Hz[f])
                    ? "unvoiced"
                    : $"{_pitchAmdf.F0Hz[f]:F1} Hz ({(_pitchAmdf.IsVoiced[f] ? "voiced" : "unvoiced")})";
            }

            lblFrameDetails.Text =
                $"RMS={_feat.VolumeRms[f]:F4} | STE={_feat.Ste[f]:F4} | ZCR={_feat.Zcr[f]:F4} | " +
                $"Silence={_feat.IsSilence[f]} | ACF={acfText} | AMDF={amdfText}";
        }

        private void trackFrame_Scroll(object sender, EventArgs e)
        {
            UpdateFrameDetails();
            PlotWaveformWithSelection();
            PlotSelectedFeature();

            if (_pitchAcf != null)
                PlotPitchTrack(formsPlotAcf, _pitchAcf.F0Hz, "Pitch track - Autocorrelation");

            if (_pitchAmdf != null)
                PlotPitchTrack(formsPlotAmdf, _pitchAmdf.F0Hz, "Pitch track - AMDF");
        }


    }
}
