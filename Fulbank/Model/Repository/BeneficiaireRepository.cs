using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fulbank.Model;
using Fulbank.ViewModel;

namespace Fulbank.Model.Repository
{
    internal class BeneficiaireRepository
    {
        private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";

        public void addBeneficiaire(string name, string rib, string iban, string idClient)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "INSERT INTO bénéficiaire (nom, RIB, IBAN, IdClient) VALUES (@name,@rib,@iban,@idClient);";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@rib", rib);
                cmd.Parameters.AddWithValue("@iban", iban);
                cmd.Parameters.AddWithValue("@idClient", idClient);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Beneficiaire> getAllBeneficiaire(int idClient)
        {
            CompteViewModel compte = new CompteViewModel();
            List<Beneficiaire> LesBeneficiaires = new List<Beneficiaire>();
            string name;
            string rib;
            string iban;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "SELECT nom, RIB, IBAN FROM bénéficiaire WHERE idClient = @idClient;";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@idClient", idClient);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    //MessageBox.Show("oui je passe row");
                    while (reader.Read()) 
                    {
                        //MessageBox.Show("oui je read");
                        name = reader.GetString(0);
                        rib = reader.GetString(1);
                        iban = reader.GetString(2);
                        Beneficiaire b = new Beneficiaire(name, rib, iban, compte.getIdClientByNumCompte(idClient));
                        LesBeneficiaires.Add(b);
                    }
                    reader.NextResult();
                }
            }
            //MessageBox.Show(LesBeneficiaires[0].getNom());
            return LesBeneficiaires;
        }
    }
}
