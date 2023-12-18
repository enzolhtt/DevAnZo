using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepository = Fulbank.Model.Repository;

namespace Fulbank.ViewModel
{
    internal class ConnexionViewModel
    {
        private CRepository.ConnexionRepository ConnexionRepository;
        public ConnexionViewModel() 
        {
            ConnexionRepository = new CRepository.ConnexionRepository();
        }

        public string TestConnexion(int NumCompte)
        {
            return ConnexionRepository.TestConnexion(NumCompte);
        }
    }
}
