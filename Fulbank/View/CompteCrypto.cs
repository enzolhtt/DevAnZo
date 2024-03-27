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
        public CompteCrypto(int idClient)
        {
            idClientActuel = idClient;
            compteViewModel = new CompteViewModel();
            InitializeComponent();
        }

        private async void CompteCrypto_Load(object sender, EventArgs e)
        {
            string name = "";
            double convert = 0;

            Compte c = null;
            foreach (Compte item in compteViewModel.getAllCompte())
            {
                if (item.getIdClient() == idClientActuel)
                {
                    c = item;
                }
            }
            try
            {
                // Créez un client HTTP
                string devise = c.getDevise().TypeDevise;
                MessageBox.Show("type :" + devise);
                using (HttpClient client = new HttpClient())
                {
                    // Définir l'URL de l'API
                    string apiUrl = string.Format("https://api.coingecko.com/api/v3/coins/markets?vs_currency=eur&ids={0}&x_cg_demo_api_key=CG-AVc1nx3n6trSuiWhZUQ6Bwiq", devise);
                    MessageBox.Show(apiUrl);
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

                        // Récupérer les propriétés de la première instance
                        foreach (JObject item in responseArray)
                        {
                            //if (item["name"].ToString() == c.getDevise().TypeDevise)
                            //{
                            //    name = item["name"].ToString();
                            //    label1.Text = name;
                            //    lbSolde.Text = c.getSolde().ToString();
                            //    //lb_prix.Text = item["current_price"].ToString();
                            //}
                            name = item["name"].ToString();
                            convert = c.getSolde() * (double)item["current_price"];


                            label3.Text = name;
                            lb_solde.Text = "Vous avez : " + c.getSolde().ToString() + " " + name;
                            lb_prix.Text = item["current_price"].ToString();
                            pbx_crypto.ImageLocation = item["image"].ToString();
                            pbx_crypto.SizeMode = PictureBoxSizeMode.Zoom;
                            lb_convertion.Text = "Vous êtes actuellement à :"+ String.Format("{0:0.00}",convert) + " €";
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
    }
}
