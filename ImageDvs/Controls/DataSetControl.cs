using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;

namespace F2EB.Controls
{
    public partial class DataSetControl : UserControl
    {
        public DataSetControl()
        {
            InitializeComponent();
        }

        private void Convert_dataset_button_Click(object sender, EventArgs e)
        {
            string conversion_algorithm_selected = convert_method_list.Text;

            if (conversion_algorithm_selected == "" || conversion_algorithm_selected == null)
            {
                MessageBox.Show("Select Conversion");
                return;
            }
            Algorithms conversion_algorithms = new Algorithms((UInt32)eventlatency.Value);
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
