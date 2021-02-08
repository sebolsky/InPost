using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPost
{
    class Generator
    {
        private readonly Random rnd = new Random();
        private readonly List<string> Names = new List<string> { "Książka", "Telefon", "Zegarek", "Laptop", "Konsola", "Mysz i Słuchawki", "Smartwatch", "Rower", "Hulajnoga", "Rolki" };

        public Bundle generateBundle(int numberOfBoxes)
        {
            var bundle = new List<Box>();
            while (bundle.Count() < numberOfBoxes)
            {
                Box box = generateBox();
                if (!bundle.Contains(box))
                {
                    bundle.Add(box);
                }
            }

            return new Bundle(bundle);
        }

        public Box generateBox()
        {
            string randomName = Names[rnd.Next(Names.Count)];
            int randomDestinationNumber = rnd.Next(1, 13);
            return new Box(randomName, randomDestinationNumber);
        }
    }
}