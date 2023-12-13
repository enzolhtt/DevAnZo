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
            lbl_solde = new Label();
            lbl_client = new Label();
            dataGridView1 = new DataGridView();
            gbx_virement = new GroupBox();
            bt_envoyer = new Button();
            lbl_virement = new Label();
            txt_montant = new TextBox();
            cbx_personne = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).BeginInit();
            gbx_compte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbx_virement.SuspendLayout();
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
            bt_virement.Click += bt_virement_Click;
            // 
            // lb_solde
            // 
            lb_solde.AutoSize = true;
            lb_solde.Font = new Font("Segoe UI Black", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_solde.Location = new Point(69, 168);
            lb_solde.Name = "lb_solde";
            lb_solde.Size = new Size(129, 45);
            lb_solde.TabIndex = 14;
            lb_solde.Text = "Solde :";
            // 
            // lb_compte
            // 
            lb_compte.AutoSize = true;
            lb_compte.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_compte.ForeColor = SystemColors.ControlText;
            lb_compte.Location = new Point(299, 81);
            lb_compte.Name = "lb_compte";
            lb_compte.Size = new Size(127, 37);
            lb_compte.TabIndex = 15;
            lb_compte.Text = "personne";
            lb_compte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbx_compte
            // 
            gbx_compte.Controls.Add(lbl_solde);
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
            // lbl_solde
            // 
            lbl_solde.AutoSize = true;
            lbl_solde.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_solde.Location = new Point(302, 174);
            lbl_solde.Name = "lbl_solde";
            lbl_solde.Size = new Size(179, 37);
            lbl_solde.TabIndex = 18;
            lbl_solde.Text = "SoldeCompte";
            // 
            // lbl_client
            // 
            lbl_client.AutoSize = true;
            lbl_client.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            lbl_client.Location = new Point(339, 65);
            lbl_client.Name = "lbl_client";
            lbl_client.Size = new Size(43, 17);
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
            // gbx_virement
            // 
            gbx_virement.BackColor = Color.FromArgb(128, 194, 236);
            gbx_virement.Controls.Add(cbx_personne);
            gbx_virement.Controls.Add(bt_envoyer);
            gbx_virement.Controls.Add(lbl_virement);
            gbx_virement.Controls.Add(txt_montant);
            gbx_virement.Location = new Point(221, 226);
            gbx_virement.Name = "gbx_virement";
            gbx_virement.Size = new Size(549, 571);
            gbx_virement.TabIndex = 20;
            gbx_virement.TabStop = false;
            gbx_virement.Text = "groupBox2";
            // 
            // bt_envoyer
            // 
            bt_envoyer.Location = new Point(232, 404);
            bt_envoyer.Name = "bt_envoyer";
            bt_envoyer.Size = new Size(75, 23);
            bt_envoyer.TabIndex = 4;
            bt_envoyer.Text = "Envoyer";
            bt_envoyer.UseVisualStyleBackColor = true;
            // 
            // lbl_virement
            // 
            lbl_virement.AutoSize = true;
            lbl_virement.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_virement.Location = new Point(159, 152);
            lbl_virement.Name = "lbl_virement";
            lbl_virement.Size = new Size(237, 65);
            lbl_virement.TabIndex = 3;
            lbl_virement.Text = "Virement";
            // 
            // txt_montant
            // 
            txt_montant.Location = new Point(195, 349);
            txt_montant.Name = "txt_montant";
            txt_montant.Size = new Size(155, 23);
            txt_montant.TabIndex = 1;
            txt_montant.Text = "De combien ?";
            txt_montant.TextAlign = HorizontalAlignment.Center;
            // 
            // cbx_personne
            // 
            cbx_personne.FormattingEnabled = true;
            cbx_personne.Location = new Point(195, 288);
            cbx_personne.Name = "cbx_personne";
            cbx_personne.Size = new Size(155, 23);
            cbx_personne.TabIndex = 5;
            // 
            // CompteCourant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(gbx_virement);
            Controls.Add(gbx_compte);
            Controls.Add(bt_crypto);
            Controls.Add(bt_livret);
            Controls.Add(bt_epargne);
            Controls.Add(bt_courant);
            Controls.Add(img_retour);
            Controls.Add(pictureBox1);
            Name = "CompteCourant";
            Text = "CompteCourant";
            Load += CompteCourant_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).EndInit();
            gbx_compte.ResumeLayout(false);
            gbx_compte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbx_virement.ResumeLayout(false);
            gbx_virement.PerformLayout();
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
        private Label lbl_solde;
        private GroupBox gbx_virement;
        private Button bt_envoyer;
        private Label lbl_virement;
        private TextBox txt_montant;
        private ComboBox cbx_personne;
    }
}