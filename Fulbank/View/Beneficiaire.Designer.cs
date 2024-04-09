namespace Fulbank.View
{
    partial class Beneficiaire
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
            components = new System.ComponentModel.Container();
            img_retour = new PictureBox();
            pictureBox1 = new PictureBox();
            bt_add = new Button();
            bt_delete = new Button();
            groupBox1 = new GroupBox();
            tbx_Prenom = new TextBox();
            tbx_iban = new TextBox();
            tbx_rib = new TextBox();
            tbx_Nom = new TextBox();
            button1 = new Button();
            bt_voir = new Button();
            bindingSource1 = new BindingSource(components);
            ListeBeneficiaire = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)img_retour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ListeBeneficiaire).BeginInit();
            SuspendLayout();
            // 
            // img_retour
            // 
            img_retour.Image = Properties.Resources.flecheRetour;
            img_retour.Location = new Point(33, 30);
            img_retour.Name = "img_retour";
            img_retour.Size = new Size(140, 140);
            img_retour.SizeMode = PictureBoxSizeMode.StretchImage;
            img_retour.TabIndex = 7;
            img_retour.TabStop = false;
            img_retour.Click += img_retour_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Fulbank;
            pictureBox1.Location = new Point(620, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(149, 791);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(228, 65);
            bt_add.TabIndex = 10;
            bt_add.Text = "Ajouter Bénéficaire";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(620, 791);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(228, 65);
            bt_delete.TabIndex = 11;
            bt_delete.Text = "Supprimer Bénéficaire";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_Prenom);
            groupBox1.Controls.Add(tbx_iban);
            groupBox1.Controls.Add(tbx_rib);
            groupBox1.Controls.Add(tbx_Nom);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(341, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 464);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajout Beneficiaire";
            groupBox1.Visible = false;
            // 
            // tbx_Prenom
            // 
            tbx_Prenom.Location = new Point(73, 139);
            tbx_Prenom.Name = "tbx_Prenom";
            tbx_Prenom.Size = new Size(155, 23);
            tbx_Prenom.TabIndex = 1;
            // 
            // tbx_iban
            // 
            tbx_iban.Location = new Point(73, 275);
            tbx_iban.Name = "tbx_iban";
            tbx_iban.Size = new Size(155, 23);
            tbx_iban.TabIndex = 3;
            // 
            // tbx_rib
            // 
            tbx_rib.Location = new Point(73, 210);
            tbx_rib.Name = "tbx_rib";
            tbx_rib.Size = new Size(155, 23);
            tbx_rib.TabIndex = 2;
            // 
            // tbx_Nom
            // 
            tbx_Nom.Location = new Point(73, 76);
            tbx_Nom.Name = "tbx_Nom";
            tbx_Nom.Size = new Size(155, 23);
            tbx_Nom.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(114, 356);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bt_voir
            // 
            bt_voir.Location = new Point(383, 791);
            bt_voir.Name = "bt_voir";
            bt_voir.Size = new Size(228, 65);
            bt_voir.TabIndex = 5;
            bt_voir.Text = "Liste Bénéficiaire";
            bt_voir.UseVisualStyleBackColor = true;
            bt_voir.Visible = false;
            bt_voir.Click += bt_voir_Click;
            // 
            // ListeBeneficiaire
            // 
            ListeBeneficiaire.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListeBeneficiaire.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListeBeneficiaire.Location = new Point(158, 333);
            ListeBeneficiaire.Name = "ListeBeneficiaire";
            ListeBeneficiaire.RowHeadersWidth = 65;
            ListeBeneficiaire.RowTemplate.Height = 25;
            ListeBeneficiaire.Size = new Size(668, 295);
            ListeBeneficiaire.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 267);
            label1.Name = "label1";
            label1.Size = new Size(323, 37);
            label1.TabIndex = 15;
            label1.Text = "Liste de vos bénéficiaires :";
            // 
            // Beneficiaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(bt_voir);
            Controls.Add(bt_delete);
            Controls.Add(bt_add);
            Controls.Add(pictureBox1);
            Controls.Add(img_retour);
            Controls.Add(ListeBeneficiaire);
            Name = "Beneficiaire";
            Text = "Beneficiaire";
            Load += Beneficiaire_Load;
            ((System.ComponentModel.ISupportInitialize)img_retour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ListeBeneficiaire).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox img_retour;
        private PictureBox pictureBox1;
        private Button bt_add;
        private Button bt_delete;
        private GroupBox groupBox1;
        private TextBox tbx_iban;
        private TextBox tbx_rib;
        private TextBox tbx_Nom;
        private Button button1;
        private Button bt_voir;
        private BindingSource bindingSource1;
        private ListView listView1;
        private TextBox tbx_Prenom;
        private DataGridView ListeBeneficiaire;
        private Label label1;
    }
}