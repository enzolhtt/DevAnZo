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
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "SELECT * FROM Transaction t JOIN DAB d ON d.idDAB = t.idDAB WHERE numCompteDeb = @NumCompte OR numCompteCre = @NumCompte;";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    //MessageBox.Show("oui je passe row");
                    while (reader.Read())
                    {
                        //MessageBox.Show("oui je read");
                        int idTransac = reader.GetInt32(0);
                        DateTime Datetransaction = reader.GetDateTime(1);
                        int montantEmeteur = reader.GetInt32(2);
                        int taux = reader.GetInt32(3);
                        int numCompteDeb = reader.GetInt32(4);
                        int numCompteCre = reader.GetInt32(5);
                        int idDAB = reader.GetInt32(6);
                        string ville = reader.GetString(8);
                        string rue = reader.GetString(9);
                        int cp = reader.GetInt32(10);
                        DAB dab = new DAB(idDAB, ville, rue, cp);
                        Transaction t = new Transaction(idTransac, Datetransaction, montantEmeteur, taux, numCompteDeb, numCompteCre, dab);
                        LesTransactions.Add(t);
                    }
                    reader.NextResult();
                }
            }
            return LesTransactions;
        }
    }
}
