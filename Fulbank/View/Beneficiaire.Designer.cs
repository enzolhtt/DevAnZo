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
            img_retour = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            bt_add = new Button();
            bt_delete = new Button();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            bt_voir = new Button();
            ((System.ComponentModel.ISupportInitialize)img_retour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(255, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(485, 343);
            dataGridView1.TabIndex = 9;
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(255, 289);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(518, 464);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "IBAN";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "RIB";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nom";
            textBox1.Click += textBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(229, 386);
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
            // Beneficiaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(bt_voir);
            Controls.Add(groupBox1);
            Controls.Add(bt_delete);
            Controls.Add(bt_add);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(img_retour);
            Name = "Beneficiaire";
            Text = "Beneficiaire";
            ((System.ComponentModel.ISupportInitialize)img_retour).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox img_retour;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button bt_add;
        private Button bt_delete;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button bt_voir;
    }
}