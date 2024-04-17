using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Fulbank.Model;
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
                string NomComplet = "";
                while (reader.Read())
                {
                    string Nom = Convert.ToString(reader["Nom"]);
                    string Prenom = Convert.ToString(reader["Prenom"]);
                    NomComplet = Nom + " " + Prenom;
                    return NomComplet;
                }
                return NomComplet;
            }
        }

        public Client getClientByNumCompte(int numCompte)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select * from Client cl join Compte co on co.idClient = cl.idClient where NumeroCompte = @numCompte;";
                MySqlCommand cmd = new MySqlCommand( sql, connexion);
                cmd.Parameters.AddWithValue("@numcompte", numCompte);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idClient = reader.GetInt32(0);
                    string tel = reader.GetString(1);
                    string nom = reader.GetString(2);
                    string prenom = reader.GetString(3);
                    string ville = reader.GetString(4);
                    string rue = reader.GetString(5);
                    string cp = reader.GetString(6);
                    string mail = reader.GetString(7);
                    Client cli = new Client(idClient, tel, nom, prenom, ville, rue, cp, mail );
                    return cli;
                }
            }
            return null;
        }

        public Dictionary<int,string> getNumCompteByIdClient(int idClient)
        {
            Dictionary<int, string> DicoNumCompte = new Dictionary<int, string>();
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select Compte.NumeroCompte, TypeDeCompte from Client join Compte on Client.idClient = Compte.idClient join Type on Compte.idType = Type.IdType where Client.idClient = " + idClient + ";";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DicoNumCompte.Add(reader.GetInt32(0), reader.GetString(1));
                    //MessageBox.Show("Voici la liste des comptes: " + reader.GetInt32(0) + " " + reader.GetString(1));
                }
                return DicoNumCompte;
            }
        }
    }
}