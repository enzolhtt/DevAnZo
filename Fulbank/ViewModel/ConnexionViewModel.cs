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

        public bool TestConnexion(int NumCompte, string MdpCompte)
        {
            if(ConnexionRepository.TestConnexion(NumCompte, MdpCompte))
            {
                return true;
            }
            return false;
        }
    }
}
