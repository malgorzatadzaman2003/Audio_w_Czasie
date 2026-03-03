using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.DSP
{
    public static class Framing
    {
        public static int FrameSizeFromMs(int sampleRate, int frameMs)
        {
            return (int)Math.Round(sampleRate * frameMs / 1000.0);
        }

        // Create a Hamming window of length N. 
        public static float[] HammingWindow(int N)
        {
            var w = new float[N];
            if (N <= 1) 
            {
                if (N == 1)
                {
                    w[0] = 1f; 
                }

                return w;
            }

            for (int i = 0; i < N; i++) // iterating over every sample in teh window
            {
                w[i] = (float)(0.54 - 0.46 * Math.Cos(2.0 * Math.PI * i / (N - 1))); // Hamming window formula
            }

            return w;
        }

        // Creating frames
        public static float[][] MakeFrames(float[] signal, int frameSize, int hopSize, bool applyHamming)
        {
            if (frameSize <= 0) throw new ArgumentOutOfRangeException(nameof(frameSize));
            if (hopSize <= 0) throw new ArgumentOutOfRangeException(nameof(hopSize));

            int count = 1 + (signal.Length - frameSize) / hopSize;
            if (count <= 0) count = 0;

            float[]? win = applyHamming ? HammingWindow(frameSize) : null;

            var frames = new float[count][]; 
            for (int f = 0; f < count; f++) // iterating through each frame 
            {
                int start = f * hopSize;
                var frame = new float[frameSize];

                for (int i = 0; i < frameSize; i++) // iterating inside each frame 
                {
                    float v = signal[start + i];
                    frame[i] = win == null ? v : v * win[i];
                }

                frames[f] = frame;
            }

            return frames;
        }
    }
}
