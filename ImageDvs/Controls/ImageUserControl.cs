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

namespace F2EB
{
    public partial class ImageUserControl : UserControl
    {
        public ImageUserControl()
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

        private void eventlatency_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
