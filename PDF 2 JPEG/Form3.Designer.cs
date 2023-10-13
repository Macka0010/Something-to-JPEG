namespace PDF_2_JPEG
{
    partial class EmailGrabber
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
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.ReplaceFileButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FileGrabTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoButton.Location = new System.Drawing.Point(186, 244);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(23, 23);
            this.InfoButton.TabIndex = 12;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatusBox.Enabled = false;
            this.StatusBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.HideSelection = false;
            this.StatusBox.Location = new System.Drawing.Point(9, 9);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(0);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(200, 33);
            this.StatusBox.TabIndex = 11;
            this.StatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReplaceFileButton
            // 
            this.ReplaceFileButton.FlatAppearance.BorderSize = 0;
            this.ReplaceFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceFileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceFileButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReplaceFileButton.Location = new System.Drawing.Point(68, 191);
            this.ReplaceFileButton.Name = "ReplaceFileButton";
            this.ReplaceFileButton.Size = new System.Drawing.Size(82, 30);
            this.ReplaceFileButton.TabIndex = 10;
            this.ReplaceFileButton.Text = "Replace!";
            this.ReplaceFileButton.UseVisualStyleBackColor = true;
            this.ReplaceFileButton.Click += new System.EventHandler(this.ReplaceFileButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.FlatAppearance.BorderSize = 0;
            this.GetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GetButton.Location = new System.Drawing.Point(68, 145);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(82, 28);
            this.GetButton.TabIndex = 9;
            this.GetButton.Text = "Get!";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Paste directory of msg to get.";
            // 
            // FileGrabTextbox
            // 
            this.FileGrabTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileGrabTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileGrabTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileGrabTextbox.Location = new System.Drawing.Point(19, 102);
            this.FileGrabTextbox.Name = "FileGrabTextbox";
            this.FileGrabTextbox.Size = new System.Drawing.Size(180, 24);
            this.FileGrabTextbox.TabIndex = 7;
            // 
            // EmailGrabber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(220, 278);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.ReplaceFileButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileGrabTextbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(236, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(236, 317);
            this.Name = "EmailGrabber";
            this.Text = "MSG Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Button ReplaceFileButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileGrabTextbox;
    }
}