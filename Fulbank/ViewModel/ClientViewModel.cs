using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepository = Fulbank.Model.Repository;

namespace Fulbank.ViewModel
{
    internal class ClientViewModel
    {
        private CRepository.ClientRepository CompteRepository;

        public ClientViewModel()
        {
            CompteRepository = new CRepository.ClientRepository();
        }

        public string GetNomPrenom(int id)
        {
            if(CompteRepository.GetNomPrenom(id) != "")
            {
                return CompteRepository.GetNomPrenom(id);
            }
            return "";
        }
    }
}
