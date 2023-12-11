using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Fulbank.Model.Repository
{
    internal class ConnexionRepository
    {
        private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";

        public  bool TestConnexion(int username, string password)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select Mdp from Compte where NumeroCompte = " + username + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //MessageBox.Show("user: " + username + " mdp: " + reader["Mdp"]);
                    if (password == Convert.ToString(reader["Mdp"]))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe ne correspond pas au numéro du compte");
                        return false;
                    }
                }
                return false;
            }
        }
    }
}
