using System;
using System.Collections.Generic;
using System.ComponentModel;  // For BackgroundWorker
using System.Windows.Forms;
using System.IO;
using GroupDocs.Parser;
using GroupDocs.Parser.Data;
using System.Drawing;
using System.Drawing.Imaging;
using Point = System.Drawing.Point;

namespace PDF_2_JPEG
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker bgWorker;  // BackgroundWorker declaration

        public Form1()
        {
            InitializeComponent();
            UpdatePicBoxBasedOnSettings();
            UpdateFormAppearanceBasedOnSettings();
            DropDownBox.SelectedIndex = 0;  // Default value for DropDownBox

            // Initialize BackgroundWorker
            bgWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            PicBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Handle the progress of the BackgroundWorker
        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;

            // Check if PreviewMode is enabled before showing previews
            bool isPreviewModeOn = bool.Parse(Properties.Settings.Default.PreviewMode);
            if (isPreviewModeOn && e.UserState is Image img)
            {
                PicBox.SizeMode = PictureBoxSizeMode.Zoom;
                PicBox.Image = img;
            }
        }

        private void UpdatePicBoxBasedOnSettings()
        {
            // Check if the setting is stored as a string and convert it to a boolean
            bool isPreviewModeOn = bool.Parse(Properties.Settings.Default.PreviewMode);

            // Enable or disable the PicBox based on the setting
            PicBox.Enabled = isPreviewModeOn;

            // Update the checked state of the menu items based on the setting
            OnToolStripMenuItem.Checked = isPreviewModeOn;
            OffToolStripMenuItem.Checked = !isPreviewModeOn;

            // Update form size and InfoButton location based on the setting
            if (isPreviewModeOn)
            {
                // Set form height to 614 and InfoButton location to (286, 542)
                this.Height = 614;
                InfoButton.Location = new Point(286, 542);
            }
            else
            {
                // Set form height to 281 and InfoButton location to (286, 225)
                this.Height = 281;
                InfoButton.Location = new Point(286, 187);

                // Clear the PicBox since preview mode is off
                PicBox.Image = null;
            }
        }




        // Stitch images vertically
        private Image StitchImagesVertically(List<Image> images)
        {
            int width = images[0].Width;
            int totalHeight = 0;

            foreach (Image img in images)
            {
                totalHeight += img.Height;
            }

            Bitmap stitchedImg = new Bitmap(width, totalHeight);
            Graphics g = Graphics.FromImage(stitchedImg);
            int offset = 0;

            foreach (Image img in images)
            {
                g.DrawImage(img, new Point(0, offset));
                offset += img.Height;
            }

            return stitchedImg;
        }

        // BackgroundWorker DoWork event handler
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = e.Argument as object[];
            string pdfPath = args[0].ToString();
            string dropDownValue = args[1].ToString();
            ExtractAndSaveImages(pdfPath, bgWorker, dropDownValue);
        }

        // Open File Dialog and start BackgroundWorker
        private void ExtractImagesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
                Filter = "PDF Files|*.pdf",
                Title = "Select a PDF file"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                string dropDownValue = DropDownBox.SelectedItem?.ToString();
                object[] args = { selectedFile, dropDownValue };
                bgWorker.RunWorkerAsync(args);
            }
        }

        // Method to update form appearance based on the ColourMode setting
        private void UpdateFormAppearanceBasedOnSettings()
        {
            // Convert the setting from string to boolean
            bool isDarkModeOn = bool.Parse(Properties.Settings.Default.ColourMode);

            // Update the checked state of the menu items based on the setting
            LightModeToolStripMenuItem.Checked = !isDarkModeOn;
            DarkModeToolStripMenuItem.Checked = isDarkModeOn;

            // Update the form's background color
            this.BackColor = isDarkModeOn ? Color.FromArgb(44, 47, 51) : Color.White;
        }

        // Extract and save images from PDF
        private void ExtractAndSaveImages(string pdfPath, BackgroundWorker worker, string dropDownValue)
        {
            using (Parser parser = new Parser(pdfPath))
            {
                int imageIndex = 0;
                string directory = Path.GetDirectoryName(pdfPath);
                string folderPath = Path.Combine(directory, "PDF Images");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                IEnumerable<PageImageArea> images = parser.GetImages();
                if (images == null)
                {
                    MessageBox.Show("Image extraction is not supported for this PDF.");
                    return;
                }

                bool imagesFound = false;

                // Calculate the total number of images
                int totalCount = 0;
                foreach (var _ in images)
                {
                    totalCount++;
                }

                images = parser.GetImages();

                List<Image> groupImages = new List<Image>();
                int stitchedIndex = 0;

                foreach (PageImageArea image in images)
                {
                    if (worker.CancellationPending)
                    {
                        return;
                    }

                    imagesFound = true;
                    imageIndex++;

                    int progress = totalCount > 0 ? (int)((double)imageIndex / totalCount * 100) : 0;

                    Image img = Image.FromStream(image.GetImageStream());
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, ImageFormat.Bmp);
                    Image imgCopy = Image.FromStream(new MemoryStream(ms.ToArray()));

                    worker.ReportProgress(progress, imgCopy);

                    string imagePath = Path.Combine(folderPath, $"Image_{imageIndex}.jpeg");
                    img.Save(imagePath, ImageFormat.Jpeg);

                    img.Dispose();
                    ms.Dispose();

                    if (dropDownValue == "Sliced PDF")
                    {
                        groupImages.Add(imgCopy);
                        if (groupImages.Count == 10)
                        {
                            Image stitchedImg = StitchImagesVertically(groupImages);
                            string stitchedPath = Path.Combine(folderPath, $"stitched_{++stitchedIndex}.jpeg");
                            stitchedImg.Save(stitchedPath, ImageFormat.Jpeg);

                            groupImages.Clear();
                        }
                    }
                }

                if (groupImages.Count > 0)
                {
                    Image stitchedImg = StitchImagesVertically(groupImages);
                    string stitchedPath = Path.Combine(folderPath, $"stitched_{++stitchedIndex}.jpeg");
                    stitchedImg.Save(stitchedPath, ImageFormat.Jpeg);
                }

                if (!imagesFound)
                {
                    MessageBox.Show("No images were found in the PDF.");
                }
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void LightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set ColourMode to False for Light Mode
            Properties.Settings.Default.ColourMode = "False";
            Properties.Settings.Default.Save(); // Save the settings
            UpdateFormAppearanceBasedOnSettings();

            // Update menu strip items
            LightModeToolStripMenuItem.Checked = true;
            DarkModeToolStripMenuItem.Checked = false;
        }

        private void DarkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set ColourMode to True for Dark Mode
            Properties.Settings.Default.ColourMode = "True";
            Properties.Settings.Default.Save(); // Save the settings
            UpdateFormAppearanceBasedOnSettings();


            // Update menu strip items
            LightModeToolStripMenuItem.Checked = false;
            DarkModeToolStripMenuItem.Checked = true;
        }

        private void OnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set PreviewMode to True for On
            Properties.Settings.Default.PreviewMode = "True";
            Properties.Settings.Default.Save(); // Save the settings

            // Update menu strip items
            OnToolStripMenuItem.Checked = true;
            OffToolStripMenuItem.Checked = false;
            UpdatePicBoxBasedOnSettings();

        }

        private void OffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set PreviewMode to False for Off
            Properties.Settings.Default.PreviewMode = "False";
            Properties.Settings.Default.Save(); // Save the settings

            // Update menu strip items
            OnToolStripMenuItem.Checked = false;
            OffToolStripMenuItem.Checked = true;
            UpdatePicBoxBasedOnSettings();

        }

    }
}
