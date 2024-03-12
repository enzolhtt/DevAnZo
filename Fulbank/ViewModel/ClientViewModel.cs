using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fulbank.Model;
using System.Threading.Tasks;
using CRepository = Fulbank.Model.Repository;

namespace Fulbank.ViewModel
{
    internal class ClientViewModel
    {
        private CRepository.ClientRepository ClientRepository;

        public ClientViewModel()
        {
            ClientRepository = new CRepository.ClientRepository();
        }

        public string GetNomPrenom(int id)
        {
            return ClientRepository.GetNomPrenom(id);
        }

        public Client getClientByNumCompte(int numCompte)
        {
            return ClientRepository.getClientByNumCompte((int)numCompte);
        }
    }
}
