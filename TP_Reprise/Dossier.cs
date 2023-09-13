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

        public Dossier(string nom, string prénom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prénom;
            this.dateNaissance = dateNaissance;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
    }
}
