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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagePreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoButton.Location = new System.Drawing.Point(286, 542);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(28, 27);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(40, 150);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(245, 23);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 1;
            // 
            // ExtractImagesButton
            // 
            this.ExtractImagesButton.FlatAppearance.BorderSize = 0;
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
            this.DropDownBox.Location = new System.Drawing.Point(164, 187);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 61);
            this.label2.TabIndex = 6;
            this.label2.Text = "Image Grabber";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorModeToolStripMenuItem,
            this.imagePreviewToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // colorModeToolStripMenuItem
            // 
            this.colorModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DarkModeToolStripMenuItem,
            this.LightModeToolStripMenuItem});
            this.colorModeToolStripMenuItem.Name = "colorModeToolStripMenuItem";
            this.colorModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorModeToolStripMenuItem.Text = "Color Mode";
            // 
            // DarkModeToolStripMenuItem
            // 
            this.DarkModeToolStripMenuItem.Checked = true;
            this.DarkModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem";
            this.DarkModeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.DarkModeToolStripMenuItem.Text = "Dark Mode";
            this.DarkModeToolStripMenuItem.Click += new System.EventHandler(this.DarkModeToolStripMenuItem_Click);
            // 
            // LightModeToolStripMenuItem
            // 
            this.LightModeToolStripMenuItem.Name = "LightModeToolStripMenuItem";
            this.LightModeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.LightModeToolStripMenuItem.Text = "Light Mode";
            this.LightModeToolStripMenuItem.Click += new System.EventHandler(this.LightModeToolStripMenuItem_Click);
            // 
            // imagePreviewToolStripMenuItem
            // 
            this.imagePreviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnToolStripMenuItem,
            this.OffToolStripMenuItem});
            this.imagePreviewToolStripMenuItem.Name = "imagePreviewToolStripMenuItem";
            this.imagePreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagePreviewToolStripMenuItem.Text = "Image Preview";
            // 
            // OnToolStripMenuItem
            // 
            this.OnToolStripMenuItem.Checked = true;
            this.OnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OnToolStripMenuItem.Name = "OnToolStripMenuItem";
            this.OnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OnToolStripMenuItem.Text = "On";
            this.OnToolStripMenuItem.Click += new System.EventHandler(this.OnToolStripMenuItem_Click);
            // 
            // OffToolStripMenuItem
            // 
            this.OffToolStripMenuItem.Name = "OffToolStripMenuItem";
            this.OffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OffToolStripMenuItem.Text = "Off";
            this.OffToolStripMenuItem.Click += new System.EventHandler(this.OffToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(330, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DropDownBox);
            this.Controls.Add(this.ExtractImagesButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF Image Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DarkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagePreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OffToolStripMenuItem;
    }
}

