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
        private readonly DateTime dateCreation = DateTime.Today;

        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.DateNaissance = dateNaissance;
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, Prestation prestation)
            :this(nom, prenom, dateNaissance)
        {
            this.listePrestations.Add(prestation);
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestation> prestations)
            : this(nom, prenom, dateNaissance)
        {
            this.listePrestations.AddRange(prestations);
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance {
            get => dateNaissance;
            set
            {
                if(DateTime.Compare(value, DateTime.Today) > 0)
                {
                    dateNaissance = DateTime.Today;
                    throw new SoinsException("La date n'est pas encore passée");                   
                }
                else
                {
                    dateNaissance = value;
                }
            }
        }
        public List<Prestation> ListePrestations { get => listePrestations; set => listePrestations = value; }
        public DateTime DateCreation => dateCreation;

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
                    if (ListePrestations[i].compareTo(ListePrestations[j])==0)
                    {
                        jours--;
                    }
                }
            }

            return jours;
        }

        public int getNbSoinsExternes()
        {
            int compteur = 0;
            foreach(Prestation presta in ListePrestations)
            {
                if(presta.Intervenant is IntervenantExterne)
                {
                    compteur++;
                }
            }
            return compteur;
        }

        public void AfficherDossier()
        {
            Console.WriteLine("-----Début Dossier-------------------");
            Console.WriteLine($"Nom : {this.Nom}, Prénom : {this.Prenom}, Date de naissance : {this.DateNaissance}");
            foreach(Prestation prestation in ListePrestations)
            {
                prestation.AfficherPrestation();
            }
            Console.WriteLine("-----Fin Dossier----------------------");
            Console.WriteLine($@"Nombre de jours de soins V1 : {getNbJoursSoins()}");
            Console.WriteLine($@"Nombre de jours de soins V2 : {getNbJoursSoinsV2()}");
            Console.WriteLine($@"Nombre de soins externes : {getNbSoinsExternes()}");
        }

        public void AjouterPrestation(Prestation presta)
        {
            if (presta.compareTo(this.DateCreation) == 0 || presta.compareTo(this.DateCreation) == 1 )
            {
                this.ListePrestations.Add(presta);
            }
            else { throw new SoinsException("Impossible : Date ultérieur à la création du dossier"); }
        }
    }
}
