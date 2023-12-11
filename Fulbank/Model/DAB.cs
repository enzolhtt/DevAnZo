using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class DAB
    {
        private int _idDAB;
        private string _ville;
        private string _rue;
        private int _cp;
        private Client _client;

        public DAB(int idDAB, string ville, string rue, int cp)
        {
            _idDAB = idDAB;
            _ville = ville;
            _rue = rue;
            _cp = cp;
        }

        public int IdDAB { get { return _idDAB; } }
        public string Ville { get; set; }
        public string Rue { get;set; }
        public int Cp { get; set; }
        public Client Client { get { return _client; } }
    }
}
