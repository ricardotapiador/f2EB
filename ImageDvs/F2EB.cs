using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ImageDvs
{
    public partial class F2EB : Form
    {
        public F2EB()
        {
            InitializeComponent();
        }

        private Bitmap current_image;
        private float[,] pixel_matrix;
        Image<Bgr, Byte> ImageFrame;

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

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

        private void Get_pixel_bright(Bitmap bitmap, float[,] pixel_matrix)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            //color of pixel
            Color p;

            //grayscale
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    p = bitmap.GetPixel(x, y);
                    pixel_matrix[x, y] = p.GetBrightness();
                }
            }

        }

        private void Scan_conversion(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
        {
            UInt32 evt;
            UInt32 timestamp;
            ASCIIEncoding asen = new ASCIIEncoding();

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
                if (matrix_value > s_greyscale)
                {
                    addr = (UInt32)((127 - s_ypos) << 8 | (127 - s_xpos) << 1 | 1);
                    ts = ts + (UInt32)eventlatency.Value;
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);
                }
            }

        }


        private void Random_Method(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
        {

            UInt32 evt;
            UInt32 timestamp;
            ASCIIEncoding asen = new ASCIIEncoding();

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


                int LFSR = rnd.Next(1, (int)Math.Pow(2, 22));
                int r_xpos = (LFSR >> 8) & 0x7f;
                int r_ypos = (LFSR >> 15) & 0x7f;
                int random_greyscale = LFSR & 0xff;
                int matrix_value = (int)Math.Round((1 - pixel_matrix[r_xpos, r_ypos]) * 256);

                if (random_greyscale >= matrix_value)
                {
                    addr = (UInt32)((127 - r_ypos) << 8 | (127 - r_xpos) << 1 | 1);
                    ts = ts + (UInt32)eventlatency.Value;
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);

                }

            }
        }

        private void Bitwise_method(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
        {

            UInt32 evt;
            UInt32 timestamp;
            ASCIIEncoding asen = new ASCIIEncoding();

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

                //Int32 n = i;
                //  string binary_reverse = Reverse(Convert.ToString(n, 2).PadLeft(22, '0'));
                UInt32 reversed_count = Reverse32((UInt32)i); //Convert.ToUInt32(binary_reverse, 2);
                                                              //  Console.WriteLine(Convert.ToString(reversed_count,2));


                int b_xpos = (int)(reversed_count >> 8) & 0x7f;
                int b_ypos = (int)(reversed_count >> 15) & 0x7f;
                int bitwise_greyscale = (int)reversed_count & 0xff;
                int matrix_value = (int)Math.Round((1 - pixel_matrix[b_xpos, b_ypos]) * 256);



                if (bitwise_greyscale >= matrix_value)
                {
                    addr = (UInt32)((127 - b_ypos) << 8 | (127 - b_xpos) << 1 | 1);
                    ts = ts + (UInt32)eventlatency.Value;
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);

                }

            }
        }

        private void Apply_filter_Click(object sender, EventArgs e)
        {
            if (current_image == null)
            {
                MessageBox.Show("Please Select an Image");

            }
            else
            {
                Image<Gray, float> Convolved_Image = new Image<Gray, float>(current_image);


                if (filter_list.Text == "Sobel Vertical")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, Byte>().Sobel(0, 1, 3).AbsDiff(new Gray(0.0));

                }

                if (filter_list.Text == "Sobel Horizontal")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, Byte>().Sobel(1, 0, 3).AbsDiff(new Gray(0.0));
                }

                if (filter_list.Text == "Laplacian")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, Byte>().Laplace(3).AbsDiff(new Gray(5.0));
                }

                if (filter_list.Text == "Gaussian")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, float>().SmoothGaussian(3);
                }

                current_image = Convolved_Image.Bitmap;


                Get_pixel_bright(current_image, pixel_matrix);


                pictureBox1.Image = current_image;
            }
        }

        private List<Image<Bgr, Byte>> GetVideoFrames(int Time_millisecounds, string Filepath)
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
                        if (SW.ElapsedMilliseconds >= Time_millisecounds) Reading = false;
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


        private void BrowseImage_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            ImageFrame = new Image<Bgr, Byte>((Bitmap)Bitmap.FromFile(openFileDialog1.FileName)).Resize(128, 128, 0);
                            Image<Gray, Byte> grayImage = ImageFrame.Convert<Gray, Byte>();
                            current_image = grayImage.Bitmap;


                            pixel_matrix = new float[current_image.Width, current_image.Height];


                            Get_pixel_bright(current_image, pixel_matrix);


                            pictureBox1.Image = grayImage.Bitmap;
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ConvertFrame_Click(object sender, EventArgs e)
        {

            if (current_image == null)
            {
                MessageBox.Show("Please Select an Image");

            }
            else
            {
                BinaryWriter bWriter = null;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Aedat file|*.Aedat";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.  
                var watch = System.Diagnostics.Stopwatch.StartNew();
                // the code that you want to measure comes here

                if (saveFileDialog1.FileName != "" && convert_method_list.Text != "")
                {

                    string filename = saveFileDialog1.FileName;
                    bWriter = new BinaryWriter(File.Create(filename));

                    if (convert_method_list.Text == "SCAN")
                    {
                        Scan_conversion(pixel_matrix, bWriter, true);
                    }
                    else if (convert_method_list.Text == "Random")
                    {
                        Random_Method(pixel_matrix, bWriter, true);

                    }
                    else if (convert_method_list.Text == "Bitwise")
                    {

                        Bitwise_method(pixel_matrix, bWriter, true);


                    }
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    MessageBox.Show(convert_method_list.Text + " conversion has finished");

                    Console.WriteLine(convert_method_list.Text);

                    Console.WriteLine("Time: {0}", elapsedMs);
                    bWriter.Close();

                }
                else
                {

                    MessageBox.Show("Select conversion method");
                }


            }
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            if (current_image == null)
            {
                MessageBox.Show("Please Select an Image");

            }
            else
            {
                Image<Gray, float> Convolved_Image = new Image<Gray, float>(current_image);


                if (filter_list.Text == "Sobel Vertical")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, Byte>().Sobel(0, 1, 3).AbsDiff(new Gray(0.0));

                }

                if (filter_list.Text == "Sobel Horizontal")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, Byte>().Sobel(1, 0, 3).AbsDiff(new Gray(0.0));
                }

                if (filter_list.Text == "Laplacian")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, Byte>().Laplace(3).AbsDiff(new Gray(5.0));
                }

                if (filter_list.Text == "Gaussian")
                {
                    Convolved_Image = ImageFrame.Convert<Gray, float>().SmoothGaussian(3);
                }

                current_image = Convolved_Image.Bitmap;


                Get_pixel_bright(current_image, pixel_matrix);


                pictureBox1.Image = current_image;
            }
        }

        private void BrowseVideo_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "mp4 (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<Image<Bgr, Byte>> image_array = new List<Image<Bgr, Byte>>();
                image_array = GetVideoFrames((int)Miliseconds_frame.Value, openFileDialog1.FileName);


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Aedat file|*.Aedat";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.  
                if (saveFileDialog1.FileName != "")
                {
                    BinaryWriter bWriter = new BinaryWriter(File.Create(saveFileDialog1.FileName));
                    string method = convert_method_list.Text;



                    if (method != "")
                    {
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;

                            for (int f = 0; f < image_array.Count; f++)
                            {
                                Bitmap current_image_frame = image_array[f].Convert<Gray, Byte>().Sobel(0, 1, 3).AbsDiff(new Gray(0.0)).Resize(128, 128, 0).Bitmap;
                                float[,] pixel_matrix_frame = new float[current_image_frame.Width, current_image_frame.Height];
                                Get_pixel_bright(current_image_frame, pixel_matrix_frame);
                                bool oneframe = (f == 0);

                                switch (method)
                                {
                                    case "SCAN":
                                        Scan_conversion(pixel_matrix_frame, bWriter, oneframe);
                                        break;
                                    case "Random":
                                        Random_Method(pixel_matrix_frame, bWriter, oneframe);
                                        break;
                                    case "Bitwise":
                                        Bitwise_method(pixel_matrix_frame, bWriter, oneframe);
                                        break;
                                }

                            }
                            MessageBox.Show("Video Converted");

                            bWriter.Close();
                        }).Start();


                    }

                }
                else
                {

                    MessageBox.Show("Please Select a conversion method");
                }

            }
        }
    }
}

