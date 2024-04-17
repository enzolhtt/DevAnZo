namespace Fulbank.View
{
    partial class Creation
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
            groupBox1 = new GroupBox();
            lbx_personne = new ListBox();
            txt_montant = new TextBox();
            lbl_virement = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 194, 236);
            groupBox1.Controls.Add(lbl_virement);
            groupBox1.Controls.Add(lbx_personne);
            groupBox1.Controls.Add(txt_montant);
            groupBox1.Location = new Point(101, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 708);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lbx_personne
            // 
            lbx_personne.FormattingEnabled = true;
            lbx_personne.ItemHeight = 15;
            lbx_personne.Location = new Point(290, 279);
            lbx_personne.Name = "lbx_personne";
            lbx_personne.Size = new Size(155, 19);
            lbx_personne.TabIndex = 2;
            // 
            // txt_montant
            // 
            txt_montant.Location = new Point(290, 347);
            txt_montant.Name = "txt_montant";
            txt_montant.Size = new Size(155, 23);
            txt_montant.TabIndex = 1;
            txt_montant.Text = "De combien ?";
            txt_montant.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_virement
            // 
            lbl_virement.AutoSize = true;
            lbl_virement.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl_virement.Location = new Point(256, 131);
            lbl_virement.Name = "lbl_virement";
            lbl_virement.Size = new Size(237, 65);
            lbl_virement.TabIndex = 3;
            lbl_virement.Text = "Virement";
            // 
            // Creation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 1218);
            Controls.Add(groupBox1);
            Name = "Creation";
            Text = "Creation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lbx_personne;
        private TextBox txt_montant;
        private Label lbl_virement;
    }
}