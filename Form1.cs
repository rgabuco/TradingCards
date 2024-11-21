using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Drawing;

namespace TradingCards
{
    public partial class Form1 : Form
    {
        private List<Player> players;
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            InitializeDataBinding();
            UpdateStatColors();
        }

        private void PictureBoxPhoto_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 0.5f))
            {
                Rectangle rect = pictureBoxPhoto.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void GroupBoxPlayerCard_Paint(object sender, PaintEventArgs e)
        {
            if (bindingSource.Current is Player currentPlayer)
            {
                string team = currentPlayer.Team;
                Color borderColor = GetTeamColor(team);

                using (Pen pen = new Pen(borderColor, 3f)) // Create a pen with 3 px width
                {
                    Rectangle rect = groupBoxPlayerCard.ClientRectangle;
                    rect.Width -= 1;
                    rect.Height -= 1;

                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }

        private Color GetTeamColor(string team)
        {
            return team switch
            {
                "Golden State Warriors" => Color.Blue,
                "Miami Heat" => Color.Red,
                "Minnesota Timberwolves" => Color.Green,
                "Milwaukee Bucks" => Color.BlueViolet,
                _ => Color.Black,
            };
        }

        private void LoadData()
        {
            players = new List<Player>
            {
                new Player { Name = "Stephen Curry", Team = "Golden State Warriors", Photo = "../../../Images/StephCurry.jpg", PPG = 23, RPG = 5.3, APG = 6.4, SPG = 1.8 },
                new Player { Name = "Draymond Green", Team = "Golden State Warriors", Photo = "../../../Images/DraymondGreen.jpg", PPG = 8.9, RPG = 6.2, APG = 8.0, SPG = 1.4 },
                new Player { Name = "Gary Payton II", Team = "Golden State Warriors", Photo = "../../../Images/GaryPaytonII.jpg", PPG = 4.4, RPG = 1.9, APG = 1.2, SPG = 1.1 },
                new Player { Name = "Anthony Edwards", Team = "Minnesota Timberwolves", Photo = "../../../Images/AnthonyEdwards.jpg", PPG = 28.1, RPG = 5.1, APG = 3.8, SPG = 1.1 },
                new Player { Name = "Donte DiVincenzo", Team = "Minnesota Timberwolves", Photo = "../../../Images/DonteDiVincenzo.jpg", PPG = 9.4, RPG = 3.2, APG = 3.3, SPG = 1.3 },
                new Player { Name = "Giannis Antetokounmpo", Team = "Milwaukee Bucks", Photo = "../../../Images/GiannisAntetokounmpo.jpg", PPG = 31.4, RPG = 12.4, APG = 5.9, SPG = 0.5 },
                new Player { Name = "Damian Lillard", Team = "Milwaukee Bucks", Photo = "../../../Images/DamianLillard.jpg", PPG = 25.3, RPG = 4.5, APG = 6.9, SPG = 0.9 },
                new Player { Name = "Liam Robbins", Team = "Milwaukee Bucks", Photo = "../../../Images/LiamRobbins.jpg", PPG = 1.7, RPG = 1, APG = 0, SPG = 0 },
                new Player { Name = "Jimmy Butler", Team = "Miami Heat", Photo = "../../../Images/JimmyButler.jpg", PPG = 17.7, RPG = 5.3, APG = 4.9, SPG = 1.4 },
                new Player { Name = "Duncan Robinson", Team = "Miami Heat", Photo = "../../../Images/DuncanRobinson.jpg", PPG = 10.2, RPG = 2.2, APG = 1.8, SPG = 0.6 },
                new Player{ Name = "Kel'el Ware", Team = "Miami Heat", Photo = "../../../Images/Kel'elWare.jpg", PPG = 2.3, RPG = 1.1, APG = 0, SPG = 0.3}
            };
        }

        private void InitializeDataBinding()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = players;

            listBoxPlayers.DataSource = bindingSource;
            listBoxPlayers.DisplayMember = "Name";

            textBoxName.DataBindings.Add("Text", bindingSource, "Name");
            textBoxTeam.DataBindings.Add("Text", bindingSource, "Team");
            pictureBoxPhoto.DataBindings.Add("ImageLocation", bindingSource, "Photo");
            textBoxPPG.DataBindings.Add("Text", bindingSource, "PPG");
            textBoxRPG.DataBindings.Add("Text", bindingSource, "RPG");
            textBoxAPG.DataBindings.Add("Text", bindingSource, "APG");
            textBoxSPG.DataBindings.Add("Text", bindingSource, "SPG");

            bindingSource.CurrentChanged += (sender, e) =>
            {
                groupBoxPlayerCard.Invalidate();
                UpdateStatColors();
            };
        }

        private void UpdateStatColors()
        {
            double avgPPG = players.Average(p => p.PPG);
            double avgRPG = players.Average(p => p.RPG);
            double avgAPG = players.Average(p => p.APG);
            double avgSPG = players.Average(p => p.SPG);

            if (bindingSource.Current is Player currentPlayer)
            {
                textBoxPPG.BackColor = currentPlayer.PPG >= avgPPG ? Color.LightGreen : Color.LightCoral;
                textBoxRPG.BackColor = currentPlayer.RPG >= avgRPG ? Color.LightGreen : Color.LightCoral;
                textBoxAPG.BackColor = currentPlayer.APG >= avgAPG ? Color.LightGreen : Color.LightCoral;
                textBoxSPG.BackColor = currentPlayer.SPG >= avgSPG ? Color.LightGreen : Color.LightCoral;
            }
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            using (var form = new PlayerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    players.Add(form.Player);
                    bindingSource.ResetBindings(false);
                    UpdateStatColors();
                }
            }
        }

        private void BtnDeletePlayer_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Player currentPlayer)
            {
                players.Remove(currentPlayer);
                bindingSource.ResetBindings(false);
                UpdateStatColors();

                //Delete the image file
                if (File.Exists(currentPlayer.Photo))
                {
                    File.Delete(currentPlayer.Photo);
                }
            }
        }

        private void BtnEditPlayer_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Player currentPlayer)
            {
                using (var form = new PlayerForm(currentPlayer))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        bindingSource.ResetBindings(false);
                        UpdateStatColors();
                    }
                }
            }
        }
    }
}
