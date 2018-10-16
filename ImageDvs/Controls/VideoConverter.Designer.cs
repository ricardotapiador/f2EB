namespace F2EB.Controls
{
    partial class VideoConverter
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.VideoBox = new System.Windows.Forms.PictureBox();
            this.Miliseconds_frame = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventlatency = new System.Windows.Forms.NumericUpDown();
            this.convert_method_list = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.VideoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoBox
            // 
            this.VideoBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.VideoBox.Location = new System.Drawing.Point(29, 22);
            this.VideoBox.Name = "VideoBox";
            this.VideoBox.Size = new System.Drawing.Size(472, 296);
            this.VideoBox.TabIndex = 36;
            this.VideoBox.TabStop = false;
            this.VideoBox.Click += new System.EventHandler(this.VideoBox_Click);
            // 
            // Miliseconds_frame
            // 
            this.Miliseconds_frame.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Miliseconds_frame.Location = new System.Drawing.Point(39, 436);
            this.Miliseconds_frame.Margin = new System.Windows.Forms.Padding(4);
            this.Miliseconds_frame.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Miliseconds_frame.Name = "Miliseconds_frame";
            this.Miliseconds_frame.Size = new System.Drawing.Size(160, 22);
            this.Miliseconds_frame.TabIndex = 29;
            this.Miliseconds_frame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Conversion Method";
            // 
            // BrowseVideo
            // 
            this.BrowseVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BrowseVideo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseVideo.Location = new System.Drawing.Point(29, 329);
            this.BrowseVideo.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseVideo.Name = "BrowseVideo";
            this.BrowseVideo.Size = new System.Drawing.Size(472, 54);
            this.BrowseVideo.TabIndex = 35;
            this.BrowseVideo.Text = "Browse Video";
            this.BrowseVideo.UseVisualStyleBackColor = false;
            this.BrowseVideo.Click += new System.EventHandler(this.BrowseVideo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Video Capture Time(ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "(us tick)";
            // 
            // eventlatency
            // 
            this.eventlatency.Location = new System.Drawing.Point(377, 437);
            this.eventlatency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventlatency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.eventlatency.Name = "eventlatency";
            this.eventlatency.Size = new System.Drawing.Size(93, 22);
            this.eventlatency.TabIndex = 31;
            this.eventlatency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // convert_method_list
            // 
            this.convert_method_list.FormattingEnabled = true;
            this.convert_method_list.Items.AddRange(new object[] {
            "Scan",
            "Random",
            "Bitwise",
            "4"});
            this.convert_method_list.Location = new System.Drawing.Point(231, 436);
            this.convert_method_list.Margin = new System.Windows.Forms.Padding(4);
            this.convert_method_list.Name = "convert_method_list";
            this.convert_method_list.Size = new System.Drawing.Size(90, 24);
            this.convert_method_list.TabIndex = 27;
            // 
            // VideoConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VideoBox);
            this.Controls.Add(this.Miliseconds_frame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrowseVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventlatency);
            this.Controls.Add(this.convert_method_list);
            this.Name = "VideoConverter";
            this.Size = new System.Drawing.Size(529, 508);
            ((System.ComponentModel.ISupportInitialize)(this.VideoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Miliseconds_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox VideoBox;
        private System.Windows.Forms.NumericUpDown Miliseconds_frame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowseVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown eventlatency;
        private System.Windows.Forms.ComboBox convert_method_list;
    }
}
