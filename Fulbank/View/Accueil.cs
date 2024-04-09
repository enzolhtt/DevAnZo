using Fulbank.View;
using Fulbank.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fb_VM = Fulbank.ViewModel;

namespace Fulbank
{
    public partial class Accueil : Form
    {
        public int idClientActuel;
        int NumCompteCourant = 0;
        public string? NomPrenomClient;
        private Fb_VM.ClientViewModel? clientViewModel;
        private Fb_VM.CompteViewModel? compteViewModel;

        public Accueil(Dictionary<int, string> DicoNumCompte, int idClient = 0)
        {
            idClientActuel = idClient;

            foreach (KeyValuePair<int, string> NumCompte in DicoNumCompte)
            {
                if (NumCompte.Value.Equals("courant"))
                {
                    NumCompteCourant = NumCompte.Key;
                }
            }
            InitializeComponent();
            clientViewModel = new ClientViewModel();
            compteViewModel = new CompteViewModel();
            if (clientViewModel.GetNomPrenom(idClientActuel).ToString() != "")
            {
                lbl_ClientAccount.Text = "Connecté en tant que : " + clientViewModel.GetNomPrenom(idClientActuel).ToString();
            }

        }

        private void bt_courant_Click(object sender, EventArgs e)
        {

            Compte compteCourant = new Compte(idClientActuel);
            compteCourant.Show();
            this.Hide();
        }

        private void Bt_Deco_Click(object sender, EventArgs e)
        {
            Login deco = new Login();
            deco.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Beneficiaire benef = new Beneficiaire(NumCompteCourant);
            benef.Show();
            this.Hide();
        }
    }
}
