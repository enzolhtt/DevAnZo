using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Beneficiaire
    {
        private int _idBeficiaire;
        private string _nom;
        private string _RIB;
        private string _IBAN;
        private Client _client;

        public Beneficiaire(int idBeficiaire, string nom, string rIB, string iBAN, Client client)
        {
            _idBeficiaire = idBeficiaire;
            _nom = nom;
            _RIB = rIB;
            _IBAN = iBAN;
            _client = client;
        }

        public int IdBeficiaire { get { return _idBeficiaire; } }
        public string Nomb { get; set; }
        public string RIB { get; set; }
        public string IBAN { get; set; }
        public Client Client { get { return _client; } }

    }
}
