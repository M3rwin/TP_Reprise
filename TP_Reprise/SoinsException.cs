using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Reprise
{
    class SoinsException : Exception
    {

        string fileName = ConfigurationManager.AppSettings["LogFileName"];

        public SoinsException(string message)
            :base("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now.ToLocalTime() + "\n" + message)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now.ToLocalTime());
            sw.WriteLine(message);
            sw.Close();
        }
        
    }
}
