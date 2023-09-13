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

        public int getNbJoursSoins()
        {
            bool doublon = false;
            List<Prestation> joursPresta = new List<Prestation>();

            foreach(Prestation presta in ListePrestations)
            {
                int i = 0;
                while(!doublon && i < joursPresta.Count)
                {
                    if (!presta.compareTo(joursPresta[i]))
                    {
                        doublon=true;
                    }
                }
                joursPresta.Add(presta);
            }

            foreach(Prestation presta in joursPresta)
            {
                Console.WriteLine(presta.DateHeureSoin.Date);
            }
            return joursPresta.Count;
        }
    }
}
