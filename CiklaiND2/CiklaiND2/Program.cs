using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklaiND2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sugeneruotasSkaicius= random.Next(1, 10);
            bool laimejimas = false;

            do
            {
                Console.WriteLine("Bandykite atspeti slapta skaiciu");
                Console.WriteLine("Nuo 1 iki 10.");
                
                string skaicius = Console.ReadLine();
                int spetasSkaicius = int.Parse(skaicius);

                if (spetasSkaicius > sugeneruotasSkaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra mazesnis");
                }
                else if (spetasSkaicius < sugeneruotasSkaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra didesnis");
                }
                else if (spetasSkaicius == sugeneruotasSkaicius)
                {
                    Console.WriteLine("ATSPEJOTE!!!");
                    laimejimas = true;
                }

            } while (laimejimas == false);
            Console.ReadLine();
        }
    }
}
