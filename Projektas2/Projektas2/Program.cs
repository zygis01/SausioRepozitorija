using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite norima gerima:");

            Console.WriteLine("1 - Limonadas");
            Console.WriteLine("2 - Arbata");
            Console.WriteLine("3 - Kakava");
            Console.WriteLine("4 - Kava");
            Console.WriteLine("5 - Nieko");

            int pasirinkimas = int.Parse(Console.ReadLine());

            var pirmas = "Limonadas";
            var antras = "Arbata";
            var trecias = "Kakava";
            var ketvirtas = "Kava";
            var penktas = "Nieko";

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine($"Jus pasirinkote {pirmas} ");
                    break;
                case 2:
                    Console.WriteLine($"Jus pasirinkote {antras}");
                    break;
                case 3:
                    Console.WriteLine($"Jus pasirinkote {trecias}");
                    break;
                case 4:
                    Console.WriteLine($"Jus pasirinkote {ketvirtas}");
                    break;
                case 5:
                    Console.WriteLine($"Jus pasirinkote {penktas}");
                    break;
                default:
                    Console.WriteLine($"Blogai ivestas pasirinkimas...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
