﻿using System;
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
            groupBox2.Visible = false;
        }

        private void bt_voir_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            bt_add.Visible = true;
            bt_delete.Visible = true;
            bt_voir.Visible = false;
            groupBox2.Visible = true;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string rib = textBox2.Text;
            string iban = textBox3.Text;
            beneficiaireViewModel.addBeneficiaire(name, rib, iban, compteViewModel.getIdClientByNumCompte(NumCompteActuel).ToString());

            groupBox1.Visible = false;
            bt_add.Visible = true;
            bt_delete.Visible = true;
            bt_voir.Visible = false;
            groupBox2.Visible = true;

            Beneficiaire benef = new Beneficiaire(NumCompteActuel);
            benef.Show();
            this.Hide();
        }

        private void Beneficiaire_Load(object sender, EventArgs e)
        {
            List<Fb_M.Beneficiaire> BeneficiaireVar = beneficiaireViewModel.getAllBeneficiaire(compteViewModel.getIdClientByNumCompte(NumCompteActuel));
            foreach (Fb_M.Beneficiaire b in BeneficiaireVar)
            {
                listBox1.Items.Add(b.affiche());
                //listBox1.Items.Add("Nom : " + b.getNom() + " RIB : " + b.getRIB() + " IBAN : " + b.getIBAN());
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string getNom()
            {
                string NomList = "";
                for (var i = 0; i < listBox1.Items.Count; i++)
                {
                    if (i == listBox1.SelectedIndex)
                    {
                        string chaine = (string)listBox1.Items[i];
                        for (var j = 0; j < chaine.Length; j++)
                        {
                            if (Convert.ToString(chaine[j]) == ":")
                            {
                                string RIBText = "";
                                int k = j + 2;
                                while (Convert.ToString(chaine[j]) != " ")
                                {
                                    NomList += Convert.ToString(chaine[k]);
                                    RIBText = Convert.ToString(chaine[k + 1]) + Convert.ToString(chaine[k + 2]) + Convert.ToString(chaine[k + 3]) + Convert.ToString(chaine[k + 4]);
                                    k += 1;
                                    if (RIBText == " RIB")
                                    {
                                        return NomList;
                                    }
                                } 
                            }
                        }  
                    } 
                }
                return NomList;
            }
            
            if(getNom() != "")
            {
                beneficiaireViewModel.deleteBeneficiaire(getNom());
                Beneficiaire benef = new Beneficiaire(NumCompteActuel);
                benef.Show();
                this.Hide();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
