namespace Fulbank.View
{
    partial class Compte
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
            logoFB_General = new PictureBox();
            img_retour = new PictureBox();
            bt_crypto = new Button();
            bt_livret = new Button();
            bt_epargne = new Button();
            bt_courant = new Button();
            bt_virement = new Button();
            lb_solde = new Label();
            lb_compte = new Label();
            gbx_compte = new GroupBox();
            listBox2 = new ListBox();
            lbl_solde = new Label();
            lbl_client = new Label();
            gbx_virement = new GroupBox();
            logoFB_Virement = new PictureBox();
            cbx_personne = new ComboBox();
            bt_envoyer = new Button();
            txt_montant = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logoFB_General).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).BeginInit();
            gbx_compte.SuspendLayout();
            gbx_virement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoFB_Virement).BeginInit();
            SuspendLayout();
            // 
            // logoFB_General
            // 
            logoFB_General.Image = Properties.Resources.Fulbank;
            logoFB_General.Location = new Point(620, 12);
            logoFB_General.Name = "logoFB_General";
            logoFB_General.Size = new Size(352, 208);
            logoFB_General.SizeMode = PictureBoxSizeMode.CenterImage;
            logoFB_General.TabIndex = 5;
            logoFB_General.TabStop = false;
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
            bt_crypto.Click += bt_crypto_Click;
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
            gbx_compte.Controls.Add(listBox2);
            gbx_compte.Controls.Add(lbl_solde);
            gbx_compte.Controls.Add(lbl_client);
            gbx_compte.Controls.Add(lb_compte);
            gbx_compte.Controls.Add(bt_virement);
            gbx_compte.Controls.Add(lb_solde);
            gbx_compte.Location = new Point(129, 226);
            gbx_compte.Name = "gbx_compte";
            gbx_compte.Size = new Size(741, 708);
            gbx_compte.TabIndex = 17;
            gbx_compte.TabStop = false;
            gbx_compte.Visible = false;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(112, 248);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(551, 304);
            listBox2.TabIndex = 19;
            listBox2.SizeChanged += listBox2_SizeChanged;
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
            // gbx_virement
            // 
            gbx_virement.BackColor = Color.FromArgb(128, 194, 236);
            gbx_virement.Controls.Add(logoFB_Virement);
            gbx_virement.Controls.Add(cbx_personne);
            gbx_virement.Controls.Add(bt_envoyer);
            gbx_virement.Controls.Add(txt_montant);
            gbx_virement.Location = new Point(221, 226);
            gbx_virement.Name = "gbx_virement";
            gbx_virement.Size = new Size(549, 571);
            gbx_virement.TabIndex = 20;
            gbx_virement.TabStop = false;
            // 
            // logoFB_Virement
            // 
            logoFB_Virement.Image = Properties.Resources.Fulbank;
            logoFB_Virement.Location = new Point(99, 65);
            logoFB_Virement.Name = "logoFB_Virement";
            logoFB_Virement.Size = new Size(352, 208);
            logoFB_Virement.SizeMode = PictureBoxSizeMode.CenterImage;
            logoFB_Virement.TabIndex = 21;
            logoFB_Virement.TabStop = false;
            // 
            // cbx_personne
            // 
            cbx_personne.FormattingEnabled = true;
            cbx_personne.Location = new Point(129, 288);
            cbx_personne.Name = "cbx_personne";
            cbx_personne.Size = new Size(288, 23);
            cbx_personne.TabIndex = 5;
            cbx_personne.VisibleChanged += cbx_personne_VisibleChanged;
            // 
            // bt_envoyer
            // 
            bt_envoyer.Location = new Point(232, 404);
            bt_envoyer.Name = "bt_envoyer";
            bt_envoyer.Size = new Size(75, 23);
            bt_envoyer.TabIndex = 4;
            bt_envoyer.Text = "Envoyer";
            bt_envoyer.UseVisualStyleBackColor = true;
            bt_envoyer.Click += bt_envoyer_Click;
            // 
            // txt_montant
            // 
            txt_montant.Location = new Point(195, 349);
            txt_montant.Name = "txt_montant";
            txt_montant.PlaceholderText = "De combien ?";
            txt_montant.Size = new Size(155, 23);
            txt_montant.TabIndex = 1;
            txt_montant.TextAlign = HorizontalAlignment.Center;
            // 
            // Compte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(gbx_compte);
            Controls.Add(gbx_virement);
            Controls.Add(bt_crypto);
            Controls.Add(bt_livret);
            Controls.Add(bt_epargne);
            Controls.Add(bt_courant);
            Controls.Add(img_retour);
            Controls.Add(logoFB_General);
            Name = "Compte";
            Text = "CompteCourant";
            Load += CompteCourant_Load;
            ((System.ComponentModel.ISupportInitialize)logoFB_General).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).EndInit();
            gbx_compte.ResumeLayout(false);
            gbx_compte.PerformLayout();
            gbx_virement.ResumeLayout(false);
            gbx_virement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoFB_Virement).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoFB_General;
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
        private Label lbl_client;
        private Label lbl_solde;
        private GroupBox gbx_virement;
        private Button bt_envoyer;
        private TextBox txt_montant;
        private ComboBox cbx_personne;
        private ListBox listBox2;
        private PictureBox logoFB_Virement;
    }
}