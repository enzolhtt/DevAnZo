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
            label1 = new Label();
            lb_solde = new Label();
            lbl_solde = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 60);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "NomCrypto";
            // 
            // lb_solde
            // 
            lb_solde.AutoSize = true;
            lb_solde.Font = new Font("Segoe UI Black", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_solde.Location = new Point(208, 140);
            lb_solde.Name = "lb_solde";
            lb_solde.Size = new Size(129, 45);
            lb_solde.TabIndex = 15;
            lb_solde.Text = "Solde :";
            // 
            // lbl_solde
            // 
            lbl_solde.AutoSize = true;
            lbl_solde.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_solde.Location = new Point(343, 148);
            lbl_solde.Name = "lbl_solde";
            lbl_solde.Size = new Size(179, 37);
            lbl_solde.TabIndex = 19;
            lbl_solde.Text = "SoldeCompte";
            // 
            // CompteCrypto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_solde);
            Controls.Add(lb_solde);
            Controls.Add(label1);
            Name = "CompteCrypto";
            Text = "CompteCrypto";
            //Load += CompteCrypto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_solde;
        private Label lbl_solde;
    }
}