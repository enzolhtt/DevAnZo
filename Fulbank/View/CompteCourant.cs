using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fulbank.View;

namespace Fulbank.View
{
    public partial class CompteCourant : Form
    {
        public Login Login = new Login();
        public CompteCourant()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == false)
            {
                ChooseAccount retour = new ChooseAccount(Login.NumCompte);
                retour.Show();
                this.Hide();
            }
            else
            {
                bt_courant.Visible = true;
                bt_epargne.Visible = true;
                bt_livret.Visible = true;
                bt_crypto.Visible = true;
                bt_virement.Visible = false;
                listBox1.Visible = false;
                lb_solde.Visible = false;
                lb_compte.Text = "personne";
            }
        }

        private void bt_courant_Click(object sender, EventArgs e)
        {
            bt_courant.Visible = false;
            bt_epargne.Visible = false;
            bt_livret.Visible = false;
            bt_crypto.Visible = false;
            bt_virement.Visible = true;
            listBox1.Visible = true;
            lb_solde.Visible = true;
            lb_compte.Text = "personne" + "\n" + "Compte courant";
        }
    }
}
