namespace F2EB.Controls
{
    partial class DataSetControl
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
            this.DataSetPictureBox = new System.Windows.Forms.PictureBox();
            this.Dataset_progress_bar = new System.Windows.Forms.ProgressBar();
            this.Convert_dataset_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventlatency = new System.Windows.Forms.NumericUpDown();
            this.filter_list = new System.Windows.Forms.ComboBox();
            this.convert_method_list = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSetPictureBox
            // 
            this.DataSetPictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DataSetPictureBox.Location = new System.Drawing.Point(0, 0);
            this.DataSetPictureBox.Name = "DataSetPictureBox";
            this.DataSetPictureBox.Size = new System.Drawing.Size(394, 392);
            this.DataSetPictureBox.TabIndex = 27;
            this.DataSetPictureBox.TabStop = false;
            // 
            // Dataset_progress_bar
            // 
            this.Dataset_progress_bar.Location = new System.Drawing.Point(0, 398);
            this.Dataset_progress_bar.Name = "Dataset_progress_bar";
            this.Dataset_progress_bar.Size = new System.Drawing.Size(394, 40);
            this.Dataset_progress_bar.TabIndex = 26;
            // 
            // Convert_dataset_button
            // 
            this.Convert_dataset_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Convert_dataset_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Convert_dataset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Convert_dataset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert_dataset_button.Location = new System.Drawing.Point(0, 440);
            this.Convert_dataset_button.Margin = new System.Windows.Forms.Padding(4);
            this.Convert_dataset_button.Name = "Convert_dataset_button";
            this.Convert_dataset_button.Size = new System.Drawing.Size(394, 54);
            this.Convert_dataset_button.TabIndex = 28;
            this.Convert_dataset_button.Text = "Convert DataSet";
            this.Convert_dataset_button.UseVisualStyleBackColor = false;
            this.Convert_dataset_button.Click += new System.EventHandler(this.Convert_dataset_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Conversion Method";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "(us tick)";
            // 
            // eventlatency
            // 
            this.eventlatency.Location = new System.Drawing.Point(442, 147);
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
            // filter_list
            // 
            this.filter_list.FormattingEnabled = true;
            this.filter_list.Items.AddRange(new object[] {
            "Sobel Vertical",
            "Sobel Horizontal",
            "Laplacian",
            "Gaussian"});
            this.filter_list.Location = new System.Drawing.Point(442, 206);
            this.filter_list.Margin = new System.Windows.Forms.Padding(4);
            this.filter_list.Name = "filter_list";
            this.filter_list.Size = new System.Drawing.Size(93, 24);
            this.filter_list.TabIndex = 30;
            // 
            // convert_method_list
            // 
            this.convert_method_list.FormattingEnabled = true;
            this.convert_method_list.Items.AddRange(new object[] {
            "Scan",
            "Random",
            "Bitwise",
            "4"});
            this.convert_method_list.Location = new System.Drawing.Point(445, 93);
            this.convert_method_list.Margin = new System.Windows.Forms.Padding(4);
            this.convert_method_list.Name = "convert_method_list";
            this.convert_method_list.Size = new System.Drawing.Size(90, 24);
            this.convert_method_list.TabIndex = 29;
            // 
            // DataSetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventlatency);
            this.Controls.Add(this.filter_list);
            this.Controls.Add(this.convert_method_list);
            this.Controls.Add(this.Convert_dataset_button);
            this.Controls.Add(this.DataSetPictureBox);
            this.Controls.Add(this.Dataset_progress_bar);
            this.Name = "DataSetControl";
            this.Size = new System.Drawing.Size(565, 555);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventlatency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DataSetPictureBox;
        private System.Windows.Forms.ProgressBar Dataset_progress_bar;
        private System.Windows.Forms.Button Convert_dataset_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown eventlatency;
        private System.Windows.Forms.ComboBox filter_list;
        private System.Windows.Forms.ComboBox convert_method_list;
    }
}
