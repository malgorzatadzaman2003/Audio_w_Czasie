using Audio_w_Czasie.DSP;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.Export
{
    public static class CsvExporter
    {
        public static void ExportFrameData(string path, int sampleRate, int frameSize, int hopSize,
                                           FrameFeatures feat, double[]? f0Acf = null, double[]? f0Amdf = null, bool[]? voiced = null)
        {
            var sb = new StringBuilder();
            sb.AppendLine("frame,tStart,tEnd,volNorm,ste,zcr,isSilence,f0Acf,f0Amdf,isVoiced");

            double fs = sampleRate;
            for (int i = 0; i < feat.VolumeRms.Length; i++)
            {
                double t0 = (i * hopSize) / fs;
                double t1 = (i * hopSize + frameSize) / fs;

                string line = string.Join(",",
                    i.ToString(),
                    t0.ToString("F6", CultureInfo.InvariantCulture),
                    t1.ToString("F6", CultureInfo.InvariantCulture),
                    feat.VolumeRms[i].ToString("G17", CultureInfo.InvariantCulture),
                    feat.Ste[i].ToString("G17", CultureInfo.InvariantCulture),
                    feat.Zcr[i].ToString("G17", CultureInfo.InvariantCulture),
                    feat.IsSilence[i] ? "1" : "0",
                    (f0Acf == null ? "" : f0Acf[i].ToString("G17", CultureInfo.InvariantCulture)),
                    (f0Amdf == null ? "" : f0Amdf[i].ToString("G17", CultureInfo.InvariantCulture)),
                    (voiced == null ? "" : (voiced[i] ? "1" : "0"))
                );

                sb.AppendLine(line);
            }

            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }
    }
}
