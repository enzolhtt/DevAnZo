using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fulbank.Model;
using Fulbank.Model.Repository;
using CRepository = Fulbank.Model.Repository;

namespace Fulbank.ViewModel
{
    internal class TransactionViewModel
    {
        private CRepository.TransactionRepository TransactionRepository;

        public TransactionViewModel()
        {
            TransactionRepository = new CRepository.TransactionRepository();
        }
        public List<Transaction> getTransactions(int NumCompte)
        {
            return TransactionRepository.getTransactions(NumCompte);
        }
    }
}
