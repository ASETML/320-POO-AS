using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class CompteEpargne : CompteBancaire
    {
        public double _interestRate { get; set; }

        public CompteEpargne(double interestRate, int pin, string owner, string devise) : base(pin, owner, devise)
        {
            _interestRate = interestRate;
        }
    }
}
