﻿using System;
using System.Collections.Generic;
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
    }
}
