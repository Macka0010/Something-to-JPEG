namespace PDF_2_JPEG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ExtractImagesButton = new System.Windows.Forms.Button();
            this.DropDownBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoButton.Location = new System.Drawing.Point(286, 547);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(28, 27);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(42, 150);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(245, 23);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 1;
            // 
            // ExtractImagesButton
            // 
            this.ExtractImagesButton.FlatAppearance.BorderSize = 0;
            this.ExtractImagesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(101)))), ((int)(((byte)(103)))));
            this.ExtractImagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtractImagesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractImagesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExtractImagesButton.Location = new System.Drawing.Point(100, 103);
            this.ExtractImagesButton.Name = "ExtractImagesButton";
            this.ExtractImagesButton.Size = new System.Drawing.Size(129, 28);
            this.ExtractImagesButton.TabIndex = 2;
            this.ExtractImagesButton.Text = "Extract Images!";
            this.ExtractImagesButton.UseVisualStyleBackColor = true;
            this.ExtractImagesButton.Click += new System.EventHandler(this.ExtractImagesButton_Click);
            // 
            // DropDownBox
            // 
            this.DropDownBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownBox.FormattingEnabled = true;
            this.DropDownBox.Items.AddRange(new object[] {
            "Normal",
            "Sliced PDF",
            "Inverted PDF",
            "Full Page Images"});
            this.DropDownBox.Location = new System.Drawing.Point(168, 187);
            this.DropDownBox.Name = "DropDownBox";
            this.DropDownBox.Size = new System.Drawing.Size(121, 27);
            this.DropDownBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Option";
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(14, 240);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(300, 300);
            this.PicBox.TabIndex = 5;
            this.PicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(330, 575);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DropDownBox);
            this.Controls.Add(this.ExtractImagesButton);
            this.Controls.Add(this.ProgressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF Image Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button ExtractImagesButton;
        private System.Windows.Forms.ComboBox DropDownBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBox;
    }
}

