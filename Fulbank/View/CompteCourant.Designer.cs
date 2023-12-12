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
            img_retour = new PictureBox();
            bt_crypto = new Button();
            bt_livret = new Button();
            bt_epargne = new Button();
            bt_courant = new Button();
            bt_virement = new Button();
            lb_solde = new Label();
            lb_compte = new Label();
            gbx_compte = new GroupBox();
            lbl_client = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).BeginInit();
            gbx_compte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // img_retour
            // 
            img_retour.Image = Properties.Resources.flecheRetour;
            img_retour.Location = new Point(35, 37);
            img_retour.Name = "img_retour";
            img_retour.Size = new Size(140, 140);
            img_retour.SizeMode = PictureBoxSizeMode.StretchImage;
            img_retour.TabIndex = 6;
            img_retour.TabStop = false;
            img_retour.Click += img_retour_Click;
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
            bt_virement.Location = new Point(245, 632);
            bt_virement.Name = "bt_virement";
            bt_virement.Size = new Size(284, 44);
            bt_virement.TabIndex = 13;
            bt_virement.Text = "Effectuer un virement";
            bt_virement.UseVisualStyleBackColor = true;
            // 
            // lb_solde
            // 
            lb_solde.AutoSize = true;
            lb_solde.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_solde.Location = new Point(69, 168);
            lb_solde.Name = "lb_solde";
            lb_solde.Size = new Size(120, 46);
            lb_solde.TabIndex = 14;
            lb_solde.Text = "Solde :";
            // 
            // lb_compte
            // 
            lb_compte.AutoSize = true;
            lb_compte.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_compte.Location = new Point(323, 82);
            lb_compte.Name = "lb_compte";
            lb_compte.Size = new Size(127, 37);
            lb_compte.TabIndex = 15;
            lb_compte.Text = "personne";
            lb_compte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbx_compte
            // 
            gbx_compte.Controls.Add(lbl_client);
            gbx_compte.Controls.Add(dataGridView1);
            gbx_compte.Controls.Add(lb_compte);
            gbx_compte.Controls.Add(bt_virement);
            gbx_compte.Controls.Add(lb_solde);
            gbx_compte.Location = new Point(129, 226);
            gbx_compte.Name = "gbx_compte";
            gbx_compte.Size = new Size(741, 708);
            gbx_compte.TabIndex = 17;
            gbx_compte.TabStop = false;
            gbx_compte.Text = "groupBox1";
            gbx_compte.Visible = false;
            // 
            // lbl_client
            // 
            lbl_client.AutoSize = true;
            lbl_client.Location = new Point(367, 65);
            lbl_client.Name = "lbl_client";
            lbl_client.Size = new Size(38, 15);
            lbl_client.TabIndex = 17;
            lbl_client.Text = "label1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(196, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(390, 312);
            dataGridView1.TabIndex = 16;
            // 
            // CompteCourant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(gbx_compte);
            Controls.Add(bt_crypto);
            Controls.Add(bt_livret);
            Controls.Add(bt_epargne);
            Controls.Add(bt_courant);
            Controls.Add(img_retour);
            Controls.Add(pictureBox1);
            Name = "CompteCourant";
            Text = "CompteCourant";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).EndInit();
            gbx_compte.ResumeLayout(false);
            gbx_compte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox img_retour;
        private Button bt_crypto;
        private Button bt_livret;
        private Button bt_epargne;
        private Button bt_courant;
        private Button bt_virement;
        private Label lb_solde;
        private Label lb_compte;
        private ListBox listBox1;
        private GroupBox gbx_compte;
        private DataGridView dataGridView1;
        private Label lbl_client;
    }
}