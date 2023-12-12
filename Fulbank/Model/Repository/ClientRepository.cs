using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fulbank.Model.Repository
{

    internal class ClientRepository
    {
        private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";
        public string GetNomPrenom(int id)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select Nom, Prenom from Client where idClient = " + id + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string Nom = Convert.ToString(reader["Nom"]);
                    string Prenom = Convert.ToString(reader["Prenom"]);
                    return Nom + " " + Prenom;
                }
                return "Aucun Nom ou Prenom associé à ce compte";
            }
        }
    }
}
