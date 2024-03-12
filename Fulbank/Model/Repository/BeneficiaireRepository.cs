using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fulbank.Model;
using Fulbank.ViewModel;
using System.Data;

namespace Fulbank.Model.Repository
{
    internal class BeneficiaireRepository
    {
        private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";

        public void addBeneficiaire(string name, string prenom, string rib, string iban, string idClient)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "INSERT INTO bénéficiaire (nom, RIB, IBAN, IdClient, prenom) VALUES (@name, @rib,@iban, @idClient, @prenom);";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@prenom", prenom);
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
            string prenom;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "SELECT nom, prenom, RIB, IBAN FROM bénéficiaire WHERE idClient = @idClient;";
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
                        prenom = reader.GetString(1);
                        rib = reader.GetString(2);
                        iban = reader.GetString(3);
                        Beneficiaire b = new Beneficiaire(name, prenom, rib, iban, compte.getIdClientByNumCompte(idClient));
                        LesBeneficiaires.Add(b);
                    }
                    reader.NextResult();
                }
            }
            //MessageBox.Show(LesBeneficiaires[0].getNom());
            return LesBeneficiaires;
        }

        public void deleteBeneficiaire(string RIB)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "DELETE FROM bénéficiaire WHERE RIB = @RIB;";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@RIB", RIB);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable getBeneficiaires(int idCLient)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();

                string sql = "SELECT Nom, Prenom, RIB from bénéficiaire where idClient = @idClient";
                using (MySqlCommand cmd = new MySqlCommand(sql, connexion))
                {
                    cmd.Parameters.AddWithValue("@idClient", idCLient);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }
    }
}
