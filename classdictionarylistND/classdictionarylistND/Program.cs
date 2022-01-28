using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdictionarylistND
{
    class Program
    {
        static void Main(string[] args)
        {
            DKlase klase = new DKlase();
            
            klase.PatikrintiArEgzistuoja();
            klase.PridetiIrasa();
            klase.PaemimasIsZodyno();
            klase.GrazinimasVisuValues();

            Console.ReadLine();
            
        }
    }
}
