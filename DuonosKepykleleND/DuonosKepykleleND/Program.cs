using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuonosKepykleleND
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kiek darbuotojas gali iskepti kepalu per valanda:");
            int kepalai = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite kiek darbuotoju turi kepykla:");
            int darbuotojai = int.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite vieno kepalo savikaina:");
            double savikaina = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite vieno kepalo pardavimo kaina:");
            double pardavimokaina = double.Parse(Console.ReadLine());

            Console.WriteLine("Darbo valandu per diena 8 val.");
            int darboval = 8;

            var perDiena = kepalai * darbuotojai * darboval;
            Console.WriteLine($"Per viena darbo diena kepykla spes iskepti {perDiena} duonos kepalu.");

            var visusavikaina = perDiena * savikaina;
            Console.WriteLine($"Visu iskeptu kepalu savikaina {visusavikaina}");

            var pajamos = perDiena * pardavimokaina;
            Console.WriteLine($"Gautos pajamos pardavus = {pajamos}");

            var pelnas = pajamos - visusavikaina;
            Console.WriteLine($"Jusu pelnas = {pelnas}");

            Console.ReadLine();






        }
    }
}
