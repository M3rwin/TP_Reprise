using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Reprise
{
    static class Traitement
    {
        public static void TesteDossier()
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

            Dossier dossierTest = new Dossier("Clin", "Marco", new DateTime(2033, 12, 27), listeTest);

            dossierTest.AfficherDossier();
        }

        public static void TesteGetNbPrestations()
        {
            try
            {
                Intervenant test = new Intervenant("Clin", "Marco");
                Prestation pre1 = new Prestation("PrestaTest1", new DateTime(2023, 06, 12), test);
                Prestation pre2 = new Prestation("PrestaTest2", new DateTime(2023, 06, 13), test);
                Prestation pre3 = new Prestation("PrestaTest3", new DateTime(2023, 06, 14), test);
                Console.WriteLine(test.getNbPrestations()); 
            }
            catch(SoinsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static void TesteGetNbPrestationsIE()
        {
            try
            {
                IntervenantExterne test = new IntervenantExterne("Unkeur", "Jay", "Cardiologue", "26 impasse du coeur", 0202020202);
                Prestation pre1 = new Prestation("PrestaTest1", new DateTime(2023, 06, 12), test);
                Prestation pre2 = new Prestation("PrestaTest2", new DateTime(2023, 06, 13), test);
                Prestation pre3 = new Prestation("PrestaTest3", new DateTime(2023, 06, 14), test);
                Console.WriteLine(test.getNbPrestations());
            }
            catch (SoinsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
