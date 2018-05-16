namespace ImageDvs
{
    partial class FRAME2DVS
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.convert_method_list = new System.Windows.Forms.ComboBox();
            this.filter_list = new System.Windows.Forms.ComboBox();
            this.Miliseconds_frame = new System.Windows.Forms.NumericUpDown();
            this.Apply = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConvertFrame = new MaterialSkin.Controls.MaterialFlatButton();
            this.BrowseImage = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.eventlatency = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseVideo = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(428, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 384);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // convert_method_list
            // 
            this.convert_method_list.FormattingEnabled = true;
            this.convert_method_list.Items.AddRange(new object[] {
            "SCAN",
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
            this.filter_list.Location = new System.Drawing.Point(214, 112);
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
            this.Miliseconds_frame.Location = new System.Drawing.Point(36, 322);
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
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Apply.Depth = 0;
            this.Apply.Location = new System.Drawing.Point(244, 162);
            this.Apply.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Apply.MouseState = MaterialSkin.MouseState.HOVER;
            this.Apply.Name = "Apply";
            this.Apply.Primary = false;
            this.Apply.Size = new System.Drawing.Size(54, 36);
            this.Apply.TabIndex = 10;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ConvertFrame
            // 
            this.ConvertFrame.AutoSize = true;
            this.ConvertFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConvertFrame.Depth = 0;
            this.ConvertFrame.Location = new System.Drawing.Point(148, 208);
            this.ConvertFrame.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConvertFrame.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConvertFrame.Name = "ConvertFrame";
            this.ConvertFrame.Primary = false;
            this.ConvertFrame.Size = new System.Drawing.Size(74, 36);
            this.ConvertFrame.TabIndex = 11;
            this.ConvertFrame.Text = "Convert";
            this.ConvertFrame.UseVisualStyleBackColor = true;
            this.ConvertFrame.Click += new System.EventHandler(this.Convert_Click);
            // 
            // BrowseImage
            // 
            this.BrowseImage.AutoSize = true;
            this.BrowseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseImage.Depth = 0;
            this.BrowseImage.Location = new System.Drawing.Point(28, 162);
            this.BrowseImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BrowseImage.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseImage.Name = "BrowseImage";
            this.BrowseImage.Primary = false;
            this.BrowseImage.Size = new System.Drawing.Size(112, 36);
            this.BrowseImage.TabIndex = 12;
            this.BrowseImage.Text = "Browse Image";
            this.BrowseImage.UseVisualStyleBackColor = true;
            this.BrowseImage.Click += new System.EventHandler(this.BrowseImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Video Capture Time(ms)";
            // 
            // eventlatency
            // 
            this.eventlatency.Location = new System.Drawing.Point(106, 403);
            this.eventlatency.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label2.Location = new System.Drawing.Point(94, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time between events(us tick)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 95);
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
            // BrowseVideo
            // 
            this.BrowseVideo.AutoSize = true;
            this.BrowseVideo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowseVideo.Depth = 0;
            this.BrowseVideo.Location = new System.Drawing.Point(244, 306);
            this.BrowseVideo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BrowseVideo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowseVideo.Name = "BrowseVideo";
            this.BrowseVideo.Primary = false;
            this.BrowseVideo.Size = new System.Drawing.Size(109, 36);
            this.BrowseVideo.TabIndex = 18;
            this.BrowseVideo.Text = "Browse Video";
            this.BrowseVideo.UseVisualStyleBackColor = true;
            this.BrowseVideo.Click += new System.EventHandler(this.BrowseVideo_Click);
            // 
            // FRAME2DVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 551);
            this.Controls.Add(this.BrowseVideo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventlatency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseImage);
            this.Controls.Add(this.ConvertFrame);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Miliseconds_frame);
            this.Controls.Add(this.filter_list);
            this.Controls.Add(this.convert_method_list);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FRAME2DVS";
            this.Text = "FRAME2DVS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox convert_method_list;
        private System.Windows.Forms.ComboBox filter_list;
        private System.Windows.Forms.NumericUpDown Miliseconds_frame;
        private MaterialSkin.Controls.MaterialFlatButton Apply;
        private MaterialSkin.Controls.MaterialFlatButton ConvertFrame;
        private MaterialSkin.Controls.MaterialFlatButton BrowseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown eventlatency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton BrowseVideo;
    }
}

