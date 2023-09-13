using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Reprise
{
    class Intervenant
    {
        private string nom;
        private string prenom;

        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
