using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2EB
{
    class Algorithms
    {

        private UInt32 latency;

        public Algorithms(UInt32 latency)
        {
            this.latency = latency;


        }

        private UInt32 GetLatency()
        {
            return this.latency;
        }

        public void Scan_Method(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
        {
            UInt32 evt;
            UInt32 timestamp;
            ASCIIEncoding asen = new ASCIIEncoding();

            //AEDAT HEADER FOR JAER
            if (oneframe)
            {
                bWriter.Write(asen.GetBytes("#!AER-DAT2.0\r\n"));
                bWriter.Write(asen.GetBytes("# This is a raw AE data file created by saveaerdat.m\r\n"));
                bWriter.Write(asen.GetBytes("# Data format is int32 address, int32 timestamp (8 bytes total), repeated for each event\r\n"));
                bWriter.Write(asen.GetBytes("# Timestamps tick is 1 us\r\n"));
                bWriter.Write(asen.GetBytes("# End of ASCII Header\r\n"));
            }
            UInt32 addr = 0;
            UInt32 ts = 0;

            for (int i = 0; i < Math.Pow(2, 22); i++)
            {

                int s_xpos = i & 0x7f;
                int s_ypos = (i >> 8) & 0x7f;
                int s_greyscale = (i >> 15) & 0xff;
                int matrix_value = (int)Math.Round(pixel_matrix[s_xpos, s_ypos] * 256);

                //Compare grayscale, if condition is true generate and event and write in the output file
                if (matrix_value > s_greyscale)
                {
                    addr = (UInt32)((127 - s_ypos) << 8 | (127 - s_xpos) << 1 | 1);
                    ts = ts + (UInt32)this.GetLatency();
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);
                }
            }

        }

        public void Random_Method(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
        {

            UInt32 evt;
            UInt32 timestamp;
            ASCIIEncoding asen = new ASCIIEncoding();

            //AEDAT HEADER FOR JAER
            if (oneframe)
            {
                bWriter.Write(asen.GetBytes("#!AER-DAT2.0\r\n"));
                bWriter.Write(asen.GetBytes("# This is a raw AE data file created by saveaerdat.m\r\n"));
                bWriter.Write(asen.GetBytes("# Data format is int32 address, int32 timestamp (8 bytes total), repeated for each event\r\n"));
                bWriter.Write(asen.GetBytes("# Timestamps tick is 1 us\r\n"));
                bWriter.Write(asen.GetBytes("# End of ASCII Header\r\n"));
            }

            UInt32 addr = 0;
            UInt32 ts = 0;

            Random rnd = new Random();


            for (int i = 0; i < Math.Pow(2, 22); i++)
            {
                //Generate Random value
                int LFSR = rnd.Next(1, (int)Math.Pow(2, 22));
                //Decoder Random value to get pixel position and grayscale
                int r_xpos = (LFSR >> 8) & 0x7f;
                int r_ypos = (LFSR >> 15) & 0x7f;
                int random_greyscale = LFSR & 0xff;
                int matrix_value = (int)Math.Round((1 - pixel_matrix[r_xpos, r_ypos]) * 256);

                //Compare grayscale, if condition is true generate and event and write in the output file
                if (random_greyscale >= matrix_value)
                {
                    addr = (UInt32)((127 - r_ypos) << 8 | (127 - r_xpos) << 1 | 1);
                    ts = ts + (UInt32)this.GetLatency();
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);

                }

            }
        }


        public void Bitwise_method(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
        {

            UInt32 evt;
            UInt32 timestamp;
            ASCIIEncoding asen = new ASCIIEncoding();

            //AEDAT HEADER FOR JAER
            if (oneframe)
            {
                bWriter.Write(asen.GetBytes("#!AER-DAT2.0\r\n"));
                bWriter.Write(asen.GetBytes("# This is a raw AE data file created by saveaerdat.m\r\n"));
                bWriter.Write(asen.GetBytes("# Data format is int32 address, int32 timestamp (8 bytes total), repeated for each event\r\n"));
                bWriter.Write(asen.GetBytes("# Timestamps tick is 1 us\r\n"));
                bWriter.Write(asen.GetBytes("# End of ASCII Header\r\n"));
            }

            UInt32 addr = 0;
            UInt32 ts = 0;


            for (Int32 i = 0; i < Math.Pow(2, 22); i++)
            {

                //Reverse counter value 
                UInt32 reversed_count = Frame_Utils.Reverse32((UInt32)i);
                //Decoder inverted counter value 
                int b_xpos = (int)(reversed_count >> 8) & 0x7f;
                int b_ypos = (int)(reversed_count >> 15) & 0x7f;
                int bitwise_greyscale = (int)reversed_count & 0xff;
                int matrix_value = (int)Math.Round((1 - pixel_matrix[b_xpos, b_ypos]) * 256);

                //Compare grayscale, if condition is true generate and event and write in the output file
                if (bitwise_greyscale >= matrix_value)
                {
                    addr = (UInt32)((127 - b_ypos) << 8 | (127 - b_xpos) << 1 | 1);
                    ts = ts + (UInt32)this.GetLatency();
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);

                }

            }
        }

    }
}
