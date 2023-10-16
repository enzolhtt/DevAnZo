namespace Fulbank
{
    partial class ChooseAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_courant = new Button();
            bt_epargne = new Button();
            bt_livret = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            Bt_Deco = new Button();
            button6 = new Button();
            ClientConnecter = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_courant
            // 
            bt_courant.Location = new Point(482, 286);
            bt_courant.Name = "bt_courant";
            bt_courant.Size = new Size(444, 74);
            bt_courant.TabIndex = 0;
            bt_courant.Text = "Courant";
            bt_courant.UseVisualStyleBackColor = true;
            bt_courant.Click += bt_courant_Click;
            // 
            // bt_epargne
            // 
            bt_epargne.Location = new Point(85, 417);
            bt_epargne.Name = "bt_epargne";
            bt_epargne.Size = new Size(403, 74);
            bt_epargne.TabIndex = 1;
            bt_epargne.Text = "Epargne";
            bt_epargne.UseVisualStyleBackColor = true;
            // 
            // bt_livret
            // 
            bt_livret.Location = new Point(482, 558);
            bt_livret.Name = "bt_livret";
            bt_livret.Size = new Size(444, 74);
            bt_livret.TabIndex = 2;
            bt_livret.Text = "Livret";
            bt_livret.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(85, 691);
            button4.Name = "button4";
            button4.Size = new Size(403, 74);
            button4.TabIndex = 3;
            button4.Text = "Crypto";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fulbank;
            pictureBox1.Location = new Point(620, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Bt_Deco
            // 
            Bt_Deco.Location = new Point(32, 81);
            Bt_Deco.Name = "Bt_Deco";
            Bt_Deco.Size = new Size(243, 60);
            Bt_Deco.TabIndex = 5;
            Bt_Deco.Text = "Deconnexion";
            Bt_Deco.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(482, 819);
            button6.Name = "button6";
            button6.Size = new Size(444, 74);
            button6.TabIndex = 6;
            button6.Text = "Bénéficiaire";
            button6.UseVisualStyleBackColor = true;
            // 
            // ClientConnecter
            // 
            ClientConnecter.AutoSize = true;
            ClientConnecter.Location = new Point(370, 104);
            ClientConnecter.Name = "ClientConnecter";
            ClientConnecter.Size = new Size(38, 15);
            ClientConnecter.TabIndex = 7;
            ClientConnecter.Text = "label1";
            // 
            // ChooseAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(ClientConnecter);
            Controls.Add(button6);
            Controls.Add(Bt_Deco);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(bt_livret);
            Controls.Add(bt_epargne);
            Controls.Add(bt_courant);
            Name = "ChooseAccount";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_courant;
        private Button bt_epargne;
        private Button bt_livret;
        private Button button4;
        private PictureBox pictureBox1;
        private Button Bt_Deco;
        private Button button6;
        private Label ClientConnecter;
    }
}