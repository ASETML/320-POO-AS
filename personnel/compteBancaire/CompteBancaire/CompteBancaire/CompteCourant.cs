using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class CompteCourant : CompteBancaire
    {
        public int _nbCarte { get; set; }

        public CompteCourant(int nbCarte, int pin, string owner, string devise) : base(pin, owner, devise)
        {
            _nbCarte = nbCarte;
        }
    }
}
