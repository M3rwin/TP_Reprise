﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Reprise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prestation> listeTest = new List<Prestation>();
            Prestation pres1 = new Prestation("test1", new DateTime(2023, 06, 12), new Intervenant("Clin", "Marco"));
            Prestation pres2 = new Prestation("test2", new DateTime(2023, 06, 12), new Intervenant("Clin", "Marco"));
            Prestation pres3 = new Prestation("test3", new DateTime(2023, 06, 13), new Intervenant("Clin", "Marco"));
            Prestation pres4 = new Prestation("test2", new DateTime(2023, 06, 12), new Intervenant("Clin", "Marco"));
            Prestation pres5 = new Prestation("test3", new DateTime(2023, 06, 13), new IntervenantExterne("Clin", "Marco", "Cardiologue", "26 impasse des genêts", 0776983272));

            listeTest.Add(pres1);
            listeTest.Add(pres2);
            listeTest.Add(pres3);
            listeTest.Add(pres4);
            listeTest.Add(pres5);

            Dossier dossierTest = new Dossier("Clin", "Marco", new DateTime(2003, 12, 27), listeTest);

            dossierTest.AfficherDossier();
            Console.ReadKey();
        }
    }
}
