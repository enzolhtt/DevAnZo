using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Fulbank.Model;
using Fulbank.ViewModel;
using Fb_VM = Fulbank.ViewModel;

namespace Fulbank.View
{
    public partial class CompteCrypto : Form
    {
        public int idClientActuel;
        private CompteViewModel compteViewModel;
        private ClientViewModel clientViewModel;
        public CompteCrypto(int idClient)
        {
            idClientActuel = idClient;
            compteViewModel = new CompteViewModel();
            clientViewModel = new ClientViewModel();
            InitializeComponent();
        }

        private void CompteCrypto_Load(object sender, EventArgs e)
        {
            lb_compte.Text = clientViewModel.GetNomPrenom(idClientActuel);
            foreach (Model.Compte item in compteViewModel.getAllCompte())
            {
                if (item.getIdClient() == idClientActuel && item.getDevise().TypeDevise != "Euro")
                {
                    cbx_crypto.Items.Add(item.getDevise().TypeDevise);
                }
            }
        }

        private async void cbx_crypto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string name = "";
                double convert = 0;
                // Créez un client HTTP
                //string devise = c.getDevise().TypeDevise;
                string devise = cbx_crypto.SelectedItem.ToString();

                Model.Compte c = null;
                foreach (Model.Compte item in compteViewModel.getAllCompte())
                {
                    if (item.getIdClient() == idClientActuel && item.getDevise().TypeDevise == devise)
                    {
                        c = item;
                    }
                }

                //MessageBox.Show("type :" + devise);
                using (HttpClient client = new HttpClient())
                {
                    // Définir l'URL de l'API
                    string apiUrl = string.Format("https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&ids={0}&x_cg_demo_api_key=CG-AVc1nx3n6trSuiWhZUQ6Bwiq", devise);
                    //MessageBox.Show(apiUrl);
                    // Effectuer une demande GET à l'API et attendre la réponse
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Vérifier si la demande a réussi
                    if (response.IsSuccessStatusCode)
                    {
                        // Lire le contenu de la réponse
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Convertir la réponse en objet JObject
                        JArray responseArray = JArray.Parse(responseBody);

                        // Récupérer la première instance de l'objet dans le tableau
                        //JObject firstInstance = (JObject)responseArray[0];

                        label3.Visible = true;
                        lb_solde.Visible = true;
                        lb_prix.Visible = true;
                        pbx_crypto.Visible = true;
                        lb_convertion.Visible = true;

                        // Récupérer les propriétés de la première instance
                        foreach (JObject item in responseArray)
                        {
                            name = item["name"].ToString();
                            convert = c.getSolde() * (double)item["current_price"];


                            label3.Text = name;
                            lb_solde.Text = "Vous avez : " + c.getSolde().ToString() + " " + name;
                            lb_prix.Text = "Prix crypto en Euro : " + item["current_price"].ToString();
                            pbx_crypto.ImageLocation = item["image"].ToString();
                            pbx_crypto.SizeMode = PictureBoxSizeMode.Zoom;
                            lb_convertion.Text = "Vous êtes actuellement à :" + String.Format("{0:0.00}", convert) + " €";
                        }

                        // Afficher les propriétés dans une boîte de message
                        //MessageBox.Show($"Nom : {name}", " Réponse de l'API");
                    }
                    else
                    {
                        MessageBox.Show("La demande à l'API a échoué : " + response.ReasonPhrase, "Erreur1");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur2");
            }
        }

        private void img_retour_Click(object sender, EventArgs e)
        {
            Compte compte = new Compte(idClientActuel);
            compte.Show();
            this.Hide();
        }
    }
}
