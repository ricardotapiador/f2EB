namespace ImageDvs
{
    partial class F2EB
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F2EB));
            this.Image_box = new System.Windows.Forms.PictureBox();
            this.convert_method_list = new System.Windows.Forms.ComboBox();
            this.filter_list = new System.Windows.Forms.ComboBox();
            this.Miliseconds_frame = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.eventlatency = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseImage = new System.Windows.Forms.Button();
            this.ConvertFrame = new System.Windows.Forms.Button();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.BrowseVideo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DataSetPictureBox = new System.Windows.Forms.PictureBox();
            this.Dataset_progress_bar = new System.Windows.Forms.ProgressBar();
            this.Convert_dataset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_box
            // 
            this.Image_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image_box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Image_box.Location = new System.Drawing.Point(66, 22);
            this.Image_box.Margin = new System.Windows.Forms.Padding(4);
            this.Image_box.Name = "Image_box";
            this.Image_box.Size = new System.Drawing.Size(753, 510);
            this.Image_box.TabIndex = 0;
            this.Image_box.TabStop = false;
            // 
            // convert_method_list
            // 
            this.convert_method_list.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.convert_method_list.FormattingEnabled = true;
            this.convert_method_list.Items.AddRange(new object[] {
            "Scan",
            "Random",
            "Bitwise",
            "4"});
            this.convert_method_list.Location = new System.Drawing.Point(978, 199);
            this.convert_method_list.Margin = new System.Windows.Forms.Padding(4);
            this.convert_method_list.Name = "convert_method_list";
            this.convert_method_list.Size = new System.Drawing.Size(90, 24);
            this.convert_method_list.TabIndex = 2;
            // 
            // filter_list
            // 
            this.filter_list.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filter_list.FormattingEnabled = true;
            this.filter_list.Items.AddRange(new object[] {
            "Sobel Vertical",
            "Sobel Horizontal",
            "Laplacian",
            "Gaussian"});
            this.filter_list.Location = new System.Drawing.Point(975, 320);
            this.filter_list.Margin = new System.Windows.Forms.Padding(4);
            this.filter_list.Name = "filter_list";
            this.filter_list.Size = new System.Drawing.Size(93, 24);
            this.filter_list.TabIndex = 4;
            // 
            // Miliseconds_frame
            // 
            this.Miliseconds_frame.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Miliseconds_frame.Location = new System.Drawing.Point(271, 66);
            this.Miliseconds_frame.Margin = new System.Windows.Forms.Padding(4);
            this.Miliseconds_frame.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Miliseconds_frame.Name = "Miliseconds_frame";
            this.Miliseconds_frame.Size = new System.Drawing.Size(160, 22);
            this.Miliseconds_frame.TabIndex = 7;
            this.Miliseconds_frame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Video Capture Time(ms)";
            // 
            // eventlatency
            // 
            this.eventlatency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.eventlatency.Location = new System.Drawing.Point(975, 253);
            this.eventlatency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventlatency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.eventlatency.Name = "eventlatency";
            this.eventlatency.Size = new System.Drawing.Size(93, 22);
            this.eventlatency.TabIndex = 14;
            this.eventlatency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(926, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time between events(us tick)";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1003, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filter";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(958, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Conversion Method";
            // 
            // BrowseImage
            // 
            this.BrowseImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BrowseImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseImage.Location = new System.Drawing.Point(66, 567);
            this.BrowseImage.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseImage.Name = "BrowseImage";
            this.BrowseImage.Size = new System.Drawing.Size(216, 54);
            this.BrowseImage.TabIndex = 22;
            this.BrowseImage.Text = "Browse Image";
            this.BrowseImage.UseVisualStyleBackColor = false;
            this.BrowseImage.Click += new System.EventHandler(this.BrowseImage_Click);
            // 
            // ConvertFrame
            // 
            this.ConvertFrame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConvertFrame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConvertFrame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConvertFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertFrame.Location = new System.Drawing.Point(603, 567);
            this.ConvertFrame.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertFrame.Name = "ConvertFrame";
            this.ConvertFrame.Size = new System.Drawing.Size(216, 54);
            this.ConvertFrame.TabIndex = 23;
            this.ConvertFrame.Text = "Convert Frame";
            this.ConvertFrame.UseVisualStyleBackColor = false;
            this.ConvertFrame.Click += new System.EventHandler(this.ConvertFrame_Click);
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ApplyFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyFilter.Location = new System.Drawing.Point(364, 567);
            this.ApplyFilter.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(184, 54);
            this.ApplyFilter.TabIndex = 24;
            this.ApplyFilter.Text = "Apply Filter";
            this.ApplyFilter.UseVisualStyleBackColor = false;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // BrowseVideo
            // 
            this.BrowseVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BrowseVideo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseVideo.Location = new System.Drawing.Point(261, 128);
            this.BrowseVideo.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseVideo.Name = "BrowseVideo";
            this.BrowseVideo.Size = new System.Drawing.Size(184, 54);
            this.BrowseVideo.TabIndex = 25;
            this.BrowseVideo.Text = "Browse Video";
            this.BrowseVideo.UseVisualStyleBackColor = false;
            this.BrowseVideo.Click += new System.EventHandler(this.BrowseVideo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 692);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BrowseImage);
            this.tabPage1.Controls.Add(this.ConvertFrame);
            this.tabPage1.Controls.Add(this.ApplyFilter);
            this.tabPage1.Controls.Add(this.Image_box);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(898, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image Tools";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Miliseconds_frame);
            this.tabPage2.Controls.Add(this.BrowseVideo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(898, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video Tools";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DataSetPictureBox);
            this.tabPage3.Controls.Add(this.Dataset_progress_bar);
            this.tabPage3.Controls.Add(this.Convert_dataset_button);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(898, 663);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DataSets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DataSetPictureBox
            // 
            this.DataSetPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSetPictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataSetPictureBox.Location = new System.Drawing.Point(79, 6);
            this.DataSetPictureBox.Name = "DataSetPictureBox";
            this.DataSetPictureBox.Size = new System.Drawing.Size(753, 510);
            this.DataSetPictureBox.TabIndex = 25;
            this.DataSetPictureBox.TabStop = false;
            // 
            // Dataset_progress_bar
            // 
            this.Dataset_progress_bar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Dataset_progress_bar.Location = new System.Drawing.Point(144, 522);
            this.Dataset_progress_bar.Name = "Dataset_progress_bar";
            this.Dataset_progress_bar.Size = new System.Drawing.Size(599, 40);
            this.Dataset_progress_bar.TabIndex = 24;
            // 
            // Convert_dataset_button
            // 
            this.Convert_dataset_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Convert_dataset_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Convert_dataset_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Convert_dataset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Convert_dataset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_dataset_button.Location = new System.Drawing.Point(310, 569);
            this.Convert_dataset_button.Margin = new System.Windows.Forms.Padding(4);
            this.Convert_dataset_button.Name = "Convert_dataset_button";
            this.Convert_dataset_button.Size = new System.Drawing.Size(216, 54);
            this.Convert_dataset_button.TabIndex = 23;
            this.Convert_dataset_button.Text = "Convert DataSet";
            this.Convert_dataset_button.UseVisualStyleBackColor = false;
            this.Convert_dataset_button.Click += new System.EventHandler(this.Convert_dataset_button_Click);
            // 
            // F2EB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 708);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventlatency);
            this.Controls.Add(this.filter_list);
            this.Controls.Add(this.convert_method_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F2EB";
            this.Text = "F2EB";
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image_box;
        private System.Windows.Forms.ComboBox convert_method_list;
        private System.Windows.Forms.ComboBox filter_list;
        private System.Windows.Forms.NumericUpDown Miliseconds_frame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown eventlatency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowseImage;
        private System.Windows.Forms.Button ConvertFrame;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.Button BrowseVideo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Convert_dataset_button;
        private System.Windows.Forms.ProgressBar Dataset_progress_bar;
        private System.Windows.Forms.PictureBox DataSetPictureBox;
    }
}

