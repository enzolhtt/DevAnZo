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
        private string _ville { get; set; }
        private string _rue {  get; set; }
        private int _cp {  get; set; }

        public DAB(int idDAB, string ville, string rue, int cp)
        {
            _idDAB = idDAB;
            _ville = ville;
            _rue = rue;
            _cp = cp;
        }

        public int IdDAB { get { return _idDAB; } }
    }
}
