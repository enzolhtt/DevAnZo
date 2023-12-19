using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Fulbank.Model.Repository
{
    internal class CompteRepository
    {
        private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";

        public int getIdClientByNumCompte(int compteNum)
        {
            int IdClient;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select idClient from Compte where numerocompte = " + compteNum + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IdClient = (int)reader["idClient"];
                    return IdClient;
                }
            }
            return 0;
        }

        public int getIdClientByRib(string ribNum)
        {
            int IdClient;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select idClient from Compte where RIB = " + ribNum + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IdClient = (int)reader["idClient"];
                    return IdClient;
                }
            }
            return 0;
        }

        public double getSoldeByNumCompte(int NumCompte)
        {
            double solde;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select Solde from Compte where numerocompte = " + NumCompte + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    solde = (double)reader["Solde"];
                    return solde;
                }
            }
            return 0;
        }

        public void transactionCompteCourant(int idCompteDebiteur, int idCompteCrediteur,float Valdebit)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                //string sql = "CALL transactionCompteCourant(@idOne,@idTwo,@Val);";
                MySqlCommand cmd = new MySqlCommand("transactionCompteCourant", connexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("idCompteDebiteur", idCompteDebiteur));
                cmd.Parameters.Add(new MySqlParameter("idCompteCrediteur", idCompteCrediteur));
                cmd.Parameters.Add(new MySqlParameter("ValDebit", Valdebit));
                cmd.ExecuteNonQuery();
                MessageBox.Show(cmd.ToString());
            }
        }
    }
}
