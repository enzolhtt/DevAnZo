using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


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
    }
}
