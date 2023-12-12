using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Client
    {
        private int _idClient;
        private string _tel;
        private string _nom;
        private string _prenom;
        private string _ville;
        private string _rue;
        private int _cp;
        private string _mail;
        private List<Beneficiaire> _beneficiaires;

        public Client(int unId, string unTel, string unNom, string unPrenom, string unevile, string uneRue, int unCp, string unMail) 
        {
            _idClient = unId;
            _tel = unTel;
            _nom = unNom;
            _prenom = unPrenom;
            _ville = unevile;
            _cp = unCp;
            _mail = unMail;
        }

        public int Id {  get { return _idClient; } }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Ville { get; set; }
        public string Rue { get; set; }
        
        public int Cp { get; set; }

        public string Mail {  get; set; }        

    }
}
