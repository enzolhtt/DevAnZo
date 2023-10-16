using Fulbank.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.View
{
    public partial class CompteCourant : Form
    {
        public CompteCourant()
        {
            InitializeComponent();

        }

        private void img_retour_Click(object sender, EventArgs e)
        {
            if (gbx_compte.Visible == false)
            {
                ChooseAccount retour = new ChooseAccount();
                retour.Show();
                this.Hide();
            }
            else
            {
                bt_courant.Visible = true;
                bt_epargne.Visible = true;
                bt_livret.Visible = true;
                bt_crypto.Visible = true;
                gbx_compte.Visible = false;
            }
        }

        private void bt_courant_Click(object sender, EventArgs e)
        {
            bt_courant.Visible = false;
            bt_epargne.Visible = false;
            bt_livret.Visible = false;
            bt_crypto.Visible = false;
            gbx_compte.Visible = true;
            lb_compte.Text = "personne" + "\n" + "Compte courant";
            gbx_compte.Text = "Compte courant";
        }

    }
}
