using System;
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
            try
            {
                Traitement.TesteDossier();
                Console.ReadKey();
            }
            catch(SoinsException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
    }
}
