using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Reprise
{
    class Prestation
    {
        private string libelle;
        private DateTime dateHeureSoin;
        private Intervenant intervenant;

        public Prestation(string libelle, DateTime dateHeureSoin, Intervenant intervenant)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
            this.intervenant = intervenant;
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateHeureSoin { get => dateHeureSoin; set => dateHeureSoin = value; }
        internal Intervenant Intervenant { get => intervenant; set => intervenant = value; }

        public bool compareTo(Prestation prestation)
        {
            return this.DateHeureSoin.Date == prestation.DateHeureSoin.Date;
        }

        public void AfficherPrestation()
        {
            if(this.Intervenant is IntervenantExterne)
            {
                IntervenantExterne intervenantExterne = (IntervenantExterne)Intervenant;
                Console.WriteLine($"\tLibellé : {this.Libelle} - {this.DateHeureSoin} - Intervenant : {intervenantExterne.Nom} - {intervenantExterne.Prenom} - Spécialité : {intervenantExterne.Specialite}\n\t\t{intervenantExterne.Adresse} - {intervenantExterne.Tel}");
            }
            else
            {
                Console.WriteLine($"\tLibellé : {this.Libelle} - {this.DateHeureSoin} - Intervenant : {this.Intervenant.Nom} - {this.Intervenant.Prenom}");
            }
            
        }

    }
}
