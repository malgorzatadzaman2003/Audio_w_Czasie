using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP.Frequency
{
    public sealed class CepstrumResult
    {
        public double[] QuefrencySeconds { get; init; } = Array.Empty<double>();
        public double[] CepstrumValues { get; init; } = Array.Empty<double>();
        public double F0Hz { get; init; }
    }

    public static class CepstrumAnalyzer
    {
        public static CepstrumResult ComputeF0FromFrame(double[] frame, int sampleRate)
        {
            var fft = FftHelper.ComputeFft(frame);
            Complex[] logSpec = new Complex[fft.Length];

            for (int i = 0; i < fft.Length; i++)
                logSpec[i] = new Complex(Math.Log(fft[i].Magnitude + 1e-12), 0);

            InverseFFTInPlace(logSpec);

            double[] cep = new double[logSpec.Length];
            double[] quef = new double[logSpec.Length];

            for (int i = 0; i < cep.Length; i++)
            {
                cep[i] = Math.Abs(logSpec[i].Real);
                quef[i] = (double)i / sampleRate;
            }

            // zakres: 50Hz - 400Hz -> indeksy miedzy: 22050/400 a 22050/50 dla fs=22050
            int minIdx = (int)Math.Floor(sampleRate / 400.0);
            int maxIdx = (int)Math.Ceiling(sampleRate / 50.0);

            double best = double.NegativeInfinity;
            int bestIdx = minIdx;

            for (int i = minIdx; i <= Math.Min(maxIdx, cep.Length - 1); i++) // szukanie max piku cepstralnego w zakresie odpowiadającym 50-400Hz
            {
                if (cep[i] > best)
                {
                    best = cep[i];
                    bestIdx = i;
                }
            }

            double f0 = (double)sampleRate / bestIdx;

            return new CepstrumResult
            {
                QuefrencySeconds = quef,
                CepstrumValues = cep,
                F0Hz = f0
            };
        }

        private static void InverseFFTInPlace(Complex[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = Complex.Conjugate(buffer[i]);

            FftHelper.FFTInPlace(buffer);

            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = Complex.Conjugate(buffer[i]) / buffer.Length;
        }
    }

}
