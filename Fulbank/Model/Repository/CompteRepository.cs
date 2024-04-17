using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;

namespace Fulbank.Model.Repository
{
    internal class CompteRepository
    {
        private string connectionString = "server=172.16.119.26; uid=brochard;pwd=admin;database=FulBank";

        /**
         * @role : Fonction permettant d'avoir l'id d'un client par son numéro de compte
         * @param : compteNum => entier
         * @return : idClient => entier
         */
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

        /**
         * @role : Fonction permettant d'avoir l'id d'un client par son RIB
         * @param : ribNum => chaine de caractère
         * @return : idClient => entier
         */
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

        /**
         * @role : Fonction permettant d'avoir le solde d'un compte par son numéro de compte
         * @param : NumCompte => entier
         * @return : solde => double
         */
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

        /**
         * @role : Procédure permettant d'appeler la procédure stockée dans la base de données pour changer le solde suivant les transactions effectués
         * @param : idCompteDebiteur, idCompteCrediteur => entier; Valdebit => float
         * @return : Aucun
         */
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
            }
        }

        /**
         * @role : Fonction permettant d'avoir le numéro de compte par le nom et prenom
         * @param : prenom, nom => chaine de caractère
         * @return : NumCompte => entier
         */
        public int getNumCompteByNom(string prenom, string nom)
        {
            int numcompte;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select NumeroCompte from Compte join Client c on c.idClient = Compte.idClient where Prenom = @name AND Nom = @nom;";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@name", prenom);
                cmd.Parameters.AddWithValue("@nom", nom);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    numcompte = (int)reader["NumeroCompte"];
                    return numcompte;
                }
            }
            return 0;
        }

        /**
         * @role : Fonction permettant d'avoir le nom par le numéro de compte
         * @param : NumCompte => entier
         * @return : Nom => chaine de caractère
         */
        public string getNomByNumCompte(int NumCompte)
        {
            string nom;
            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select nom from Client cli join Compte com on cli.idClient = com.idClient where NumeroCompte = @NumCompte;";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@NumCompte", NumCompte);
                MySqlDataReader reader = cmd.ExecuteReader();
                nom = "";
                while (reader.Read())
                {
                    nom = Convert.ToString(reader["nom"]);
                    return nom;
                }
                return nom;
            }
        }

        /**
         * @role : Fonction permettant d'avoir toutes les informations de tous les comptes
         * @param : Aucun
         * @return : List<Compte> => Liste comportant des instances de la classe compte
         */
        public List<Compte> getAllCompte()
        {
            List<Compte> LesComptes = new List<Compte>();
            int numerocompte;
            double solde;
            DateTime dateouverture;
            double taux;
            string RIB;
            string IBAN;
            int Externe;
            string Mdp;

            using (MySqlConnection connexion = new MySqlConnection())
            {
                connexion.ConnectionString = connectionString;
                connexion.Open();
                string sql = "select * from Compte join Type T on T.IdType = Compte.IdType join devise d on d.idDevise = Compte.idDevise;";
                MySqlCommand cmd = new MySqlCommand(sql, connexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    //MessageBox.Show("oui je passe row");
                    while (reader.Read())
                    {
                        //MessageBox.Show("oui je read");
                        numerocompte = int.Parse(reader.GetString(0));
                        solde = double.Parse(reader.GetString(1));
                        dateouverture = DateTime.Parse(reader.GetString(2));
                        taux = double.Parse(reader.GetString(3));
                        RIB = reader.GetString(4);
                        IBAN = reader.GetString(5);
                        Externe = int.Parse(reader.GetString(6));
                        int idclient = reader.GetInt32(9);
                        //Mdp = reader.GetString(10);
                        int idType = reader.GetInt32(10);
                        string type = reader.GetString(11);
                        int idDevise = reader.GetInt32(12);
                        string devise = reader.GetString(13);
                        Type t = new Type(idType, type);
                        Devise d = new Devise(idDevise, devise);
                        Compte c = new Compte(numerocompte, solde, dateouverture, taux, RIB, IBAN, Externe, idclient,t,d);
                        LesComptes.Add(c);
                    }
                    reader.NextResult();
                }
                return LesComptes;
            }
        }
    }
}
