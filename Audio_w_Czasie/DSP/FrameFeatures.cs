using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP
{
    public class FrameFeatures
    {
        public double[] VolumeRms { get; init; } = Array.Empty<double>();
        public double[] Ste { get; init; } = Array.Empty<double>();
        public double[] Zcr { get; init; } = Array.Empty<double>();
        public bool[] IsSilence { get; init; } = Array.Empty<bool>();
        public double FrameShiftSeconds { get; init; }
    }

    public static class FeatureExtractor
    {
        public static FrameFeatures ExtractFeatures(float[][] frames, int sampleRate, int hopSize, bool normalizeVolume, double thrVolNorm = 0.05, double thrZcr = 0.03)
        {
            int frameCount = frames.Length;
            var vol = new double[frameCount];
            var ste = new double[frameCount];
            var zcr = new double[frameCount];

            for (int f = 0; f < frameCount; f++)
            {
                var x = frames[f];
                int N = x.Length;

                double sumSq = 0;
                int crosses = 0;

                float prev = x[0];
                sumSq += prev * prev;

                for (int i = 1; i < N; i++)
                {
                    float cur = x[i];
                    sumSq += cur * cur;

                    bool signChange = (cur >= 0 && prev < 0) || (cur < 0 && prev >= 0);
                    if (signChange) crosses++;

                    prev = cur;
                }

                double meanSq = sumSq / N;
                ste[f] = meanSq;
                vol[f] = Math.Sqrt(meanSq);
                zcr[f] = (double)crosses / (N - 1);
            }

            // normalize volume to max (volume norm in [0..1])
            double[] volNorm = vol;
            if (normalizeVolume && frameCount > 0)
            {
                double max = 0;

                for (int i = 0; i < frameCount; i++)
                {
                    if (vol[i] > max)
                    {
                        max = vol[i];
                    }
                }

                double eps = 1e-12;
                volNorm = new double[frameCount];
                for (int i = 0; i < frameCount; i++)
                {
                    volNorm[i] = vol[i] / (max + eps);
                }
            }

            var silence = new bool[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                silence[i] = (volNorm[i] < thrVolNorm) && (zcr[i] < thrZcr);
            }

            return new FrameFeatures
            {
                VolumeRms = volNorm,      
                Ste = ste,
                Zcr = zcr,
                IsSilence = silence,
                FrameShiftSeconds = (double)hopSize / sampleRate
            };
        }
    }
}
