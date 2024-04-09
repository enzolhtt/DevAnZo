namespace Fulbank.View
{
    partial class CompteCrypto
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
            lb_solde = new Label();
            lb_prix = new Label();
            label2 = new Label();
            pbx_crypto = new PictureBox();
            label3 = new Label();
            lb_convertion = new Label();
            img_retour = new PictureBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbx_crypto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_solde
            // 
            lb_solde.AutoSize = true;
            lb_solde.Font = new Font("Segoe UI Black", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_solde.Location = new Point(339, 419);
            lb_solde.Name = "lb_solde";
            lb_solde.Size = new Size(109, 45);
            lb_solde.TabIndex = 15;
            lb_solde.Text = "Solde";
            // 
            // lb_prix
            // 
            lb_prix.AutoSize = true;
            lb_prix.Location = new Point(339, 322);
            lb_prix.Name = "lb_prix";
            lb_prix.Size = new Size(38, 15);
            lb_prix.TabIndex = 17;
            lb_prix.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 322);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 18;
            label2.Text = "Prix crypto en euro :";
            // 
            // pbx_crypto
            // 
            pbx_crypto.Location = new Point(12, 292);
            pbx_crypto.Name = "pbx_crypto";
            pbx_crypto.Size = new Size(187, 172);
            pbx_crypto.TabIndex = 19;
            pbx_crypto.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 301);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 20;
            label3.Text = "label1";
            // 
            // lb_convertion
            // 
            lb_convertion.AutoSize = true;
            lb_convertion.Location = new Point(339, 476);
            lb_convertion.Name = "lb_convertion";
            lb_convertion.Size = new Size(38, 15);
            lb_convertion.TabIndex = 21;
            lb_convertion.Text = "label1";
            // 
            // img_retour
            // 
            img_retour.Image = Properties.Resources.flecheRetour;
            img_retour.Location = new Point(12, 12);
            img_retour.Name = "img_retour";
            img_retour.Size = new Size(140, 140);
            img_retour.SizeMode = PictureBoxSizeMode.StretchImage;
            img_retour.TabIndex = 22;
            img_retour.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fulbank;
            pictureBox1.Location = new Point(620, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(380, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 34);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 25;
            label1.Text = "Choisir sa crypto :";
            // 
            // CompteCrypto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(img_retour);
            Controls.Add(lb_convertion);
            Controls.Add(label3);
            Controls.Add(pbx_crypto);
            Controls.Add(label2);
            Controls.Add(lb_prix);
            Controls.Add(lb_solde);
            Name = "CompteCrypto";
            Text = "CompteCrypto";
            Load += CompteCrypto_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_crypto).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_retour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_solde;
        private Label lbSolde;
        private Label lb_prix;
        private Label label2;
        private PictureBox pbx_crypto;
        private Label label3;
        private Label lb_convertion;
        private PictureBox img_retour;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}