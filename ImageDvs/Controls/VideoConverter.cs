using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using System.Threading;

namespace F2EB.Controls
{
    public partial class VideoConverter : UserControl
    {
        public VideoConverter()
        {
            InitializeComponent();
        }

        //Browse Video and convert it using a selected conversion algorithm
        private void BrowseVideo_Click(object sender, EventArgs e)
        {
            //browse for a video 
            Algorithms conversion_algorithms = new Algorithms((UInt32)eventlatency.Value);
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "mp4 (*.mp4)|*.mp4|avi files (*.avi)|*.avi|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get frames of the Video
                List<Image<Bgr, Byte>> image_array = new List<Image<Bgr, Byte>>();
                image_array = Frame_Utils.GetVideoFrames((int)Miliseconds_frame.Value, openFileDialog.FileName);

                //Select where output file will be stored
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Aedat file|*.aedat";
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
                                VideoBox.Image = image_array[frame].Resize(VideoBox.Width, VideoBox.Height, 0).Bitmap;
                                float[,] pixel_matrix_frame = new float[current_image_frame.Width, current_image_frame.Height];
                                Frame_Utils.Get_pixel_bright(current_image_frame, pixel_matrix_frame);
                                bool oneframe = (frame == 0);
                                //Conver current frame
                                switch (method)
                                {
                                    case "Scan":
                                        conversion_algorithms.Scan_Method(pixel_matrix_frame, bWriter, oneframe);
                                        break;
                                    case "Random":
                                        conversion_algorithms.Random_Method(pixel_matrix_frame, bWriter, oneframe);
                                        break;
                                    case "Bitwise":
                                        conversion_algorithms.Bitwise_method(pixel_matrix_frame, bWriter, oneframe);
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

        private void VideoBox_Click(object sender, EventArgs e)
        {

        }
    }
}
