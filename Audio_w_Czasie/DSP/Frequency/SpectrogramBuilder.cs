using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP.Frequency
{
    public sealed class SpectrogramData
    {
        public double[,] MagnitudeDb { get; init; } = new double[0, 0];
        public double[] TimeAxis { get; init; } = Array.Empty<double>();
        public double[] FreqAxis { get; init; } = Array.Empty<double>();
    }

    public static class SpectrogramBuilder
    {
        public static SpectrogramData Build(
            float[] signal,
            int sampleRate,
            int frameSize,
            int hopSize,
            WindowType windowType)
        {
            int frameCount = 1 + (signal.Length - frameSize) / hopSize;
            int fftSize = FftHelper.NextPow2(frameSize);
            int half = fftSize / 2;

            double[,] spec = new double[half, frameCount];
            double[] times = new double[frameCount];
            double[] freqs = new double[half];

            for (int k = 0; k < half; k++)
                freqs[k] = (double)k * sampleRate / fftSize;

            for (int f = 0; f < frameCount; f++)
            {
                int start = f * hopSize;
                float[] frame = new float[frameSize];
                Array.Copy(signal, start, frame, 0, frameSize);

                double[] winFrame = WindowFunctions.Apply(frame, windowType);
                var fft = FftHelper.ComputeFft(winFrame);
                FftHelper.GetMagnitudeSpectrum(fft, sampleRate, out _, out double[] mags);

                for (int k = 0; k < half; k++)
                    spec[k, f] = 20.0 * Math.Log10(mags[k] + 1e-12);

                times[f] = (double)start / sampleRate;
            }

            return new SpectrogramData
            {
                MagnitudeDb = spec,
                TimeAxis = times,
                FreqAxis = freqs
            };
        }
    }
}
