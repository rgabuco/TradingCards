namespace TradingCards
{
    partial class PlayerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxTeam = new TextBox();
            textBoxPhoto = new TextBox();
            textBoxPPG = new TextBox();
            textBoxRPG = new TextBox();
            textBoxAPG = new TextBox();
            textBoxSPG = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnUploadPhoto = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(136, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(171, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxTeam
            // 
            textBoxTeam.Location = new Point(136, 38);
            textBoxTeam.Name = "textBoxTeam";
            textBoxTeam.Size = new Size(171, 23);
            textBoxTeam.TabIndex = 1;
            // 
            // textBoxPhoto
            // 
            textBoxPhoto.Location = new Point(136, 64);
            textBoxPhoto.Name = "textBoxPhoto";
            textBoxPhoto.Size = new Size(89, 23);
            textBoxPhoto.TabIndex = 2;
            // 
            // textBoxPPG
            // 
            textBoxPPG.Location = new Point(136, 90);
            textBoxPPG.Name = "textBoxPPG";
            textBoxPPG.Size = new Size(171, 23);
            textBoxPPG.TabIndex = 4;
            // 
            // textBoxRPG
            // 
            textBoxRPG.Location = new Point(136, 116);
            textBoxRPG.Name = "textBoxRPG";
            textBoxRPG.Size = new Size(171, 23);
            textBoxRPG.TabIndex = 5;
            // 
            // textBoxAPG
            // 
            textBoxAPG.Location = new Point(136, 142);
            textBoxAPG.Name = "textBoxAPG";
            textBoxAPG.Size = new Size(171, 23);
            textBoxAPG.TabIndex = 6;
            // 
            // textBoxSPG
            // 
            textBoxSPG.Location = new Point(136, 168);
            textBoxSPG.Name = "textBoxSPG";
            textBoxSPG.Size = new Size(171, 23);
            textBoxSPG.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(136, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(232, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Location = new Point(241, 63);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(66, 23);
            btnUploadPhoto.TabIndex = 3;
            btnUploadPhoto.Text = "Upload";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            btnUploadPhoto.Click += btnUploadPhoto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "Team:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Photo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 13;
            label4.Text = "Points Per Game:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 119);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 14;
            label5.Text = "Rebounds Per Game:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 145);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 15;
            label6.Text = "Assists Per Game:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 171);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 16;
            label7.Text = "Steals Per Game:";
            // 
            // PlayerForm
            // 
            ClientSize = new Size(334, 254);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnUploadPhoto);
            Controls.Add(textBoxSPG);
            Controls.Add(textBoxAPG);
            Controls.Add(textBoxRPG);
            Controls.Add(textBoxPPG);
            Controls.Add(textBoxPhoto);
            Controls.Add(textBoxTeam);
            Controls.Add(textBoxName);
            Name = "PlayerForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Details";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTeam;
        private System.Windows.Forms.TextBox textBoxPhoto;
        private System.Windows.Forms.TextBox textBoxPPG;
        private System.Windows.Forms.TextBox textBoxRPG;
        private System.Windows.Forms.TextBox textBoxAPG;
        private System.Windows.Forms.TextBox textBoxSPG;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUploadPhoto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
