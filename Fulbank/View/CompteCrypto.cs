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
            double solde = 0;
            try
            {
                
                // Créez un client HTTP
                using (HttpClient client = new HttpClient())
                {
                    Compte c;
                    foreach (Compte item in compteViewModel.getAllCompte())
                    {
                        Fulbank.Model.Type t = item.getType();
                        if (item.getType().TypeDeCompte == "crypto" && item.getIdClient() == idClientActuel)
                        {
                            c = item;
                        }
                    }
                    // Définir l'URL de l'API
                    string apiUrl = "https://api.coingecko.com/api/v3/coins/list?x_cg_demo_api_key=CG-AVc1nx3n6trSuiWhZUQ6Bwiq";

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
                            if (item["name"].ToString() == c.getType().TypeDeCompte)
                            {
                                name = item["name"].ToString();
                                label1.Text = name;
                            }
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
