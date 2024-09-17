using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    class CompteBancaire
    {
        protected string _devise = "CHF";
        protected double _solde = 0;
        protected int _pin;
        protected string _owner;

        public CompteBancaire(int pin, string owner, string devise)
        {
            _pin = pin;
            _owner = owner;
            _devise = devise;
        }

        public void AfficherSolde()
        {
            Console.WriteLine(_solde);
        }

        public void AjouterSolde(float montant)
        {
            _solde += montant;
        }

        public void EnleverSolde(float montant)
        {
            _solde -= montant;
        }
    }
}
