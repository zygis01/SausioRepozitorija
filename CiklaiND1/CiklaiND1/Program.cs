using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklaiND1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skaiciuotuvas");
            string toliau = "taip";
            while (toliau == "taip")
            {
                Console.WriteLine("Iveskite pirma skaiciu");
                double pirmasskaicius = double.Parse(Console.ReadLine());
                Console.WriteLine("Iveskite antra skaiciu");
                double antrasskaicius = double.Parse(Console.ReadLine());
                Console.WriteLine("Pasirinkite koki veiksma norite atlikti");
                Console.WriteLine("1 -- sudetis");
                Console.WriteLine("2 -- atimtis");
                Console.WriteLine("3 -- daugyba");
                Console.WriteLine("4 -- dalyba");
                var pasirinkimas = Convert.ToInt32(Console.ReadLine());
                double atsakymas = 0;
                switch(pasirinkimas)
                {
                    case 1:
                        atsakymas = pirmasskaicius + antrasskaicius;
                    break;
                    case 2:
                        atsakymas = pirmasskaicius - antrasskaicius;
                    break;
                    case 3:
                        atsakymas = pirmasskaicius * antrasskaicius;
                    break;
                    case 4:
                        atsakymas = pirmasskaicius / antrasskaicius;
                    break;
                }
                if (pasirinkimas > 0 && pasirinkimas < 5)
                {
                    Console.WriteLine("Atsakymas: {0}", atsakymas);
                }
                else
                    Console.WriteLine("Blogas pasirinkimas");
                Console.WriteLine("Ar noretumete skaiciuoti is naujo? [taip/ne]");
                toliau = Console.ReadLine();
            }
            Console.WriteLine("Paspauskite betkuri mygtuka, kad uzdarytumete programa");
            Console.ReadKey();
        }
       
    }
}
