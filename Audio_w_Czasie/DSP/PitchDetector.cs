using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP
{
    public class PitchTrack
    {
        public double[] F0Hz { get; init; } = Array.Empty<double>(); // NaN = unvoiced/silence
        public bool[] IsVoiced { get; init; } = Array.Empty<bool>();
    }

    public static class PitchDetector
    {
        public static PitchTrack ComputeF0_Acf(
            float[][] frames,
            int sampleRate,
            bool[] isSilence,
            double minF0 = 80,
            double maxF0 = 300,
            double thrCorr = 0.25)
        {
            int frameCount = frames.Length;
            var f0 = new double[frameCount];
            var voiced = new bool[frameCount];

            int lagMin = (int)Math.Floor(sampleRate / maxF0);
            int lagMax = (int)Math.Ceiling(sampleRate / minF0);

            for (int f = 0; f < frameCount; f++)
            {
                if (isSilence[f])
                {
                    f0[f] = double.NaN;
                    voiced[f] = false;
                    continue;
                }

                var x = frames[f];
                int N = x.Length;

                double r0 = 0.0;
                for (int i = 0; i < N; i++)
                    r0 += x[i] * x[i];

                if (r0 < 1e-12)
                {
                    f0[f] = double.NaN;
                    voiced[f] = false;
                    continue;
                }

                int lMax = Math.Min(lagMax, N - 2); // ważne: -2 (bo lag+1)

                double prev = 0;
                double curr = 0;

                // start
                int lag = lagMin;
                {
                    double r = 0;
                    for (int i = 0; i < N - lag; i++)
                        r += x[i] * x[i + lag];
                    prev = r / r0;
                }

                int bestLag = 0;

                for (lag = lagMin + 1; lag <= lMax; lag++)
                {
                    double r = 0;
                    for (int i = 0; i < N - lag; i++)
                        r += x[i] * x[i + lag];

                    curr = r / r0;

                    double next;
                    {
                        double rNext = 0;
                        for (int i = 0; i < N - (lag + 1); i++)
                            rNext += x[i] * x[i + lag + 1];

                        next = rNext / r0;
                    }

                    //maksimum lokalne
                    if (curr > prev && curr > next && curr > thrCorr)
                    {
                        bestLag = lag;
                        break;
                    }

                    prev = curr;
                }

                if (bestLag == 0)
                {
                    f0[f] = double.NaN;
                    voiced[f] = false;
                }
                else
                {
                    f0[f] = (double)sampleRate / bestLag;
                    voiced[f] = true;
                }
            }

            f0 = SmoothF0Median3(f0);

            return new PitchTrack
            {
                F0Hz = f0,
                IsVoiced = voiced
            };
        }

        public static PitchTrack ComputeF0_Amdf(
            float[][] frames,
            int sampleRate,
            bool[] isSilence,
            double minF0 = 80,
            double maxF0 = 300,
            double thrMinRatio = 0.7)
        {
            int frameCount = frames.Length;
            var f0 = new double[frameCount];
            var voiced = new bool[frameCount];

            int lagMin = (int)Math.Floor(sampleRate / maxF0);
            int lagMax = (int)Math.Ceiling(sampleRate / minF0);

            for (int f = 0; f < frameCount; f++)
            {
                if (isSilence[f])
                {
                    f0[f] = double.NaN;
                    voiced[f] = false;
                    continue;
                }

                var x = frames[f];
                int N = x.Length;

                double bestA = double.PositiveInfinity;
                int bestLag = 0;

                int lMax = Math.Min(lagMax, N - 1);

                for (int lag = lagMin; lag <= lMax; lag++)
                {
                    double sum = 0.0;
                    for (int i = 0; i < N - lag; i++)
                        sum += Math.Abs(x[i + lag] - x[i]);

                    double a = sum / (N - lag);

                    if (a < bestA)
                    {
                        bestA = a;
                        bestLag = lag;
                    }
                }

                double aMin = bestA;
                double aRef = 0.0;

                {
                    int lag = lagMin;
                    double sum = 0.0;
                    for (int i = 0; i < N - lag; i++)
                        sum += Math.Abs(x[i + lag] - x[i]);

                    aRef = sum / (N - lag);
                }

                if (bestLag == 0 || aRef < 1e-12 || aMin > thrMinRatio * aRef)
                {
                    f0[f] = double.NaN;
                    voiced[f] = false;
                }
                else
                {
                    f0[f] = (double)sampleRate / bestLag;
                    voiced[f] = true;
                }
            }

            f0 = SmoothF0Median3(f0);

            return new PitchTrack
            {
                F0Hz = f0,
                IsVoiced = voiced
            };
        }

        private static double[] SmoothF0Median3(double[] f0)
        {
            if (f0.Length < 3)
                return (double[])f0.Clone();

            var y = (double[])f0.Clone();

            for (int i = 1; i < f0.Length - 1; i++)
            {
                if (double.IsNaN(f0[i - 1]) || double.IsNaN(f0[i]) || double.IsNaN(f0[i + 1]))
                    continue;

                y[i] = Median3(f0[i - 1], f0[i], f0[i + 1]);
            }

            return y;
        }

        private static double Median3(double a, double b, double c)
        {
            if (a > b) (a, b) = (b, a);
            if (b > c) (b, c) = (c, b);
            if (a > b) (a, b) = (b, a);
            return b;
        }
    }
}
