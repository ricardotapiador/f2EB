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

        //Invert a 32bit value used in Bitwise algorithm to invert the counter
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

        //Get brightness of an image and store values in a matrix
        private void Get_pixel_bright(Bitmap bitmap, float[,] pixel_matrix)
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

        //Scan conversion Algorithm
        private void Scan_conversion(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
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
                    ts = ts + (UInt32)eventlatency.Value;
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);
                }
            }

        }

        // Random conversion algorithm
        private void Random_Method(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
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
                    ts = ts + (UInt32)eventlatency.Value;
                    evt = (UInt32)((BitConverter.GetBytes(addr)[0] << 24) | BitConverter.GetBytes(addr)[1] << 16 | BitConverter.GetBytes(addr)[2] << 8 | BitConverter.GetBytes(addr)[3]);
                    timestamp = (UInt32)((BitConverter.GetBytes(ts)[0] << 24) | BitConverter.GetBytes(ts)[1] << 16 | BitConverter.GetBytes(ts)[2] << 8 | BitConverter.GetBytes(ts)[3]);
                    bWriter.Write(evt);
                    bWriter.Write(timestamp);

                }

            }
        }

        //Bitwise conversion algorithm
        private void Bitwise_method(float[,] pixel_matrix, BinaryWriter bWriter, bool oneframe)
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
                UInt32 reversed_count = Reverse32((UInt32)i);
                //Decoder inverted counter value 
                int b_xpos = (int)(reversed_count >> 8) & 0x7f;
                int b_ypos = (int)(reversed_count >> 15) & 0x7f;
                int bitwise_greyscale = (int)reversed_count & 0xff;
                int matrix_value = (int)Math.Round((1 - pixel_matrix[b_xpos, b_ypos]) * 256);

                //Compare grayscale, if condition is true generate and event and write in the output file
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

        //Get frame from a video in function of time in milliseconds
        private List<Image<Bgr, Byte>> GetVideoFrames(int Time_milliseconds, string Filepath)
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

        //Browse for an image and get pixel brightness for future conversion/modification and update picture box
        private void BrowseImage_Click(object sender, EventArgs e)
        {
            //Open File explorer
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            //Get Image and rescale its size to 128x128
                            ImageFrame = new Image<Bgr, Byte>((Bitmap)Bitmap.FromFile(openFileDialog.FileName)).Resize(128, 128, 0);
                            Image<Gray, Byte> grayImage = ImageFrame.Convert<Gray, Byte>();
                            current_image = grayImage.Bitmap;
                            //Get brightness of pixels
                            pixel_matrix = new float[current_image.Width, current_image.Height];
                            Get_pixel_bright(current_image, pixel_matrix);
                            Image_box.Image = grayImage.Bitmap;
                            Image_box.SizeMode = PictureBoxSizeMode.StretchImage;
                            Image_box.Refresh();
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
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Aedat file|*.Aedat";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.ShowDialog();
                var watch = System.Diagnostics.Stopwatch.StartNew();

                // If the file name is not an empty string open it for saving.  
                if (saveFileDialog.FileName != "" && convert_method_list.Text != "")
                {

                    string filename = saveFileDialog.FileName;
                    string conversion_algorithm_selected = convert_method_list.Text;
                    bWriter = new BinaryWriter(File.Create(filename));

                    switch (conversion_algorithm_selected)
                    {
                        case "Scan":
                            Scan_conversion(pixel_matrix, bWriter, true);
                            break;
                        case "Random":
                            Random_Method(pixel_matrix, bWriter, true);
                            break;
                        case "Bitwise":
                            Bitwise_method(pixel_matrix, bWriter, true);
                            break;
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
            //No image loaded
            if (current_image == null)
            {
                MessageBox.Show("Please Select an Image");

            }
            else
            {
                //Apply filter to image
                Image<Gray, float> Convolved_Image = new Image<Gray, float>(current_image);
                string filter_text = filter_list.Text;

                switch (filter_text)
                {
                    case "Sobel Vertical":
                        Convolved_Image = ImageFrame.Convert<Gray, Byte>().Sobel(0, 1, 3).AbsDiff(new Gray(0.0));
                        break;
                    case "Sobel Horizontal":
                        Convolved_Image = ImageFrame.Convert<Gray, Byte>().Sobel(1, 0, 3).AbsDiff(new Gray(0.0));
                        break;
                    case "Laplacian":
                        Convolved_Image = ImageFrame.Convert<Gray, Byte>().Laplace(3).AbsDiff(new Gray(5.0));
                        break;
                    case "Gaussian":
                        Convolved_Image = ImageFrame.Convert<Gray, float>().SmoothGaussian(3);
                        break;
                }

                //Update current Image
                current_image = Convolved_Image.Bitmap;

                //Get Pixel brightness of new image
                Get_pixel_bright(current_image, pixel_matrix);

                //Update Picturebox with New Image
                Image_box.Image = current_image;
            }
        }

        //Browse Video and convert it using a selected conversion algorithm
        private void BrowseVideo_Click(object sender, EventArgs e)
        {
            //browse for a video 
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "mp4 (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get frames of the Video
                List<Image<Bgr, Byte>> image_array = new List<Image<Bgr, Byte>>();
                image_array = GetVideoFrames((int)Miliseconds_frame.Value, openFileDialog.FileName);

                //Select where output file will be stored
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Aedat file|*.Aedat";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.ShowDialog();

                // If the file name is not an empty string open it for saving.  
                if (saveFileDialog.FileName != "")
                {
                    BinaryWriter bWriter = new BinaryWriter(File.Create(saveFileDialog.FileName));
                    string method = convert_method_list.Text;

                    if (method != "")
                    {
                        //Create a new thread to convert the video
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;

                            for (int frame = 0; frame < image_array.Count; frame++)
                            {
                                //Get current image to be converted and its brightness
                                Bitmap current_image_frame = image_array[frame].Convert<Gray, Byte>().Sobel(0, 1, 3).AbsDiff(new Gray(0.0)).Resize(128, 128, 0).Bitmap;
                                float[,] pixel_matrix_frame = new float[current_image_frame.Width, current_image_frame.Height];
                                Get_pixel_bright(current_image_frame, pixel_matrix_frame);
                                bool oneframe = (frame == 0);

                                //Conver current frame
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

