using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP.Frequency
{
    public enum WindowType
    {
        Rectangular,
        Triangular,
        Hamming,
        Hann,
        Blackman
    }
    public static class WindowFunctions
    {
        public static double[] Create(WindowType type, int N)
        {
            var w = new double[N];
            if (N <= 0) return w;

            switch (type)
            {
                case WindowType.Rectangular: // nic nie zmienia 
                    for (int i = 0; i < N; i++) w[i] = 1.0;
                    break;

                case WindowType.Triangular: // najwieksza wartosc w srodku najmniejsze po bokach jak w trojkacie
                    for (int i = 0; i < N; i++)
                        w[i] = 1.0 - Math.Abs((i - (N - 1) / 2.0) / (N / 2.0));
                    break;

                case WindowType.Hamming: // wygladza brzegi, nie zeruje
                    for (int i = 0; i < N; i++)
                        w[i] = 0.54 - 0.46 * Math.Cos(2.0 * Math.PI * i / (N - 1));
                    break;

                case WindowType.Hann: // wygladza brzegi, zeruje je
                    for (int i = 0; i < N; i++)
                        w[i] = 0.5 * (1 - Math.Cos(2.0 * Math.PI * i / (N - 1)));
                    break;
                case WindowType.Blackman: // wygladza brzegi, zeruje je, ma mniejsze boczne listki niż Hamming i Hann
                    for (int i = 0; i < N; i++)
                        w[i] = 0.42
                             - 0.5 * Math.Cos(2.0 * Math.PI * i / (N - 1))
                             + 0.08 * Math.Cos(4.0 * Math.PI * i / (N - 1));
                    break;
            }

            return w;
        }

        public static double[] Apply(float[] frame, WindowType type)
        {
            int N = frame.Length;
            double[] w = Create(type, N);
            double[] y = new double[N];

            for (int i = 0; i < N; i++)
                y[i] = frame[i] * w[i];

            return y;
        }
    }
}
