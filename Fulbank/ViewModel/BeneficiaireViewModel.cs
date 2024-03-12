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
using System.Data;

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

        public void addBeneficiaire(string name, string prenom, string rib, string iban, string IdClient)
        {
            //compteViewModel = new CompteViewModel();
            BeneficiaireRepository.addBeneficiaire(name, prenom, rib, iban, IdClient);
        }

        public List<Beneficiaire> getAllBeneficiaire(int idClient)
        {
            return BeneficiaireRepository.getAllBeneficiaire(idClient);
        }

        public void deleteBeneficiaire(string RIB)
        {
            BeneficiaireRepository.deleteBeneficiaire(RIB);
        }

        public DataTable getBeneficiaires(int idClient)
        {
            return BeneficiaireRepository.getBeneficiaires(idClient);
        }
    }
}
