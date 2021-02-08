using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPost
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Generator g = new Generator();

            List<Bundle> bundles = new List<Bundle>
            {
                g.generateBundle(5),
                g.generateBundle(5),
                g.generateBundle(5),
                g.generateBundle(5),
                g.generateBundle(5)
            };

            int index = 1;
            foreach (var bundle in bundles)
            {
                Console.WriteLine(index + ". " + bundle);
                index++;
            }

            Console.WriteLine();
            Console.WriteLine("Który zestaw wybierasz, wpisz cyfre od 1 do 5");
            int bundleNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Skąd wyruszasz, wpisz cyfre od 1 do 12");
            int startingPointNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Wybrano zestaw numer {bundleNumber}. Miejsce, w którym zaczyna kurier to {startingPointNumber}.");


            DeliveryTimeCalculator dtc = new DeliveryTimeCalculator(bundles[bundleNumber - 1], startingPointNumber);

            dtc.findShortestPath();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}