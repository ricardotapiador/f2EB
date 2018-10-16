using Emgu.CV;
using Emgu.CV.Structure;
using F2EB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ImageDvs
{
    public partial class F2EB : Form
    {
        public F2EB()
        {
            InitializeComponent();
        }

        Bitmap current_image;
        float[,] pixel_matrix;
        Image<Bgr, Byte> ImageFrame;
        Algorithms conversion_algorithms;



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
            conversion_algorithms = new Algorithms((UInt32)eventlatency.Value);
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
                            Frame_Utils.Get_pixel_bright(current_image, pixel_matrix);
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
                saveFileDialog.Filter = "Aedat file|*.aedat";
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
                            conversion_algorithms.Scan_Method(pixel_matrix, bWriter, true);
                            break;
                        case "Random":
                            conversion_algorithms.Random_Method(pixel_matrix, bWriter, true);
                            break;
                        case "Bitwise":
                            conversion_algorithms.Bitwise_method(pixel_matrix, bWriter, true);
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
                Frame_Utils.Get_pixel_bright(current_image, pixel_matrix);

                //Update Picturebox with New Image
                Image_box.Image = current_image;
            }
        }

        //Browse Video and convert it using a selected conversion algorithm
        private void BrowseVideo_Click(object sender, EventArgs e)
        {
            //browse for a video 
            conversion_algorithms = new Algorithms((UInt32)eventlatency.Value);
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

        private void Convert_dataset_button_Click(object sender, EventArgs e)
        {
            string conversion_algorithm_selected = convert_method_list.Text;

            if (conversion_algorithm_selected == "" || conversion_algorithm_selected == null)
            {
                MessageBox.Show("Select Conversion");
                return;
            }
            conversion_algorithms = new Algorithms((UInt32)eventlatency.Value);
            FolderBrowserDialog folderFileDialog = new FolderBrowserDialog();

            DialogResult result = folderFileDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderFileDialog.SelectedPath))
            {

                List<string> files = new List<string>(Directory.GetFiles(folderFileDialog.SelectedPath));
                files.RemoveAll(i => i.Contains(".aedat"));
                Dataset_progress_bar.Maximum = files.Count;

                new Thread(() =>
                {
                    Dataset_progress_bar.BeginInvoke(new Action(() => Dataset_progress_bar.Value = 0));

                    foreach (string frame in files)
                    {
                        Image<Bgr, Byte> ImageDataset = new Image<Bgr, Byte>((Bitmap)Bitmap.FromFile(frame)).Resize(128, 128, 0);
                        Image<Gray, Byte> grayImage = ImageDataset.Convert<Gray, Byte>();
                        Bitmap image2event = grayImage.Bitmap;

                        float[,] bright_matrix = new float[image2event.Width, image2event.Height];
                        Frame_Utils.Get_pixel_bright(image2event, bright_matrix);
                        BinaryWriter bWriter = new BinaryWriter(File.Create(frame + ".aedat"));

                        this.Invoke((MethodInvoker)delegate
                        {
                            DataSetPictureBox.Image = grayImage.Resize(DataSetPictureBox.Width, DataSetPictureBox.Height, 0).Bitmap;
                            // runs on UI thread
                        });

                        Dataset_progress_bar.BeginInvoke(new Action(() => Dataset_progress_bar.Increment(1)));



                        /*int percent = (int)(((double)(Dataset_progress_bar.Value - Dataset_progress_bar.Minimum) /
                        (double)(Dataset_progress_bar.Maximum - Dataset_progress_bar.Minimum)) * 100);
                        using (Graphics gr = Dataset_progress_bar.CreateGraphics())
                        {
                            gr.DrawString(percent.ToString() + "%",
                                SystemFonts.DefaultFont,
                                Brushes.Black,
                                new PointF(Dataset_progress_bar.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
                                    SystemFonts.DefaultFont).Width / 2.0F),
                                Dataset_progress_bar.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                                    SystemFonts.DefaultFont).Height / 2.0F)));
                        }*/
                        switch (conversion_algorithm_selected)
                        {
                            case "Scan":
                                conversion_algorithms.Scan_Method(bright_matrix, bWriter, true);
                                break;
                            case "Random":
                                conversion_algorithms.Random_Method(bright_matrix, bWriter, true);
                                break;
                            case "Bitwise":
                                conversion_algorithms.Bitwise_method(bright_matrix, bWriter, true);
                                break;
                        }
                    }
                    System.Windows.Forms.MessageBox.Show("Dataset Converted", "Message");

                }).Start();

            }

        }
    }
}

