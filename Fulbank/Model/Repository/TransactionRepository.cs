using Fulbank.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fulbank.Model.Repository
{
    internal class TransactionRepository
    {
        private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";
        public List<Transaction> getTransactions(int NumCompte)
        {
            CompteViewModel compte = new CompteViewModel();
            List<Transaction> LesTransactions = new List<Transaction>();
            string name;
            string rib;
            string iban;
            string prenom;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "SELECT DateTransaction, montantEmeteur, numCompteCre FROM bénéficiaire WHERE idClient = @idClient;";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
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
                        Transaction t = new Transaction(name, prenom, rib, iban, compte.getNomByNumCompte(idClient));
                        LesTransactions.Add(b);
                    }
                    reader.NextResult();
                }
            }
            return LesTransactions;
        }
    }
}
