﻿namespace Fulbank
{
    partial class Accueil
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
            bt_compte = new Button();
            pictureBox1 = new PictureBox();
            Bt_Deco = new Button();
            button6 = new Button();
            lbl_ClientAccount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_compte
            // 
            bt_compte.Location = new Point(282, 336);
            bt_compte.Name = "bt_compte";
            bt_compte.Size = new Size(444, 74);
            bt_compte.TabIndex = 0;
            bt_compte.Text = "Compte";
            bt_compte.UseVisualStyleBackColor = true;
            bt_compte.Click += bt_courant_Click;
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
            Bt_Deco.Location = new Point(282, 734);
            Bt_Deco.Name = "Bt_Deco";
            Bt_Deco.Size = new Size(444, 60);
            Bt_Deco.TabIndex = 5;
            Bt_Deco.Text = "Deconnexion";
            Bt_Deco.UseVisualStyleBackColor = true;
            Bt_Deco.Click += Bt_Deco_Click;
            // 
            // button6
            // 
            button6.Location = new Point(282, 539);
            button6.Name = "button6";
            button6.Size = new Size(444, 74);
            button6.TabIndex = 6;
            button6.Text = "Bénéficiaire";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // lbl_ClientAccount
            // 
            lbl_ClientAccount.AutoSize = true;
            lbl_ClientAccount.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ClientAccount.Location = new Point(126, 99);
            lbl_ClientAccount.Name = "lbl_ClientAccount";
            lbl_ClientAccount.Size = new Size(71, 30);
            lbl_ClientAccount.TabIndex = 7;
            lbl_ClientAccount.Text = "label1";
            // 
            // ChooseAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(lbl_ClientAccount);
            Controls.Add(button6);
            Controls.Add(Bt_Deco);
            Controls.Add(pictureBox1);
            Controls.Add(bt_compte);
            Name = "ChooseAccount";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_compte;
        private Button bt_epargne;
        private Button bt_livret;
        private Button button4;
        private PictureBox pictureBox1;
        private Button Bt_Deco;
        private Button button6;
        private Label lbl_ClientAccount;
    }
}