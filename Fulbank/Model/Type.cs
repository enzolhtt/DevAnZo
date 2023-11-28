using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.Model
{
    internal class Type
    {
        private int _id;
        private string _typeDeCompte;

        public Type(int unId, string unType) 
        {
            _id = unId;
            _typeDeCompte = unType;
        }

        public int Id { get { return _id;} }
        public string TypeDeCompte { get {  return _typeDeCompte;} }
    }
}
