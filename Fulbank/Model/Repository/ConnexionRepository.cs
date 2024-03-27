using System;
using System.Collections.Generic;
using System.DirectoryServices;
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
        private string password;

        public  string TestConnexion(int idClient)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select Mdp from Client where idClient = " + idClient + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                password = "";
                while (reader.Read())
                {
                    password = Convert.ToString(reader["Mdp"]);
                    return password;
                }
                return password;
            }
        }
    }
}
