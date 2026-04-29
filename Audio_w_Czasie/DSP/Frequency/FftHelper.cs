using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP.Frequency
{
    public static class FftHelper
    {
        public static int NextPow2(int n)
        {
            int p = 1;
            while (p < n) p <<= 1;
            return p;
        }

        public static Complex[] ComputeFft(double[] signal)
        {
            int n = NextPow2(signal.Length);
            Complex[] buf = new Complex[n];

            for (int i = 0; i < signal.Length; i++)
                buf[i] = new Complex(signal[i], 0); // sygnał rzeczywisty dlatego część urojona równa 0

            FFTInPlace(buf);
            return buf;
        }

        public static void FFTInPlace(Complex[] buffer)
        {
            int n = buffer.Length;
            int bits = (int)Math.Log2(n);

            for (int i = 0; i < n; i++)
            {
                int j = ReverseBits(i, bits);  // potrzebna do początkowego przestawienia próbek w FFT
                if (j > i)
                    (buffer[i], buffer[j]) = (buffer[j], buffer[i]);
            }

            for (int len = 2; len <= n; len <<= 1)
            {
                double ang = -2 * Math.PI / len;
                Complex wLen = new Complex(Math.Cos(ang), Math.Sin(ang));

                for (int i = 0; i < n; i += len)
                {
                    Complex w = Complex.One;
                    for (int j = 0; j < len / 2; j++)
                    {
                        Complex u = buffer[i + j];
                        Complex v = w * buffer[i + j + len / 2];
                        buffer[i + j] = u + v;
                        buffer[i + j + len / 2] = u - v;
                        w *= wLen;
                    }
                }
            }
        }

        private static int ReverseBits(int x, int bits)
        {
            int y = 0;
            for (int i = 0; i < bits; i++)
            {
                y = (y << 1) | (x & 1);
                x >>= 1;
            }
            return y;
        }

        // zamiana fft na dane do wykresu: częstotliwości i amplitudy widma
        public static void GetMagnitudeSpectrum(
            Complex[] fft,
            int sampleRate,
            out double[] freqs,
            out double[] mags)
        {
            int half = fft.Length / 2; // polowa bo dla syganlu rzeczywistego druga polowa widma jest lustrzanym odbiciem pierwszej
            freqs = new double[half];
            mags = new double[half];

            for (int k = 0; k < half; k++)
            {
                freqs[k] = (double)k * sampleRate / fft.Length;
                mags[k] = fft[k].Magnitude;
            }
        }
    }
}
