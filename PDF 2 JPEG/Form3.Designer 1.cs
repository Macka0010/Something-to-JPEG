namespace Email_Grabber
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.InfoButton.Location = new System.Drawing.Point(241, 354);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(23, 23);
            this.InfoButton.TabIndex = 14;
            this.InfoButton.Text = "?";
            this.InfoButton.UseVisualStyleBackColor = true;
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.StatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatusBox.Enabled = false;
            this.StatusBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.HideSelection = false;
            this.StatusBox.Location = new System.Drawing.Point(64, 119);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(0);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(200, 33);
            this.StatusBox.TabIndex = 13;
            this.StatusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StatusBox.TextChanged += new System.EventHandler(this.StatusBox_TextChanged);
            // 
            // ReplaceFileButton
            // 
            this.ReplaceFileButton.FlatAppearance.BorderSize = 0;
            this.ReplaceFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceFileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplaceFileButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReplaceFileButton.Location = new System.Drawing.Point(123, 301);
            this.ReplaceFileButton.Name = "ReplaceFileButton";
            this.ReplaceFileButton.Size = new System.Drawing.Size(82, 30);
            this.ReplaceFileButton.TabIndex = 12;
            this.ReplaceFileButton.Text = "Replace!";
            this.ReplaceFileButton.UseVisualStyleBackColor = true;
            // 
            // GetButton
            // 
            this.GetButton.FlatAppearance.BorderSize = 0;
            this.GetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GetButton.Location = new System.Drawing.Point(123, 255);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(82, 28);
            this.GetButton.TabIndex = 11;
            this.GetButton.Text = "Get!";
            this.GetButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paste directory of msg to get.";
            // 
            // FileGrabTextbox
            // 
            this.FileGrabTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileGrabTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileGrabTextbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileGrabTextbox.Location = new System.Drawing.Point(74, 212);
            this.FileGrabTextbox.Name = "FileGrabTextbox";
            this.FileGrabTextbox.Size = new System.Drawing.Size(180, 24);
            this.FileGrabTextbox.TabIndex = 9;
            this.FileGrabTextbox.TextChanged += new System.EventHandler(this.FileGrabTextbox_TextChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 15;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem5,
            this.toolStripMenuItem8,
            this.toolStripMenuItem11});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(39, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem2.Text = "Dark Mode";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem3.Text = "Dark Mode";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(134, 22);
            this.toolStripMenuItem4.Text = "Light Mode";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem5.Text = "Image Preview";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Checked = true;
            this.toolStripMenuItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem6.Text = "On";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem7.Text = "Off";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem8.Text = "Auto Open PDF Folder";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Checked = true;
            this.toolStripMenuItem9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem9.Text = "On";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItem10.Text = "Off";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(193, 22);
            this.toolStripMenuItem11.Text = "Exit";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(329, 497);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.ReplaceFileButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileGrabTextbox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
    }
}