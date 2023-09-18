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
        private List<Prestation> listePrestations = new List<Prestation>();

        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public Intervenant(string nom, string prenom, Prestation presta)
            :this(nom, prenom)
        {
            listePrestations.Add(presta);
        }

        public Intervenant(string nom, string prenom, List<Prestation> prestations)
            : this(nom, prenom)
        {
            listePrestations.AddRange(prestations);
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        internal List<Prestation> ListePrestations { get => listePrestations; set => listePrestations = value; }

        /// <summary>
        /// Méthodes retournant le nombre de préstations réalisés par un Intervenant
        /// </summary>
        /// <returns>int</returns>
        public int getNbPrestations()
        {
            return ListePrestations.Count();
        }
    }
}
