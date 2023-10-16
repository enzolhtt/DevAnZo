namespace Fulbank.View
{
    partial class CompteCourant
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            bt_crypto = new Button();
            bt_livret = new Button();
            bt_epargne = new Button();
            bt_courant = new Button();
            bt_virement = new Button();
            lb_solde = new Label();
            lb_compte = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fulbank;
            pictureBox1.Location = new Point(620, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.flecheRetour;
            pictureBox2.Location = new Point(35, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // bt_crypto
            // 
            bt_crypto.Location = new Point(72, 766);
            bt_crypto.Name = "bt_crypto";
            bt_crypto.Size = new Size(403, 74);
            bt_crypto.TabIndex = 11;
            bt_crypto.Text = "Crypto";
            bt_crypto.UseVisualStyleBackColor = true;
            // 
            // bt_livret
            // 
            bt_livret.Location = new Point(469, 655);
            bt_livret.Name = "bt_livret";
            bt_livret.Size = new Size(444, 74);
            bt_livret.TabIndex = 10;
            bt_livret.Text = "Livret";
            bt_livret.UseVisualStyleBackColor = true;
            // 
            // bt_epargne
            // 
            bt_epargne.Location = new Point(72, 536);
            bt_epargne.Name = "bt_epargne";
            bt_epargne.Size = new Size(403, 74);
            bt_epargne.TabIndex = 9;
            bt_epargne.Text = "Epargne";
            bt_epargne.UseVisualStyleBackColor = true;
            // 
            // bt_courant
            // 
            bt_courant.Location = new Point(469, 408);
            bt_courant.Name = "bt_courant";
            bt_courant.Size = new Size(444, 74);
            bt_courant.TabIndex = 8;
            bt_courant.Text = "Courant";
            bt_courant.UseVisualStyleBackColor = true;
            bt_courant.Click += bt_courant_Click;
            // 
            // bt_virement
            // 
            bt_virement.Location = new Point(349, 855);
            bt_virement.Name = "bt_virement";
            bt_virement.Size = new Size(284, 44);
            bt_virement.TabIndex = 13;
            bt_virement.Text = "Effectuer un virement";
            bt_virement.UseVisualStyleBackColor = true;
            bt_virement.Visible = false;
            // 
            // lb_solde
            // 
            lb_solde.AutoSize = true;
            lb_solde.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_solde.Location = new Point(204, 312);
            lb_solde.Name = "lb_solde";
            lb_solde.Size = new Size(120, 46);
            lb_solde.TabIndex = 14;
            lb_solde.Text = "Solde :";
            lb_solde.Visible = false;
            // 
            // lb_compte
            // 
            lb_compte.AutoSize = true;
            lb_compte.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_compte.Location = new Point(409, 230);
            lb_compte.Name = "lb_compte";
            lb_compte.Size = new Size(127, 37);
            lb_compte.TabIndex = 15;
            lb_compte.Text = "personne";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(349, 452);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(284, 349);
            listBox1.TabIndex = 16;
            listBox1.Visible = false;
            // 
            // CompteCourant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(listBox1);
            Controls.Add(lb_compte);
            Controls.Add(lb_solde);
            Controls.Add(bt_virement);
            Controls.Add(bt_crypto);
            Controls.Add(bt_livret);
            Controls.Add(bt_epargne);
            Controls.Add(bt_courant);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CompteCourant";
            Text = "CompteCourant";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button bt_crypto;
        private Button bt_livret;
        private Button bt_epargne;
        private Button bt_courant;
        private Button bt_virement;
        private Label lb_solde;
        private Label lb_compte;
        private ListBox listBox1;
    }
}