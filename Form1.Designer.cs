namespace TradingCards
{
    partial class Form1
    {
        private ListBox listBoxPlayers;
        private TextBox textBoxName;
        private TextBox textBoxTeam;
        private PictureBox pictureBoxPhoto;
        private TextBox textBoxPPG;
        private TextBox textBoxRPG;
        private TextBox textBoxAPG;
        private TextBox textBoxSPG;
        private GroupBox groupBoxPlayerCard;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private GroupBox groupBox2;
        private Button btnAddPlayer;
        private Button btnEditPlayer;
        private Button btnDeletePlayer;

        private void InitializeComponent()
        {
            listBoxPlayers = new ListBox();
            textBoxName = new TextBox();
            textBoxTeam = new TextBox();
            pictureBoxPhoto = new PictureBox();
            textBoxPPG = new TextBox();
            textBoxRPG = new TextBox();
            textBoxAPG = new TextBox();
            textBoxSPG = new TextBox();
            groupBoxPlayerCard = new GroupBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnAddPlayer = new Button();
            btnEditPlayer = new Button();
            btnDeletePlayer = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            groupBoxPlayerCard.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(13, 25);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(153, 229);
            listBoxPlayers.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(131, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxTeam
            // 
            textBoxTeam.Location = new Point(131, 102);
            textBoxTeam.Name = "textBoxTeam";
            textBoxTeam.Size = new Size(151, 23);
            textBoxTeam.TabIndex = 2;
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(241, 54);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(100, 93);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 3;
            pictureBoxPhoto.TabStop = false;
            pictureBoxPhoto.Paint += PictureBoxPhoto_Paint;
            // 
            // textBoxPPG
            // 
            textBoxPPG.Location = new Point(173, 142);
            textBoxPPG.Name = "textBoxPPG";
            textBoxPPG.Size = new Size(76, 23);
            textBoxPPG.TabIndex = 4;
            // 
            // textBoxRPG
            // 
            textBoxRPG.Location = new Point(173, 170);
            textBoxRPG.Name = "textBoxRPG";
            textBoxRPG.Size = new Size(76, 23);
            textBoxRPG.TabIndex = 5;
            // 
            // textBoxAPG
            // 
            textBoxAPG.Location = new Point(173, 197);
            textBoxAPG.Name = "textBoxAPG";
            textBoxAPG.Size = new Size(76, 23);
            textBoxAPG.TabIndex = 6;
            // 
            // textBoxSPG
            // 
            textBoxSPG.Location = new Point(173, 223);
            textBoxSPG.Name = "textBoxSPG";
            textBoxSPG.Size = new Size(76, 23);
            textBoxSPG.TabIndex = 7;
            // 
            // groupBoxPlayerCard
            // 
            groupBoxPlayerCard.Controls.Add(label6);
            groupBoxPlayerCard.Controls.Add(label2);
            groupBoxPlayerCard.Controls.Add(label1);
            groupBoxPlayerCard.Controls.Add(textBoxName);
            groupBoxPlayerCard.Controls.Add(textBoxTeam);
            groupBoxPlayerCard.Controls.Add(label5);
            groupBoxPlayerCard.Controls.Add(label3);
            groupBoxPlayerCard.Controls.Add(label4);
            groupBoxPlayerCard.Controls.Add(textBoxPPG);
            groupBoxPlayerCard.Controls.Add(textBoxAPG);
            groupBoxPlayerCard.Controls.Add(textBoxSPG);
            groupBoxPlayerCard.Controls.Add(textBoxRPG);
            groupBoxPlayerCard.Location = new Point(220, 22);
            groupBoxPlayerCard.Name = "groupBoxPlayerCard";
            groupBoxPlayerCard.Size = new Size(299, 269);
            groupBoxPlayerCard.TabIndex = 8;
            groupBoxPlayerCard.TabStop = false;
            groupBoxPlayerCard.Paint += GroupBoxPlayerCard_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 226);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 11;
            label6.Text = "Steals Per Game:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 84);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "Team:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 32);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 200);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 11;
            label5.Text = "Assists Per Game:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 145);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "Points Per Game:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 173);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 11;
            label4.Text = "Rebounds Per Game:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxPlayers);
            groupBox2.Location = new Point(18, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(179, 268);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player List";
            // 
            // btnAddPlayer
            // 
            btnAddPlayer.Location = new Point(18, 305);
            btnAddPlayer.Name = "btnAddPlayer";
            btnAddPlayer.Size = new Size(75, 23);
            btnAddPlayer.TabIndex = 10;
            btnAddPlayer.Text = "Add Player";
            btnAddPlayer.UseVisualStyleBackColor = true;
            btnAddPlayer.Click += BtnAddPlayer_Click;
            // 
            // btnEditPlayer
            // 
            btnEditPlayer.Location = new Point(418, 305);
            btnEditPlayer.Name = "btnEditPlayer";
            btnEditPlayer.Size = new Size(101, 23);
            btnEditPlayer.TabIndex = 11;
            btnEditPlayer.Text = "Edit Player";
            btnEditPlayer.UseVisualStyleBackColor = true;
            btnEditPlayer.Click += BtnEditPlayer_Click;
            // 
            // btnDeletePlayer
            // 
            btnDeletePlayer.Location = new Point(113, 305);
            btnDeletePlayer.Name = "btnDeletePlayer";
            btnDeletePlayer.Size = new Size(84, 23);
            btnDeletePlayer.TabIndex = 12;
            btnDeletePlayer.Text = "Delete Player";
            btnDeletePlayer.UseVisualStyleBackColor = true;
            btnDeletePlayer.Click += BtnDeletePlayer_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(555, 365);
            Controls.Add(btnDeletePlayer);
            Controls.Add(btnEditPlayer);
            Controls.Add(btnAddPlayer);
            Controls.Add(pictureBoxPhoto);
            Controls.Add(groupBoxPlayerCard);
            Controls.Add(groupBox2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trading Cards";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            groupBoxPlayerCard.ResumeLayout(false);
            groupBoxPlayerCard.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
