using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Transaction
    {
        private int _idTransaction;
        private DateTime _dateTransaction;
        private float _montantEmeteur;
        private float _taux;
        private int _CompteDebiteur;
        private int _CompteCrediteur;
        private DAB _idDAB;

        public Transaction(int idTransaction, DateTime dateTransaction, float montantEmeteur, float taux, int compteDebiteur, int compteCrediteur, DAB idDAB)
        {
            _idTransaction = idTransaction;
            _dateTransaction = dateTransaction;
            _montantEmeteur = montantEmeteur;
            _taux = taux;
            _CompteDebiteur = compteDebiteur;
            _CompteCrediteur = compteCrediteur;
            _idDAB = idDAB;
        }

        public int getIdTransaction() { return _idTransaction;}

        public DateTime getDateTransaction() { return _dateTransaction;}
        
        public float getMontantEmeteur() {  return _montantEmeteur;}

        public float getTaux() { return _taux;}

        public int getCompteDebiteur() { return _CompteDebiteur; }

        public int getCompteCrediteur() { return _CompteCrediteur;}

    }
}
