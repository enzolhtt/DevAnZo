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
    public partial class ChooseAccount : Form
    {
        public int NumCompteActuel;
        public string NomPrenomClient;
        private Fb_VM.ClientViewModel clientViewModel;
        private Fb_VM.CompteViewModel compteViewModel;

        public ChooseAccount(int numerocompte = 0)
        {
            NumCompteActuel = numerocompte;
            InitializeComponent();
            clientViewModel = new ClientViewModel();
            compteViewModel = new CompteViewModel();
            lbl_ClientAccount.Text = clientViewModel.GetNomPrenom(compteViewModel.getIdClientByNumCompte(numerocompte)).ToString();
        }

        private void bt_courant_Click(object sender, EventArgs e)
        {
            CompteCourant compteCourant = new CompteCourant(NumCompteActuel);
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
            Beneficiaire benef = new Beneficiaire(NumCompteActuel);
            benef.Show();
            this.Hide();
        }
    }
}
