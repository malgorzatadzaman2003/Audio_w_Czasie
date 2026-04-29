using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP.Frequency
{
    public sealed class SpectralFrameFeatures
    {
        public double SpectralVolume { get; init; } // energia widmowa
        public double CentroidHz { get; init; } // częstotliwość centroidu (środek masy widma)
        public double BandwidthHz { get; init; } // szerokość pasma widma
        public double[] BandEnergy { get; init; } = Array.Empty<double>(); // energia w poszczególnych pasmach 
        public double[] BandEnergyRatio { get; init; } = Array.Empty<double>(); // udział energii w pasmach 
        public double SpectralFlatness { get; init; } // miara szumowości widm
        public double SpectralCrestFactor { get; init; } // max/sr. widma
    }

    public static class SpectralFeatures
    {
        public static SpectralFrameFeatures Compute(double[] freqs, double[] mags)
        {
            double eps = 1e-12;
            double[] psd = mags.Select(v => v * v).ToArray();

            double spectralVolume = psd.Sum() / psd.Length;

            double psdSum = psd.Sum() + eps;
            double centroid = 0;
            for (int i = 0; i < freqs.Length; i++)
                centroid += freqs[i] * psd[i];
            centroid /= psdSum;

            double bw = 0;
            for (int i = 0; i < freqs.Length; i++)
            {
                double d = freqs[i] - centroid;
                bw += d * d * psd[i];
            }
            bw = Math.Sqrt(bw / psdSum);

            double[] bandLimits = { 0, 630, 1720, 4400, 11025 };
            double[] be = new double[4];
            for (int b = 0; b < 4; b++)
            {
                for (int i = 0; i < freqs.Length; i++)
                {
                    if (freqs[i] >= bandLimits[b] && freqs[i] < bandLimits[b + 1])
                        be[b] += psd[i];
                }
            }

            double totalBe = be.Sum() + eps;
            double[] ber = be.Select(x => x / totalBe).ToArray();

            double geo = 1.0;
            int count = 0;
            double arith = psd.Average();
            foreach (var p in psd)
            {
                geo += Math.Log(p + eps);
                count++;
            }
            geo = Math.Exp(geo / count);
            double sfm = arith < eps ? 1.0 : geo / arith;

            double scf = arith < eps ? 0.0 : psd.Max() / arith;

            return new SpectralFrameFeatures
            {
                SpectralVolume = spectralVolume,
                CentroidHz = centroid,
                BandwidthHz = bw,
                BandEnergy = be,
                BandEnergyRatio = ber,
                SpectralFlatness = sfm,
                SpectralCrestFactor = scf
            };
        }
    }

}
