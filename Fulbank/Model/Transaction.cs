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
        private Compte _CompteDebiteur;
        private Compte _CompteCrediteur;
        private DAB _idDAB;

        public Transaction(int idTransaction, DateTime dateTransaction, float montantEmeteur, float taux, Compte compteDebiteur, Compte compteCrediteur, DAB idDAB)
        {
            _idTransaction = idTransaction;
            _dateTransaction = dateTransaction;
            _montantEmeteur = montantEmeteur;
            _taux = taux;
            _CompteDebiteur = compteDebiteur;
            _CompteCrediteur = compteCrediteur;
            _idDAB = idDAB;
        }
    }
}
