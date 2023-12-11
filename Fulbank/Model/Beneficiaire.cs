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

        public Beneficiaire(int idBeficiaire, string nom, string rIB, string iBAN)
        {
            _idBeficiaire = idBeficiaire;
            _nom = nom;
            _RIB = rIB;
            _IBAN = iBAN;
        }

        public int IdBeficiaire { get; set; }
        public string Nomb { get; set; }
        public string RIB { get; set; }
        public string IBAN { get; set; }

    }
}
