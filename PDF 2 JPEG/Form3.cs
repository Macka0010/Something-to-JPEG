using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_2_JPEG
{
    public partial class EmailGrabber : Form
    {
        public EmailGrabber()
        {
            InitializeComponent();
            this.Load += new EventHandler(EmailGrabber_Load);
        }

        private void EmailGrabber_Load(object sender, EventArgs e)
        {
            SetRoundedEdges(GetButton, 10);
            SetRoundedEdges(ReplaceFileButton, 10);
            SetRoundedEdges(StatusBox, 10);
            StatusBox.ReadOnly = true;
            StatusBox.TabStop = false;
        }

        private void SetRoundedEdges(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(path);
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            string sourcePath = FileGrabTextbox.Text.Replace("\"", string.Empty);

            if (!File.Exists(sourcePath))
            {
                StatusBox.Text = "Error!";
                StatusBox.BackColor = Color.Red;
                StatusBox.ForeColor = Color.White;
                return;
            }

            string destinationFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads",
                "MSG Files"
            );

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            string fileName = Path.GetFileName(sourcePath);
            string destinationPath = Path.Combine(destinationFolder, fileName);

            try
            {
                File.Copy(sourcePath, destinationPath, overwrite: true);
                StatusBox.Text = "Copied";
                StatusBox.BackColor = Color.Green;
                StatusBox.ForeColor = Color.Black;
            }
            catch (IOException)
            {
                StatusBox.Text = "Error!";
                StatusBox.BackColor = Color.Red;
                StatusBox.ForeColor = Color.White;
            }
        }

        private void ReplaceFileButton_Click(object sender, EventArgs e)
        {
            string filePath = FileGrabTextbox.Text.Replace("\"", string.Empty);

            if (!File.Exists(filePath))
            {
                StatusBox.Text = "Error!";
                StatusBox.BackColor = Color.Red;
                StatusBox.ForeColor = Color.White;
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Truncate the file to 0 bytes
                }
                StatusBox.Text = "Replaced";
                StatusBox.BackColor = Color.Green;
                StatusBox.ForeColor = Color.Black;
            }
            catch (IOException)
            {
                StatusBox.Text = "Failed!";
                StatusBox.BackColor = Color.Red;
                StatusBox.ForeColor = Color.White;
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            string infoMessage =
                "This application allows you to manually manage email file contents for a job, " +
                "especially useful when an email contains breaking scans or photos. " +
                "By specifying the file path, you can either copy the file to a designated " +
                "folder or replace the file with an empty one with the same name and extension.\n\n" +
                "Usage:\n" +
                "1. Paste the full path of the email file into the provided text box.\n" +
                "2. Click 'Get' to copy the file to the 'MSG Files' folder within your Downloads folder.\n" +
                "3. Click 'Replace' to replace the specified file with an empty file of the same name and extension.\n\n" +
                "Developed to manually add the contents of an email file to a job if the email is breaking the email to scans/photos.";

            MessageBox.Show(infoMessage, "Program Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
