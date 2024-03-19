using Fulbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRepository = Fulbank.Model.Repository;

namespace Fulbank.ViewModel
{
    internal class CompteViewModel
    {
        private CRepository.CompteRepository CompteRepository;

        public CompteViewModel()
        {
            CompteRepository = new CRepository.CompteRepository();
        }

        public int getIdClientByNumCompte(int id)
        {
            return CompteRepository.getIdClientByNumCompte(id);
        }

        public double getSoldeByNumCompte(int NumCompte)
        {
            return CompteRepository.getSoldeByNumCompte(NumCompte);
        }

        public int getIdClientByRib(string id)
        {
            return CompteRepository.getIdClientByRib(id);
        }
        public void transactionCompteCourant(int idCompteDebiteur, int idCompteCrediteur, float Valdebit)
        {
            CompteRepository.transactionCompteCourant(idCompteDebiteur,idCompteCrediteur, Valdebit);
        }
        public int getNumCompteByNom(string prenom, string nom)
        {
            return CompteRepository.getNumCompteByNom(prenom, nom);
        }

        public string getNomByNumCompte(int NumCompte)
        {
            return CompteRepository.getNomByNumCompte(NumCompte);
        }

        public List<Compte> getAllRib()
        {
            return CompteRepository.getAllRib();
        }

    }
}
