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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            bt_voir = new Button();
            bindingSource1 = new BindingSource(components);
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            tbx_Prenom = new TextBox();
            ((System.ComponentModel.ISupportInitialize)img_retour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox2.SuspendLayout();
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
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(341, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 464);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "IBAN";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "RIB";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nom";
            // 
            // button1
            // 
            button1.Location = new Point(114, 356);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bt_voir
            // 
            bt_voir.Location = new Point(383, 791);
            bt_voir.Name = "bt_voir";
            bt_voir.Size = new Size(228, 65);
            bt_voir.TabIndex = 13;
            bt_voir.Text = "Liste Bénéficiaire";
            bt_voir.UseVisualStyleBackColor = true;
            bt_voir.Visible = false;
            bt_voir.Click += bt_voir_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(33, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(828, 356);
            listBox1.TabIndex = 14;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(33, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(891, 547);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // tbx_Prenom
            // 
            tbx_Prenom.Location = new Point(73, 139);
            tbx_Prenom.Name = "tbx_Prenom";
            tbx_Prenom.Size = new Size(155, 23);
            tbx_Prenom.TabIndex = 4;
            tbx_Prenom.Text = "Prenom";
            // 
            // Beneficiaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(bt_voir);
            Controls.Add(bt_delete);
            Controls.Add(bt_add);
            Controls.Add(pictureBox1);
            Controls.Add(img_retour);
            Name = "Beneficiaire";
            Text = "Beneficiaire";
            Load += Beneficiaire_Load;
            ((System.ComponentModel.ISupportInitialize)img_retour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox img_retour;
        private PictureBox pictureBox1;
        private Button bt_add;
        private Button bt_delete;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button bt_voir;
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private ListView listView1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private TextBox tbx_Prenom;
    }
}