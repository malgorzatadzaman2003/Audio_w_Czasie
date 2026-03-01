using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_w_Czasie.Audio
{
    public class WavData
    {
        public int SampleRate { get; }
        public short Channels { get; }
        public short BitsPerSample { get; }
        public float[] SamplesMono { get; }   // -1..1
        public double DurationSeconds => (double)SamplesMono.Length / SampleRate;

        public WavData(int sampleRate, short channels, short bitsPerSample, float[] samplesMono)
        {
            SampleRate = sampleRate;
            Channels = channels;
            BitsPerSample = bitsPerSample;
            SamplesMono = samplesMono;
        }
    }
    public static class WavReader
    {
        // Handling: PCM 16-bit, mono/stereo
        public static WavData ReadPcm16(string path)
        {
            using var bin_read = new BinaryReader(File.OpenRead(path));

            // RIFF header
            string riff = Encoding.ASCII.GetString(bin_read.ReadBytes(4));
            if (riff != "RIFF")
            {
                throw new InvalidDataException("Not a RIFF file.");
            }

            bin_read.ReadInt32(); // size of a file
            string wave = Encoding.ASCII.GetString(bin_read.ReadBytes(4));
            if (wave != "WAVE")
            {
                throw new InvalidDataException("Not a WAVE file.");
            }

            // Reading chunks
            short audioFormat = 0;
            short channels = 0;
            int sampleRate = 0;
            short bitsPerSample = 0;
            byte[]? dataBytes = null;

            while (bin_read.BaseStream.Position < bin_read.BaseStream.Length)
            {
                string chunkId = Encoding.ASCII.GetString(bin_read.ReadBytes(4));
                int chunkSize = bin_read.ReadInt32();

                if (chunkId == "fmt ")
                {
                    audioFormat = bin_read.ReadInt16();
                    channels = bin_read.ReadInt16();
                    sampleRate = bin_read.ReadInt32();
                    bin_read.ReadInt32(); // byte rate
                    bin_read.ReadInt16(); // block align
                    bitsPerSample = bin_read.ReadInt16();
                }
                else if (chunkId == "data")
                {
                    dataBytes = bin_read.ReadBytes(chunkSize);
                }
                else
                {
                    // Skip unknown chunk
                    bin_read.BaseStream.Seek(chunkSize, SeekOrigin.Current);
                }

                if (dataBytes != null && sampleRate != 0 && channels != 0 && bitsPerSample != 0)
                {
                    break; // we have what we need
                }
            }

            if (audioFormat != 1) throw new NotSupportedException("Only PCM WAV is supported.");
            if (bitsPerSample != 16) throw new NotSupportedException("Only 16-bit PCM is supported.");
            if (dataBytes == null) throw new InvalidDataException("No data chunk found.");

            // Parse samples
            int bytesPerSample = bitsPerSample / 8; // 2
            int totalSamples = dataBytes.Length / bytesPerSample;
            int frames = totalSamples / channels;

            float[] mono = new float[frames];

            int offset = 0;
            for(int i = 0; i < frames; i++)
            {
                if(channels == 1)
                {
                    short s = BitConverter.ToInt16(dataBytes, offset);
                    mono[i] = s / 32768f;
                    offset += 2;
                }
                else if (channels == 2)
                {
                    short l = BitConverter.ToInt16(dataBytes, offset);
                    short r = BitConverter.ToInt16(dataBytes, offset + 2);
                    mono[i] = 0.5f * ((l / 32768f) + (r / 32768f));
                    offset += 4;
                }
                else
                {
                    throw new NotSupportedException("Only mono/stereo supported.");
                }
            }

            return new WavData(sampleRate, channels, bitsPerSample, mono);
        }
    }
}
