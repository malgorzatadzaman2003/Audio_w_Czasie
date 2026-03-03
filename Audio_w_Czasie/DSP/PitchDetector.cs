using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP
{
    public class PitchTrack
    {
        public double[] F0Hz { get; init; } = Array.Empty<double>(); // 0 = unvoiced/silence
        public bool[] IsVoiced { get; init; } = Array.Empty<bool>();
    }

    public static class PitchDetector
    {
        public static PitchTrack ComputeF0_Acf(float[][] frames, int sampleRate, bool[] isSilence,
                                               double minF0 = 50, double maxF0 = 400, double thrCorr = 0.35)
        {
            int frameCount = frames.Length;
            var f0 = new double[frameCount];
            var voiced = new bool[frameCount];

            int lagMin = (int)Math.Floor(sampleRate / maxF0);
            int lagMax = (int)Math.Ceiling(sampleRate / minF0);

            for(int f = 0; f < frameCount; f++)
            {
                if (isSilence[f])
                {
                    f0[f] = 0;
                    voiced[f] = false;
                    continue;
                }

                // R[0]
                var x = frames[f];
                int N = x.Length;

                double r0 = 0;
                for(int i = 0; i < N; i++)
                {
                    r0 += x[i] * x[i];
                }

                if (r0 < 1e-12)
                {
                    f0[f] = 0;
                    voiced[f] = false;
                    continue;
                }

                double bestR = double.NegativeInfinity;
                int bestLag = 0;

                int lMax = Math.Min(lagMax, N - 1);
                for (int lag = lagMin; lag <= lMax; lag++)
                {
                    double r = 0;
                    for(int i = 0; i < N - lag; i++)
                    {
                        r += x[i] * x[i + lag];
                    }

                    double rNorm = r / r0; // normalized autocorr
                    if (rNorm > bestR)
                    {
                        bestR = rNorm;
                        bestLag = lag;
                    }
                }

                if (bestLag == 0 || bestR < thrCorr)
                {
                    f0[f] = 0;
                    voiced[f] = false;
                }
                else
                {
                    f0[f] = (double)sampleRate / bestLag;
                    voiced[f] = true;
                }
            }

            return new PitchTrack
            {
                F0Hz = f0,
                IsVoiced = voiced
            };
        }

        public static PitchTrack ComputeF0_Amdf(float[][] frames, int sampleRate, bool[] isSilence,
                                                double minF0 = 50, double maxF0 = 400, double thrMinRatio = 0.7)
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
                    f0[f] = 0;
                    voiced[f] = false;
                    continue;
                }

                // R[0]
                var x = frames[f];
                int N = x.Length;

                double bestA = double.PositiveInfinity;
                int bestLag = 0;

                int lMax = Math.Min(lagMax, N - 1);
                for (int lag = lagMin; lag <= lMax; lag++)
                {
                    double sum = 0;
                    for (int i = 0; i < N - lag; i++)
                    {
                        sum += Math.Abs(x[i + lag] - x[i]);
                    }

                    double a = sum / (N - lag); // normalize
                    if (a < bestA)
                    {
                        bestA = a;
                        bestLag = lag;
                    }
                }

                // prosty test "czy minimum jest wyraźne":
                // porównaj do wartości przy lagMin (tło)
                double aMin = bestA;
                double aRef = 0;
                {
                    int lag = lagMin;
                    double sum = 0;
                    for (int i = 0; i < N - lag; i++)
                    {
                        sum += Math.Abs(x[i + lag] - x[i]);
                    }
                    aRef = sum / (N - lag);
                }

                if (bestLag == 0 || aMin > thrMinRatio * aRef)
                {
                    f0[f] = 0;
                    voiced[f] = false;
                }
                else
                {
                    f0[f] = (double)sampleRate / bestLag;
                    voiced[f] = true;
                }
            }

            return new PitchTrack
            {
                F0Hz = f0,
                IsVoiced = voiced
            };
        }
    }
    }
}
