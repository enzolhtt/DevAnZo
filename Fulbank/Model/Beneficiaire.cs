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
        private string _RIB;
        private string _IBAN;
        private int _idClient;

        public Beneficiaire(string nom, string rIB, string iBAN, int client)
        {
            _nom = nom;
            _RIB = rIB;
            _IBAN = iBAN;
            _idClient = client;
        }

        public string Nomb { get; set; }
        public string RIB { get; set; }
        public string IBAN { get; set; }
        public int Client { get { return _idClient; } }

        public string getNom() { return _nom; }
        public string getRIB() { return _RIB; }
        public string getIBAN() { return _IBAN; }
    }
}
