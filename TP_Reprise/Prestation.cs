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

        public Prestation(string libelle, DateTime dateHeureSoin)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateHeureSoin { get => dateHeureSoin; set => dateHeureSoin = value; }


        public bool compareTo(Prestation prestation)
        {
            return this.DateHeureSoin.Date == prestation.DateHeureSoin.Date;
        }


    }
}
