using Fulbank.Model.Repository;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Beneficiaire
    {
        private string _nom;
        private string _prenom;
        private string _RIB;
        private string _IBAN;
        private int _idClient;

        public Beneficiaire(string nom, string prenom, string rIB, string iBAN, int client)
        {
            _nom = nom;
            _prenom = prenom;
            _RIB = rIB;
            _IBAN = iBAN;
            _idClient = client;
        }
        public int Client { get { return _idClient; } }

        public string getNom() { return _nom; }

        public string getPrenom() { return _prenom; }
        public string getRIB() { return _RIB; }
        public string getIBAN() { return _IBAN; }

        public string affiche()
        {
            return "Nom : " + this.getNom() + " | Prenom : " + this.getPrenom() + " | RIB : " + this.getRIB() + " | IBAN : " + this.getIBAN() + ";";
        }
    }
}
