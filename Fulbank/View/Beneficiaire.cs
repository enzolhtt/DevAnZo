using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fulbank.ViewModel;
using Fb_M = Fulbank.Model;
using Fb_VM = Fulbank.ViewModel;
using Fulbank.Model.Repository;
using Fulbank.Model;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;

namespace Fulbank.View
{
    public partial class Beneficiaire : Form
    {
        public int NumCompteActuel;
        private Fb_VM.CompteViewModel compteViewModel;
        private Fb_VM.BeneficiaireViewModel beneficiaireViewModel;
        public Beneficiaire(int NumCompte)
        {
            NumCompteActuel = NumCompte;
            InitializeComponent();
            compteViewModel = new CompteViewModel();
            beneficiaireViewModel = new BeneficiaireViewModel();
        }

        private void img_retour_Click(object sender, EventArgs e)
        {
            ChooseAccount retour = new ChooseAccount(NumCompteActuel);
            retour.Show();
            this.Hide();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            bt_add.Visible = false;
            bt_delete.Visible = false;
            bt_voir.Visible = true;
            ListeBeneficiaire.Visible = false;
        }

        private void bt_voir_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            bt_add.Visible = true;
            bt_delete.Visible = true;
            bt_voir.Visible = false;
            ListeBeneficiaire.Visible = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tbx_Nom.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            string name = tbx_Nom.Text;
            string rib = tbx_rib.Text;
            string iban = tbx_iban.Text;
            string prenom = tbx_Prenom.Text;

            bool verifRIBandIBAN(string rib, string iban)
            {
                bool verif = false;
                string newIBAN = iban.Substring(2, 25); ;

                try
                {
                    BigInteger ribint = BigInteger.Parse(rib);
                    BigInteger ibanint = BigInteger.Parse(newIBAN);
                    return true;
                }
                catch (Exception e)
                {
                    // ya une lettre dans le rib
                    return false;
                }

                return verif;
            }

            bool checkCompteExiste(string rib)
            {
                bool check = false;
                List<Compte> ListeComptes = compteViewModel.getAllRib();

                foreach (Compte compte in ListeComptes)
                {
                    if (compte.getRib() == rib)
                    {
                        check = true;
                    }
                }

                return check;
            }

            if (name == "" || prenom == "" || rib == "" || iban == "")
            {
                MessageBox.Show("Les champs sont tous obligatoires !", "Attention :", MessageBoxButtons.OK, icon);
            }
            else if (rib.Length != 35)
            {
                MessageBox.Show("Le champs RIB ne contient pas 35 chiffres", "Attention :", MessageBoxButtons.OK, icon);
            }
            else if (iban.Length != 27)
            {
                MessageBox.Show("Le champs IBAN ne contient pas 25 chiffres en plus de l'abréviation 'FR'", "Attention :", MessageBoxButtons.OK, icon);
            }
            else
            {
                if (checkCompteExiste(rib))
                {
                    if (verifRIBandIBAN(rib, iban))
                    {
                        beneficiaireViewModel.addBeneficiaire(name, prenom, rib, iban, compteViewModel.getIdClientByNumCompte(NumCompteActuel).ToString());
                        Beneficiaire benef = new Beneficiaire(NumCompteActuel);
                        benef.Show();
                        this.Hide();
                        groupBox1.Visible = false;
                        bt_add.Visible = true;
                        bt_delete.Visible = true;
                        bt_voir.Visible = false;
                        ListeBeneficiaire.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Votre RIB ne contient pas que des chiffres !", "Attention :", MessageBoxButtons.OK, icon);
                    }
                }
                else
                {
                    MessageBox.Show("Le bénéficiaire que vous essayez de créer ne possède pas de compte dans notre banque !", "Attention :", MessageBoxButtons.OK, icon);
                }
            }
        }

        private void Beneficiaire_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("idClient : " + compteViewModel.getIdClientByNumCompte(NumCompteActuel));
                DataTable table = beneficiaireViewModel.getBeneficiaires(compteViewModel.getIdClientByNumCompte(NumCompteActuel));
                ListeBeneficiaire.AutoGenerateColumns = true;
                ListeBeneficiaire.DataSource = table;
                ListeBeneficiaire.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Erreur de chargement des bénéficiaires merci de réessayer ultérieurement !");
            }

            tbx_iban.PlaceholderText = "IBAN";
            tbx_Nom.PlaceholderText = "Nom";
            tbx_Prenom.PlaceholderText = "Prenom";
            tbx_rib.PlaceholderText = "RIB";
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            /*string getRIB()
            {
                string SelectRow = listBox1.SelectedItem.ToString();
                string RIB_Select = "";
                for (int i = 0; i < SelectRow.Length; i++)
                {
                    if (SelectRow[i + 4] == ';')
                    {
                        //MessageBox.Show("test i+4");
                        return "";
                    }
                    else
                    {
                        //MessageBox.Show("test else");
                        string RIBFind = SelectRow[i].ToString() + SelectRow[i + 1].ToString() + SelectRow[i + 2].ToString() + SelectRow[i + 3].ToString() + SelectRow[i + 4].ToString() + SelectRow[i + 5].ToString() + SelectRow[i + 6].ToString();
                        //MessageBox.Show("test RIBFind = " +  RIBFind);
                        if (RIBFind == "| RIB :")
                        {
                            //MessageBox.Show("test if rib");
                            for (int j = i + 9; j < (i + 9) + 34; j++)
                            {
                                //MessageBox.Show("test for j");
                                RIB_Select = RIB_Select + SelectRow[j].ToString();
                                //MessageBox.Show("RIB INT " + SelectRow[j].ToString());

                            }
                            MessageBox.Show(";" + RIB_Select + ";");
                            return RIB_Select;
                        }
                    }
                }

                return "";
            }


            if (getRIB() != "")
            {
                string mess = "Etes-vous sur de vouloir suprimer ce bénéficiare de votre liste de beneficiare ?"; ;
                string title = "Attention vous tentez de supprimer un beneficiaire.";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                DialogResult result = MessageBox.Show(mess, title, buttons, icon);
                if (result == DialogResult.Yes)
                {
                    beneficiaireViewModel.deleteBeneficiaire(getRIB());
                    Beneficiaire benef = new Beneficiaire(NumCompteActuel);
                    benef.Show();
                    this.Hide();
                }
            }*/

            string Nom = (string)ListeBeneficiaire.CurrentRow.Cells[0].Value;
            string Prenom = (string)ListeBeneficiaire.CurrentRow.Cells[1].Value;
            string RIB = (string)ListeBeneficiaire.CurrentRow.Cells[2].Value;
            //MessageBox.Show("RIB :" + RIB);

            string mess = "Etes-vous sur de vouloir suprimer " + Nom + " " + Prenom + " de votre liste de beneficiare ?"; ;
            string title = "Attention vous tentez de supprimer un beneficiaire.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            DialogResult result = MessageBox.Show(mess, title, buttons, icon);
            if (result == DialogResult.Yes)
            {
                beneficiaireViewModel.deleteBeneficiaire(RIB);
                Beneficiaire benef = new Beneficiaire(NumCompteActuel);
                benef.Show();
                this.Hide();
            }
        }
    }
}
