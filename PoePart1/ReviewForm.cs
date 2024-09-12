using System;
using System.Drawing; 
using System.Windows.Forms;

namespace PoePart1
{
    public partial class ReviewForm : Form
    {
        public ReviewForm(string location, string category, string description, string imagePath)
        {
            InitializeComponent();

            txtReviewLocation.Text = location;
            txtReviewCategory.Text = category;
            rtbReviewDescription.Text = description;

            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
        }
    }
}
