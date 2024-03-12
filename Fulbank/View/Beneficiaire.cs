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
            compteViewModel = new Fb_VM.CompteViewModel();
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
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxIcon icon = MessageBoxIcon.Exclamation;
            string name = textBox1.Text;
            string rib = textBox2.Text;
            string iban = textBox3.Text;
            string prenom = tbx_Prenom.Text;

            static bool verifRIB(string rib)
            {
                bool verif = false;
                int verifInt = 0;

                try
                {
                    BigInteger ribint = BigInteger.Parse(rib);
                    return true;
                }
                catch (Exception e)
                {
                    // ya une lettre dans le rib
                    return false;
                }

                foreach (char chiffre in rib)
                {
                    try
                    {
                        verifInt += 1;
                    }
                    catch
                    {
                        verif = false;
                    }
                }
                if (verifInt == 35)
                {
                    verif = true;
                }

                return verif;
            }

            if (name == "")
            {
                MessageBox.Show("Le champs nom est obligatoire !", "Attention :", MessageBoxButtons.OK, icon);
            }
            else if (rib.Length != 35)
            {
                MessageBox.Show("Le champs RIB ne contient pas 35 chiffres", "Attention :", MessageBoxButtons.OK, icon);
            }
            else
            {
                if (verifRIB(rib))
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


        }
    }
}
