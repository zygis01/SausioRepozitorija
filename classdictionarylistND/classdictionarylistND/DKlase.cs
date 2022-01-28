using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdictionarylistND
{
    class DKlase
    {
        private Dictionary<string, string> zodynas;

        public DKlase()
        {
            zodynas = new Dictionary<string, string>();
            zodynas.Add("Zygimantas", "1");
        }
        public void PatikrintiArEgzistuoja()
        {
            if (zodynas.ContainsKey("Zygimantas"))
            {
                Console.WriteLine("Irasas egzistuoja zodyne");
            }
            else
            {
                Console.WriteLine("Irasas neegzistuoja zodyne");
            }
        }
        public void PridetiIrasa()
        {
            zodynas.Add("Zygimante", "Jedenkute");
            Console.WriteLine("Pridejome nauja irasa");
        }
        public void PaemimasIsZodyno()
        {
            Console.WriteLine($"{zodynas.TryGetValue("Zygimante", out string value)}");
        }
        public void GrazinimasVisuValues()
        {
            Dictionary<string, string>.ValueCollection values = zodynas.Values;
            Console.WriteLine(zodynas.Values);
        }
    }
}
