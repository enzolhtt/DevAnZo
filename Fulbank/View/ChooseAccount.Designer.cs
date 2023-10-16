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
            bt_compte = new Button();
            pictureBox1 = new PictureBox();
            Bt_Deco = new Button();
            button6 = new Button();
            lbl_ClientActuel = new Label();
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
            // 
            // button6
            // 
            button6.Location = new Point(282, 539);
            button6.Name = "button6";
            button6.Size = new Size(444, 74);
            button6.TabIndex = 6;
            button6.Text = "Bénéficiaire";
            button6.UseVisualStyleBackColor = true;
            // 
            // lbl_ClientActuel
            // 
            lbl_ClientActuel.AutoSize = true;
            lbl_ClientActuel.Location = new Point(167, 114);
            lbl_ClientActuel.Name = "lbl_ClientActuel";
            lbl_ClientActuel.Size = new Size(0, 15);
            lbl_ClientActuel.TabIndex = 7;
            // 
            // ChooseAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(lbl_ClientActuel);
            Controls.Add(button6);
            Controls.Add(Bt_Deco);
            Controls.Add(pictureBox1);
            Controls.Add(bt_compte);
            Name = "ChooseAccount";
            Text = "Form1";
            Load += ChooseAccount_Load;
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
        private Label lbl_ClientActuel;
    }
}