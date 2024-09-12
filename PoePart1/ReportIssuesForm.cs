using System;
using System.Windows.Forms;

namespace PoePart1
{
    public partial class ReportIssuesForm : Form
    {
        private MainMenuForm _mainMenuForm;
        private string attachedFilePath = ""; 
        private const int PLocation = 34;
        private const int PCategory = 33;
        private const int PDescription = 33;

        public ReportIssuesForm(MainMenuForm mainMenuForm)
        {
            InitializeComponent();
            _mainMenuForm = mainMenuForm;
            progressBar1.Maximum = 100;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedFilePath = openFileDialog.FileName;
                    MessageBox.Show($"File attached: {attachedFilePath}");
                    UpdateProgressBar();
                }
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string description = rtbDescription.Text;

            if (string.IsNullOrWhiteSpace(location) || string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            ReviewForm reviewForm = new ReviewForm(location, category, description, attachedFilePath);
            reviewForm.Show();
        }

        private void UpdateProgressBar()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text) && txtLocation.Text != "Enter location of the issue")
            {
                progress += PLocation;
            }

            if (cmbCategory.SelectedIndex != -1)
            {
                progress += PCategory;
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text) && rtbDescription.Text != "Enter detailed description of the issue")
            {
                progress += PDescription;
            }

            progressBar1.Value = progress;
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
        }
    }
}
