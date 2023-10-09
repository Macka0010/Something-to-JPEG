using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using GroupDocs.Parser;
using GroupDocs.Parser.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace PDF_2_JPEG
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker bgWorker;
        private readonly List<Image> previewImages;
        private int previewIndex;

        public Form1()
        {
            InitializeComponent();
            UpdatePicBoxBasedOnSettings();
            UpdateFormAppearanceBasedOnSettings();
            DropDownBox.SelectedIndex = 0;


            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, NextPreviewButton.Width, NextPreviewButton.Height);
            NextPreviewButton.Region = new Region(p);

            // Make PreviousPreviewButton circular
            GraphicsPath p2 = new GraphicsPath();
            p2.AddEllipse(0, 0, PreviousPreviewButton.Width, PreviousPreviewButton.Height);
            PreviousPreviewButton.Region = new Region(p2);

            GraphicsPath p3 = new GraphicsPath();
            p3.AddEllipse(0, 0, InfoButton.Width, InfoButton.Height);
            InfoButton.Region = new Region(p3);

            bgWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            PicBox.SizeMode = PictureBoxSizeMode.Zoom;
            previewImages = new List<Image>();
            previewIndex = 0;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Value = 0;
            ExtractImagesButton.Text = "Extract Images!";
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;

            bool isPreviewModeOn = bool.Parse(Properties.Settings.Default.PreviewMode);
            if (isPreviewModeOn && e.UserState is Image img)
            {
                previewImages.Add(img);
                UpdatePreviewImage();
            }
        }

        private void UpdatePreviewImage()
        {
            if (previewImages.Count > 0)
            {
                PicBox.Image = previewImages[previewIndex];
            }
        }



        private void UpdatePicBoxBasedOnSettings()
        {
            bool isPreviewModeOn = bool.Parse(Properties.Settings.Default.PreviewMode);
            PicBox.Enabled = isPreviewModeOn;
            OnToolStripMenuItem.Checked = isPreviewModeOn;
            OffToolStripMenuItem.Checked = !isPreviewModeOn;

            if (isPreviewModeOn)
            {
                this.Height = 614;
                InfoButton.Location = new System.Drawing.Point(286, 542);
            }
            else
            {
                this.Height = 281;
                InfoButton.Location = new System.Drawing.Point(286, 187);
                PicBox.Image = null;
            }
        }

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
                g.DrawImage(img, new System.Drawing.Point(0, offset));
                offset += img.Height;
            }
            return stitchedImg;
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = e.Argument as object[];
            string[] pdfPaths = args[0] as string[];  // Assuming that the first argument is an array of PDF paths
            string dropDownValue = args[1].ToString();

            int totalFiles = pdfPaths.Length;
            int currentFile = 0;

            foreach (var pdfPath in pdfPaths)
            {
                if (bgWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                currentFile++;
                ExtractAndSaveImages(pdfPath, bgWorker, dropDownValue, currentFile, totalFiles);
            }
        }



        private void ExtractImagesButton_Click(object sender, EventArgs e)
        {
            if (bgWorker.IsBusy)
            {
                bgWorker.CancelAsync();
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
                Filter = "PDF Files|*.pdf",
                Title = "Select a PDF file",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExtractImagesButton.Text = "Cancel!";
                string[] selectedFiles = openFileDialog.FileNames;
                string dropDownValue = DropDownBox.SelectedItem?.ToString();
                object[] args = { selectedFiles, dropDownValue };
                bgWorker.RunWorkerAsync(args);
            }
        }
        private void UpdateFormAppearanceBasedOnSettings()
        {
            bool isDarkModeOn = bool.Parse(Properties.Settings.Default.ColourMode);
            LightModeToolStripMenuItem.Checked = !isDarkModeOn;
            DarkModeToolStripMenuItem.Checked = isDarkModeOn;

            // Update form background color
            this.BackColor = isDarkModeOn ? Color.FromArgb(44, 47, 51) : Color.White;

            // Update button and label backgrounds and text colors
            Color buttonAndLabelBackgroundColor = isDarkModeOn ? Color.FromArgb(44, 47, 51) : Color.White;
            Color textForegroundColor = isDarkModeOn ? Color.White : Color.Black;

            ExtractImagesButton.BackColor = buttonAndLabelBackgroundColor;
            ExtractImagesButton.ForeColor = textForegroundColor;

            NextPreviewButton.BackColor = buttonAndLabelBackgroundColor;
            NextPreviewButton.ForeColor = textForegroundColor;

            PreviousPreviewButton.BackColor = buttonAndLabelBackgroundColor;
            PreviousPreviewButton.ForeColor = textForegroundColor;

            InfoButton.BackColor = buttonAndLabelBackgroundColor;
            InfoButton.ForeColor = textForegroundColor;

            label1.BackColor = buttonAndLabelBackgroundColor;
            label1.ForeColor = textForegroundColor;
        }


        private void ExtractAndSaveImages(string pdfPath, BackgroundWorker worker, string dropDownValue, int currentFile, int totalFiles)
        {
            try
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

                        // Calculate progress by considering multiple PDFs and multiple images
                        double progressForFile = ((double)imageIndex / totalCount) * 100;
                        double overallProgress = (((double)currentFile - 1) / totalFiles * 100) + (progressForFile / totalFiles);

                        int progress = (int)Math.Round(overallProgress);

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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void LightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourMode = "False";
            Properties.Settings.Default.Save();
            UpdateFormAppearanceBasedOnSettings();
            LightModeToolStripMenuItem.Checked = true;
            DarkModeToolStripMenuItem.Checked = false;
        }

        private void DarkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ColourMode = "True";
            Properties.Settings.Default.Save();
            UpdateFormAppearanceBasedOnSettings();
            LightModeToolStripMenuItem.Checked = false;
            DarkModeToolStripMenuItem.Checked = true;
        }

        private void OnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PreviewMode = "True";
            Properties.Settings.Default.Save();
            OnToolStripMenuItem.Checked = true;
            OffToolStripMenuItem.Checked = false;
            UpdatePicBoxBasedOnSettings();
        }

        private void OffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PreviewMode = "False";
            Properties.Settings.Default.Save();
            OnToolStripMenuItem.Checked = false;
            OffToolStripMenuItem.Checked = true;
            UpdatePicBoxBasedOnSettings();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextPreviewButton_Click(object sender, EventArgs e)
        {
            if (previewIndex < previewImages.Count - 1)
            {
                previewIndex++;
                UpdatePreviewImage();
            }
        }

        private void PreviousPreviewButton_Click(object sender, EventArgs e)
        {
            if (previewIndex > 0)
            {
                previewIndex--;
                UpdatePreviewImage();
            }
        }

        private void DropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
