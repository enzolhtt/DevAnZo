namespace Fulbank
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            bt_connecter = new Button();
            tbx_password = new TextBox();
            tbx_user = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bt_connecter
            // 

            bt_connecter.BackColor = Color.FromArgb(34, 67, 153);
            bt_connecter.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            bt_connecter.ForeColor = Color.White;
            bt_connecter.Location = new Point(373, 754);
            bt_connecter.Margin = new Padding(0);
            bt_connecter.Name = "bt_connecter";
            bt_connecter.Size = new Size(247, 77);
            bt_connecter.TabIndex = 1;
            bt_connecter.Text = "Se connecter";
            bt_connecter.UseVisualStyleBackColor = false;
            // 
            // tbx_password
            // 
            tbx_password.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_password.Location = new Point(324, 602);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(346, 43);
            tbx_password.TabIndex = 2;
            tbx_password.Text = "Password";
            // 
            // tbx_user
            // 
            tbx_user.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_user.Location = new Point(324, 449);
            tbx_user.Name = "tbx_user";
            tbx_user.Size = new Size(346, 43);
            tbx_user.TabIndex = 3;
            tbx_user.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 194, 236);
            ClientSize = new Size(984, 961);
            Controls.Add(tbx_user);
            Controls.Add(tbx_password);
            Controls.Add(bt_connecter);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_connecter;
        private TextBox tbx_password;
        private TextBox tbx_user;
    }
}