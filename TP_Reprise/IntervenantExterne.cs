using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Reprise
{
    class IntervenantExterne : Intervenant
    {
        private string specialite;
        private string adresse;
        private int tel;

        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, int tel)
            :base(nom, prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }

        public string Specialite { get => specialite; set => specialite = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Tel { get => tel; set => tel = value; }
    }
}
