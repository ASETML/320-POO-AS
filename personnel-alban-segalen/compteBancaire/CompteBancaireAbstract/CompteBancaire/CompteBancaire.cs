using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaire
{
    abstract class CompteBancaire
    {
        protected string _devise;
        protected float _solde;
        protected int _pin;
        protected string _owner;

        public CompteBancaire(int pin, string owner, string devise)
        {
            _devise = devise;
            _owner = owner;
            _pin = pin;
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
