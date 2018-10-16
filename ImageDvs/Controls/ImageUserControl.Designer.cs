namespace F2EB
{
    partial class ImageUserControl
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
            this.Image_box = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplyFilter = new System.Windows.Forms.Button();
            this.eventlatency = new System.Windows.Forms.NumericUpDown();
            this.ConvertFrame = new System.Windows.Forms.Button();
            this.filter_list = new System.Windows.Forms.ComboBox();
            this.convert_method_list = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_box
            // 
            this.Image_box.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Image_box.Location = new System.Drawing.Point(0, 0);
            this.Image_box.Name = "Image_box";
            this.Image_box.Size = new System.Drawing.Size(388, 328);
            this.Image_box.TabIndex = 46;
            this.Image_box.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Conversion Method";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Filter";
            // 
            // BrowseImage
            // 
            this.BrowseImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseImage.Location = new System.Drawing.Point(0, 326);
            this.BrowseImage.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseImage.Name = "BrowseImage";
            this.BrowseImage.Size = new System.Drawing.Size(388, 72);
            this.BrowseImage.TabIndex = 37;
            this.BrowseImage.Text = "Browse Image";
            this.BrowseImage.UseVisualStyleBackColor = false;
            this.BrowseImage.Click += new System.EventHandler(this.BrowseImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Time between events(us tick)";
            // 
            // ApplyFilter
            // 
            this.ApplyFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ApplyFilter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyFilter.Location = new System.Drawing.Point(0, 398);
            this.ApplyFilter.Margin = new System.Windows.Forms.Padding(4);
            this.ApplyFilter.Name = "ApplyFilter";
            this.ApplyFilter.Size = new System.Drawing.Size(388, 71);
            this.ApplyFilter.TabIndex = 39;
            this.ApplyFilter.Text = "Apply Filter";
            this.ApplyFilter.UseVisualStyleBackColor = false;
            this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
            // 
            // eventlatency
            // 
            this.eventlatency.Location = new System.Drawing.Point(429, 179);
            this.eventlatency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventlatency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.eventlatency.Name = "eventlatency";
            this.eventlatency.Size = new System.Drawing.Size(89, 22);
            this.eventlatency.TabIndex = 42;
            this.eventlatency.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.eventlatency.ValueChanged += new System.EventHandler(this.eventlatency_ValueChanged);
            // 
            // ConvertFrame
            // 
            this.ConvertFrame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConvertFrame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ConvertFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertFrame.Location = new System.Drawing.Point(0, 469);
            this.ConvertFrame.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertFrame.Name = "ConvertFrame";
            this.ConvertFrame.Size = new System.Drawing.Size(388, 72);
            this.ConvertFrame.TabIndex = 38;
            this.ConvertFrame.Text = "Convert Frame";
            this.ConvertFrame.UseVisualStyleBackColor = false;
            this.ConvertFrame.Click += new System.EventHandler(this.ConvertFrame_Click);
            // 
            // filter_list
            // 
            this.filter_list.FormattingEnabled = true;
            this.filter_list.Items.AddRange(new object[] {
            "Sobel Vertical",
            "Sobel Horizontal",
            "Laplacian",
            "Gaussian"});
            this.filter_list.Location = new System.Drawing.Point(430, 73);
            this.filter_list.Margin = new System.Windows.Forms.Padding(4);
            this.filter_list.Name = "filter_list";
            this.filter_list.Size = new System.Drawing.Size(93, 24);
            this.filter_list.TabIndex = 41;
            // 
            // convert_method_list
            // 
            this.convert_method_list.FormattingEnabled = true;
            this.convert_method_list.Items.AddRange(new object[] {
            "Scan",
            "Random",
            "Bitwise",
            "4"});
            this.convert_method_list.Location = new System.Drawing.Point(429, 124);
            this.convert_method_list.Margin = new System.Windows.Forms.Padding(4);
            this.convert_method_list.Name = "convert_method_list";
            this.convert_method_list.Size = new System.Drawing.Size(90, 24);
            this.convert_method_list.TabIndex = 40;
            // 
            // ImageUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Image_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrowseImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApplyFilter);
            this.Controls.Add(this.eventlatency);
            this.Controls.Add(this.ConvertFrame);
            this.Controls.Add(this.filter_list);
            this.Controls.Add(this.convert_method_list);
            this.Name = "ImageUserControl";
            this.Size = new System.Drawing.Size(589, 545);
            ((System.ComponentModel.ISupportInitialize)(this.Image_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ApplyFilter;
        private System.Windows.Forms.NumericUpDown eventlatency;
        private System.Windows.Forms.Button ConvertFrame;
        private System.Windows.Forms.ComboBox filter_list;
        private System.Windows.Forms.ComboBox convert_method_list;
    }
}
