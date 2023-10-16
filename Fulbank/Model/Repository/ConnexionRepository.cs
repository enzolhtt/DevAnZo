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
        private string connectionString = "server=172.16.119.21; uid=brochard;pwd=admin;database=FulBank";

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
                    MessageBox.Show("password: " + password + " mdpbase: " + reader["Mdp"]);
                    if (password == Convert.ToString(reader["Mdp"]))
                    {
                        MessageBox.Show("user: " + username + " mdp: " + reader["Mdp"]);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nul");
                        return false;
                    }
                }
                return false;
            }
        }
    }
}
