﻿using System;
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
    }
}
