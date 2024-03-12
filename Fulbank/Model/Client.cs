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
        private string _cp;
        private string _mail;
        private List<Beneficiaire> _beneficiaires;

        public Client(int unId, string unTel, string unNom, string unPrenom, string unevile, string uneRue, string unCp, string unMail) 
        {
            _idClient = unId;
            _tel = unTel;
            _nom = unNom;
            _prenom = unPrenom;
            _ville = unevile;
            _rue = uneRue;
            _cp = unCp;
            _mail = unMail;
        }

        public int getId()
        {
            return _idClient;
        }
        public string getNom()
        {
            return _nom;
        }
        public string getPrenom()
        {
            return _prenom;
        }
        public string Ville { get; set; }
        public string Rue { get; set; }
        
        public string Cp { get; set; }

        public string Mail {  get; set; }        

    }
}
