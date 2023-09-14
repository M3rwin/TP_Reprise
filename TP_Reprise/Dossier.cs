using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Reprise
{
    class Dossier
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private List<Prestation> listePrestations = new List<Prestation>();

        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, Prestation prestation)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.listePrestations.Add(prestation);
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestation> prestations)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.listePrestations.AddRange(prestations);
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public List<Prestation> ListePrestations { get => listePrestations; set => listePrestations = value; }

        /// <summary>
        /// Fonction retourant le nombres de jours
        /// sur lesquelles se sont étalés les préstations
        /// </summary>
        /// <returns>int</returns>
        public int getNbJoursSoins()
        {
            List<DateTime> joursPrestation = new List<DateTime>();
            joursPrestation.Add(this.ListePrestations[0].DateHeureSoin);

            foreach(Prestation presta in this.ListePrestations)
            {
                if (!joursPrestation.Contains(presta.DateHeureSoin))
                {
                    joursPrestation.Add(presta.DateHeureSoin);
                }
            }

            return joursPrestation.Count;
        }

        public int getNbJoursSoinsV2()
        {
            int jours = this.ListePrestations.Count;
            for(int i=0; i<ListePrestations.Count; i++)
            {
                for(int j=i+1; j<ListePrestations.Count-1; j++)
                {
                    if (ListePrestations[i].compareTo(ListePrestations[j]))
                    {
                        jours--;
                    }
                }
            }

            return jours;
        }
    }
}
