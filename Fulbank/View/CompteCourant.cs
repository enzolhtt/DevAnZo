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
using Fulbank.View;
using Fb_VM = Fulbank.ViewModel;
using Fulbank.ViewModel;


namespace Fulbank.View
{
    public partial class CompteCourant : Form
    {
        public Login Login = new Login();
        private Fb_VM.ClientViewModel clientViewModel;
        private Fb_VM.CompteViewModel compteViewModel;
        public CompteCourant(int NumCompte)
        {
            InitializeComponent();
            clientViewModel = new ClientViewModel();
            compteViewModel = new CompteViewModel();
            lb_compte.Text = clientViewModel.GetNomPrenom(compteViewModel.getIdClientByNumCompte(NumCompte)).ToString();
            lbl_solde.Text = compteViewModel.getSoldeByNumCompte(NumCompte).ToString();
        }

        private void img_retour_Click(object sender, EventArgs e)
        {
            if (gbx_compte.Visible == false)
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
            gbx_compte.Text = "Compte courant";
            lbl_client.Text = "Compte courant";
        }

        private void CompteCourant_Load(object sender, EventArgs e)
        {
            if (int.Parse(lbl_solde.Text) > 0)
            {
                lbl_solde.Text = " + " + lbl_solde.Text + " €";
                lbl_solde.ForeColor = Color.Green;
            }
            else if (int.Parse(lbl_solde.Text) == 0)
            {
                lbl_solde.Text = lbl_solde.Text + " €";
            }
            else
            {
                lbl_solde.Text = lbl_solde.Text + " €";
                lbl_solde.ForeColor = Color.Red;
            }
        }
    }
}
