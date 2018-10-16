using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2EB
{
    static class Frame_Utils
    {

        public static UInt32 Reverse32(UInt32 x)
        {
            UInt32 y = 0;
            for (int i = 0; i < 22; ++i)
            {
                y <<= 1;
                y |= (x & 1);
                x >>= 1;
            }
            return y;
        }

        public static void Get_pixel_bright(Bitmap bitmap, float[,] pixel_matrix)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            Color p;

            //loop over pixels
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bitmap.GetPixel(x, y);
                    pixel_matrix[x, y] = p.GetBrightness();
                }
            }

        }

        public static List<Image<Bgr, Byte>> GetVideoFrames(int Time_milliseconds, string Filepath)
        {
            List<Image<Bgr, Byte>> image_array = new List<Image<Bgr, Byte>>();
            System.Diagnostics.Stopwatch SW = new System.Diagnostics.Stopwatch();
            bool Reading = true;
            Capture _capture = new Capture(Filepath);
            SW.Start();
            try
            {
                while (Reading)
                {
                    Image<Bgr, Byte> frame = _capture.QueryFrame().ToImage<Bgr, Byte>();
                    if (frame != null)
                    {
                        image_array.Add(frame.Copy());
                        if (SW.ElapsedMilliseconds >= Time_milliseconds) Reading = false;
                    }
                    else
                    {
                        Reading = false;
                    }
                }
            }
            catch { }

            return image_array;
        }
    }
}
