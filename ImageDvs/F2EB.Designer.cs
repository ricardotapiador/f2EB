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
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Image_box
            // 
            this.Image_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image_box.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Image_box.Location = new System.Drawing.Point(598, 73);
            this.Image_box.Name = "Image_box";
            this.Image_box.Size = new System.Drawing.Size(737, 475);
            this.Image_box.TabIndex = 0;
            this.Image_box.TabStop = false;
            // 
            // convert_method_list
            // 
            this.convert_method_list.FormattingEnabled = true;
            this.convert_method_list.Items.AddRange(new object[] {
            "Scan",
            "Random",
            "Bitwise",
            "4"});
            this.convert_method_list.Location = new System.Drawing.Point(28, 112);
            this.convert_method_list.Name = "convert_method_list";
            this.convert_method_list.Size = new System.Drawing.Size(121, 21);
            this.convert_method_list.TabIndex = 2;
            // 
            // filter_list
            // 
            this.filter_list.FormattingEnabled = true;
            this.filter_list.Items.AddRange(new object[] {
            "Sobel Vertical",
            "Sobel Horizontal",
            "Laplacian",
            "Gaussian"});
            this.filter_list.Location = new System.Drawing.Point(421, 112);
            this.filter_list.Name = "filter_list";
            this.filter_list.Size = new System.Drawing.Size(121, 21);
            this.filter_list.TabIndex = 4;
            // 
            // Miliseconds_frame
            // 
            this.Miliseconds_frame.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Miliseconds_frame.Location = new System.Drawing.Point(203, 54);
            this.Miliseconds_frame.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Miliseconds_frame.Name = "Miliseconds_frame";
            this.Miliseconds_frame.Size = new System.Drawing.Size(120, 20);
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
            this.label1.Location = new System.Drawing.Point(202, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Video Capture Time(ms)";
            // 
            // eventlatency
            // 
            this.eventlatency.Location = new System.Drawing.Point(235, 113);
            this.eventlatency.Margin = new System.Windows.Forms.Padding(2);
            this.eventlatency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.eventlatency.Name = "eventlatency";
            this.eventlatency.Size = new System.Drawing.Size(118, 20);
            this.eventlatency.TabIndex = 14;
            this.eventlatency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time between events(us tick)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Conversion Method";
            // 
            // BrowseImage
            // 
            this.BrowseImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseImage.Location = new System.Drawing.Point(22, 75);
            this.BrowseImage.Name = "BrowseImage";
            this.BrowseImage.Size = new System.Drawing.Size(162, 44);
            this.BrowseImage.TabIndex = 22;
            this.BrowseImage.Text = "Browse Image";
            this.BrowseImage.UseVisualStyleBackColor = false;
            this.BrowseImage.Click += new System.EventHandler(this.BrowseImage_Click);
            // 
            // ConvertFrame
            // 
            this.ConvertFrame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConvertFrame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConvertFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertFrame.Location = new System.Drawing.Point(377, 75);
            this.ConvertFrame.Name = "ConvertFrame";
            this.ConvertFrame.Size = new System.Drawing.Size(162, 44);
            this.ConvertFrame.TabIndex = 23;
            this.ConvertFrame.Text = "Convert Frame";
            this.ConvertFrame.UseVisualStyleBackColor = false;
            this.ConvertFrame.Click += new System.EventHandler(this.ConvertFrame_Click);
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyFilter.Location = new System.Drawing.Point(212, 75);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(138, 44);
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
            this.BrowseVideo.Location = new System.Drawing.Point(196, 104);
            this.BrowseVideo.Name = "BrowseVideo";
            this.BrowseVideo.Size = new System.Drawing.Size(138, 44);
            this.BrowseVideo.TabIndex = 25;
            this.BrowseVideo.Text = "Browse Video";
            this.BrowseVideo.UseVisualStyleBackColor = false;
            this.BrowseVideo.Click += new System.EventHandler(this.BrowseVideo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 201);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 351);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BrowseImage);
            this.tabPage1.Controls.Add(this.ConvertFrame);
            this.tabPage1.Controls.Add(this.ApplyFilter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image Tools";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Miliseconds_frame);
            this.tabPage2.Controls.Add(this.BrowseVideo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video Tools";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // F2EB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventlatency);
            this.Controls.Add(this.filter_list);
            this.Controls.Add(this.convert_method_list);
            this.Controls.Add(this.Image_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F2EB";
            this.Text = "F2EB";
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}

