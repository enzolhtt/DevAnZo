using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fulbank.ViewModel;
using Fulbank.Model;
using System.Threading.Tasks;
using Fb_VM = Fulbank.ViewModel;
using CRepository = Fulbank.Model.Repository;
using System.Web;

namespace Fulbank.ViewModel
{
    internal class BeneficiaireViewModel
    {
        private CRepository.BeneficiaireRepository BeneficiaireRepository;

        //private Fb_VM.CompteViewModel compteViewModel;

        public BeneficiaireViewModel() 
        {
            BeneficiaireRepository = new CRepository.BeneficiaireRepository();
        }

        public void addBeneficiaire(string name, string rib, string iban, string IdClient)
        {
            //compteViewModel = new CompteViewModel();
            BeneficiaireRepository.addBeneficiaire(name, rib, iban, IdClient);
        }

        public List<Beneficiaire> getAllBeneficiaire(int idClient)
        {
            return BeneficiaireRepository.getAllBeneficiaire(idClient);
        }

        public void deleteBeneficiaire(string name)
        {
            BeneficiaireRepository.deleteBeneficiaire(name);
        }
    }
}
