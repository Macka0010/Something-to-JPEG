using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using GroupDocs.Parser;
using GroupDocs.Parser.Data;
using System.Drawing;
using System.Drawing.Imaging;

namespace PDF_2_JPEG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                if (DropDownBox.SelectedItem?.ToString() == "Normal")
                {
                    ExtractAndSaveImages(selectedFile);
                }
            }
        }

        private void ExtractAndSaveImages(string pdfPath)
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

                // Check if image extraction is supported
                if (images == null)
                {
                    MessageBox.Show("Image extraction is not supported for this PDF.");
                    return;
                }

                bool imagesFound = false;

                foreach (PageImageArea image in images)
                {
                    imagesFound = true;
                    imageIndex++;
                    string imagePath = Path.Combine(folderPath, $"Image_{imageIndex}.jpeg");
                    Image.FromStream(image.GetImageStream()).Save(imagePath, ImageFormat.Jpeg);
                }

                if (!imagesFound)
                {
                    MessageBox.Show("No images were found in the PDF.");
                }
            }
        }
    }
}
