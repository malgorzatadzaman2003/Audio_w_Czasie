using Audio_w_Czasie.Audio;
using Audio_w_Czasie.DSP;

namespace Audio_w_Czasie
{
    public partial class Form1 : Form
    {
        private WavData? _wav;

        private FrameFeatures? _feat;
        private float[][]? _frames;
        private int _frameSize, _hop;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "WAV files (*.wav)|*.wav";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _wav = WavReader.ReadPcm16(ofd.FileName);

            lblInfo.Text = $"fs={_wav.SampleRate} Hz, ch={_wav.Channels}, bits={_wav.BitsPerSample}, " +
                           $"len={_wav.DurationSeconds:F2}s";

            PlotWaveform(_wav);
            ComputeAndPlotFeatures();
        }

        private void PlotWaveform(WavData wav)
        {
            int maxPoints = 200_000; //for performance, limit the number of points plotted. If the audio is longer than this, we will downsample it for plotting.
            float[] x = wav.SamplesMono;

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
                {
                    ys[i] = x[i * step];
                }
            }

            formsPlotWave.Plot.Clear();

            double sampleSpacing = 1.0 / wav.SampleRate;
            formsPlotWave.Plot.Add.Signal(ys, sampleSpacing);

            formsPlotWave.Plot.Title("Waveform");
            formsPlotWave.Plot.YLabel("Amplitude");
            formsPlotWave.Plot.XLabel("Time (s)");
            formsPlotWave.Plot.Axes.AutoScale();

            formsPlotWave.Refresh();
        }

        private void ComputeAndPlotFeatures()
        {
            if (_wav == null) return;

            int frameMs = 20;       // na start (potem podepniesz ComboBox)
            _frameSize = DSP.Framing.FrameSizeFromMs(_wav.SampleRate, frameMs);
            _hop = _frameSize / 2;

            _frames = DSP.Framing.MakeFrames(_wav.SamplesMono, _frameSize, _hop, applyHamming: false);

            _feat = DSP.FeatureExtractor.ExtractFeatures(
                _frames, _wav.SampleRate, _hop,
                normalizeVolume: chkNormalizeVolume.Checked,
                thrVolNorm: 0.05,
                thrZcr: 0.03
            );

            // wykres cech: VolumeNorm (linia)
            formsPlotFeat.Plot.Clear();

            double samplePeriod = _feat.FrameShiftSeconds;
            formsPlotFeat.Plot.Add.Signal(_feat.VolumeRms, samplePeriod);

            formsPlotFeat.Plot.Title("Volume (normalized RMS) per frame");
            formsPlotFeat.Plot.XLabel("Time (s)");
            formsPlotFeat.Plot.YLabel("Volume");

            formsPlotFeat.Plot.Axes.AutoScale();

            formsPlotFeat.Refresh();

            // zaznacz ciszê na waveform
            if (chkSilence.Checked)
                PlotSilenceOnWaveform();
            else
                PlotWaveform(_wav);
        }

        private void PlotSilenceOnWaveform()
        {
            if (_wav == null || _feat == null) return;

            PlotWaveform(_wav);

            int N = _frameSize;
            int hop = _hop;

            for (int f = 0; f < _feat.IsSilence.Length; f++)
            {
                if (!_feat.IsSilence[f]) continue;

                double t0 = (double)(f * hop) / _wav.SampleRate;
                double t1 = (double)(f * hop + N) / _wav.SampleRate;

                // ScottPlot 5: Rectangle(x1, x2, y1, y2)
                var r = formsPlotWave.Plot.Add.Rectangle(t0, t1, -1, 1);

                // wype³nienie z alpha (zamiast FillStyle.Solid)
                r.FillStyle.Color = ScottPlot.Colors.Red.WithAlpha(0.15);

                // brak obramowania
                r.LineStyle.Width = 0;
            }

            formsPlotWave.Refresh();
        }

        private void openWAVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chkSilence_CheckedChanged(object sender, EventArgs e)
        {
            if (_wav == null) return;

            if (chkSilence.Checked)
            {
                if (_feat == null) ComputeAndPlotFeatures(); // or just return if you require features
                PlotSilenceOnWaveform();
            }
            else
            {
                PlotWaveform(_wav); // redraw without rectangles
            }
        }
    }
}
