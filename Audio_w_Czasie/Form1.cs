using Audio_w_Czasie.Audio;

namespace Audio_w_Czasie
{
    public partial class Form1 : Form
    {
        private WavData? _wav;
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
    }
}
