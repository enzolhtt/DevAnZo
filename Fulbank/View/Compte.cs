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
using Fb_M = Fulbank.Model;
using Fb_VM = Fulbank.ViewModel;
using Fulbank.ViewModel;
using System.Reflection.Metadata.Ecma335;

namespace Fulbank.View
{
    public partial class Compte : Form
    {
        public int idClientActuel;
        public int idClient;
        public int NumCompteCourant = 0;
        public Dictionary<int, string> DicoNumCompte;
        public Login Login = new Login();
        private Fb_VM.ClientViewModel clientViewModel;
        private Fb_VM.CompteViewModel compteViewModel;
        private Fb_VM.BeneficiaireViewModel beneficiaireViewModel;
        private Fb_VM.TransactionViewModel transactionViewModel;
        public Compte(int idClient)
        {
            idClientActuel = idClient;
            InitializeComponent();
            clientViewModel = new ClientViewModel();
            compteViewModel = new CompteViewModel();
            beneficiaireViewModel = new BeneficiaireViewModel();
            transactionViewModel = new TransactionViewModel();
            lb_compte.Text = clientViewModel.GetNomPrenom(idClient).ToString();
            DicoNumCompte = clientViewModel.getNumCompteByIdClient(idClientActuel);
            foreach (KeyValuePair<int, string> NumCompte in DicoNumCompte)
            {
                if (NumCompte.Value.Equals("courant"))
                {
                    NumCompteCourant = NumCompte.Key;
                }
            }
            lbl_solde.Text = compteViewModel.getSoldeByNumCompte(NumCompteCourant).ToString();
        }

        private void img_retour_Click(object sender, EventArgs e)
        {
            if (gbx_compte.Visible == false)
            {
                Accueil retour = new Accueil(DicoNumCompte, idClientActuel);
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
                gbx_virement.Visible = false;
            }
        }

        private void bt_courant_Click(object sender, EventArgs e)
        {
            bt_courant.Visible = false;
            bt_epargne.Visible = false;
            bt_livret.Visible = false;
            bt_crypto.Visible = false;
            gbx_virement.Visible = false;
            gbx_compte.Visible = true;
            lbl_client.Text = "Compte courant";

            var transaction = transactionViewModel.getTransactions(NumCompteCourant);
            int i = 0;
            foreach (Transaction t in transactionViewModel.getTransactions(NumCompteCourant))
            {
                var client = clientViewModel.getClientByNumCompte(transaction[i].getCompteCrediteur());
                var clientdeb = clientViewModel.getClientByNumCompte(transaction[i].getCompteDebiteur());
                if (transaction[i].getCompteCrediteur() == NumCompteCourant)
                {
                    listBox2.Items.Add("+ " + t.getMontantEmeteur() + " de " + clientdeb.getPrenom() + " " + clientdeb.getNom() + ", date : " + t.getDateTransaction().ToString("dd/MM/yyyy"));
                }
                else
                {
                    listBox2.Items.Add("- " + t.getMontantEmeteur() + " à " + client.getPrenom() + " " + client.getNom() + ", date : " + t.getDateTransaction().ToString("dd/MM/yyyy"));
                }
                i++;
            }
        }

        private void CompteCourant_Load(object sender, EventArgs e)
        {
            gbx_virement.Visible = false;
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

        private void bt_virement_Click(object sender, EventArgs e)
        {
            gbx_compte.Visible = false;
            logoFB_General.Visible = false;
            gbx_virement.Visible = true;
            cbx_personne.Visible = true;
            txt_montant.Visible = true;
        }

        private void bt_envoyer_Click(object sender, EventArgs e)
        {
            string nomcre = cbx_personne.SelectedItem.ToString();

            string[] NomPrenom = new string[2];
            string nom = "";
            string prenom = "";
            // MessageBox.Show(nomcre);
            for (int i = 0; i < nomcre.Length; i++)
            {
                nom += nomcre[i];
                if (nomcre[i].ToString() == " ")
                {
                    NomPrenom[0] = nom;
                    for (int j = i + 1; j < nomcre.Length; j++)
                    {
                        prenom += nomcre[j];
                    }
                    NomPrenom[1] = prenom;
                }
            }
            compteViewModel.transactionCompteCourant(NumCompteCourant, compteViewModel.getNumCompteByNom(NomPrenom[1], NomPrenom[0]), float.Parse(txt_montant.Text));
            gbx_compte.Visible = true;
            gbx_virement.Visible = false;
            cbx_personne.Visible = false;
            txt_montant.Visible = false;
        }

        private void cbx_personne_VisibleChanged(object sender, EventArgs e)
        {
            List<Fb_M.Beneficiaire> BeneficiaireVar = beneficiaireViewModel.getAllBeneficiaire(idClientActuel);
            foreach (Fb_M.Beneficiaire b in BeneficiaireVar)
            {
                cbx_personne.Items.Add(b.getNom() + " " + b.getPrenom());
                //listBox1.Items.Add("Nom : " + b.getNom() + " RIB : " + b.getRIB() + " IBAN : " + b.getIBAN());
            }
        }

        private void bt_crypto_Click(object sender, EventArgs e)
        {
            CompteCrypto compteCrypto = new CompteCrypto(idClientActuel);
            compteCrypto.Show();
            this.Hide();
        }

        private void listBox2_SizeChanged(object sender, EventArgs e)
        {
            var transaction = transactionViewModel.getTransactions(NumCompteCourant);
            int i = 0;
            foreach (Transaction t in transactionViewModel.getTransactions(NumCompteCourant))
            {
                var client = clientViewModel.getClientByNumCompte(transaction[i].getCompteCrediteur());
                var clientdeb = clientViewModel.getClientByNumCompte(transaction[i].getCompteDebiteur());
                if (transaction[i].getCompteCrediteur() == NumCompteCourant)
                {
                    listBox2.Items.Add("+ " + t.getMontantEmeteur() + " de " + clientdeb.getPrenom() + " " + clientdeb.getNom() + ", date : " + t.getDateTransaction().ToString("dd/MM/yyyy"));
                }
                else
                {
                    listBox2.Items.Add("- " + t.getMontantEmeteur() + " à " + client.getPrenom() + " " + client.getNom() + ", date : " + t.getDateTransaction().ToString("dd/MM/yyyy"));
                }
                i++;
            }
        }
    }
}
