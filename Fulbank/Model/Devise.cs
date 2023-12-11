using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Devise
    {
        private int idDevise;
        private string typeDevise;

        public Devise(int idDevise, string typeDevise)
        {
            this.idDevise = idDevise;
            this.typeDevise = typeDevise;
        }

        public int IdDevise { get { return idDevise; } }
        public string TypeDevise { get; set; }
    }
}
