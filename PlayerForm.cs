using System;
using System.IO;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class PlayerForm : Form
    {
        public Player Player { get; private set; }

        public PlayerForm()
        {
            InitializeComponent();
            Player = new Player();
        }

        public PlayerForm(Player player) : this()
        {
            Player = player;
            textBoxName.Text = player.Name;
            textBoxTeam.Text = player.Team;
            textBoxPPG.Text = player.PPG.ToString();
            textBoxRPG.Text = player.RPG.ToString();
            textBoxAPG.Text = player.APG.ToString();
            textBoxSPG.Text = player.SPG.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxTeam.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPPG.Text) ||
                    string.IsNullOrWhiteSpace(textBoxRPG.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAPG.Text) ||
                    string.IsNullOrWhiteSpace(textBoxSPG.Text))
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Player.Name = textBoxName.Text;
                Player.Team = textBoxTeam.Text;
                Player.PPG = double.Parse(textBoxPPG.Text);
                Player.RPG = double.Parse(textBoxRPG.Text);
                Player.APG = double.Parse(textBoxAPG.Text);
                Player.SPG = double.Parse(textBoxSPG.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"An error occured: {ex.Message} \nPlease enter valid numeric values for PPG, RPG, APG, and SPG.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the player: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sourceFilePath = openFileDialog.FileName;
                        string fileName = Path.GetFileName(sourceFilePath);
                        string destinationFilePath = Path.Combine("../../../Images", fileName);

                        // Ensure the Images directory exists
                        Directory.CreateDirectory("../../../Images");

                        // Copy the file to the Images directory
                        File.Copy(sourceFilePath, destinationFilePath, true);

                        // Set the Photo property to the relative path
                        Player.Photo = destinationFilePath;

                        textBoxPhoto.Text = destinationFilePath;
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred while uploading the photo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
