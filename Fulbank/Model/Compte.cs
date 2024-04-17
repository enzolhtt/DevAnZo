using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Compte
    {
        private int _numeroCompte;
        private double _solde;
        private DateTime _dateouverture;
        private double _taux;
        private string _rib;
        private string _iban;
        private int _externe;
        private int _idClient;
        private Type _type;
        private Devise _devise;

        public Compte(int numerocompte, double solde, DateTime dateouverture, double taux, string? rib, string? iban, int externe, int idclient, Type unType, Devise uneDevise)
        {
            _numeroCompte = numerocompte;
            _solde = solde;
            _dateouverture = dateouverture;
            _taux = taux;
            _rib = rib;
            _iban = iban;
            _externe = externe;
            _idClient = idclient;
            _type = unType;
            _devise = uneDevise;
        }

        public string Solde { get; set; }

        public string getRib()
        {
            return _rib;
        }

        public int getIdClient()
        {
            return this._idClient;
        }
        public Type getType()
        {
            return this._type;
        }
        public Devise getDevise()
        {
            return this._devise;
        }

        public double getSolde()
        {
            return this._solde;
        }
    }
}
