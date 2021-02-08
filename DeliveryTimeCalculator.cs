using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPost
{
    class DeliveryTimeCalculator
    {
        public DeliveryTimeCalculator(Bundle bundle, int startingPlace)
        {
            this.bundle = bundle;
            this.startingPlace = startingPlace;
        }

        public Bundle bundle { get; set; }
        public int startingPlace { get; set; }

        public void findShortestPath()
        {
            int timeNeeded = 0;
            int currentLocation = startingPlace;

            List<Box> boxes = new List<Box>();
            var a = bundle.Boxes.OrderBy(box => box.Destination).ToLookup(x => x.Destination >= startingPlace);

            var greaterOrEqualThanStartingPlace = a[true].ToList();
            var lessThanStartingPlace = a[false].Reverse().ToList();

            boxes = greaterOrEqualThanStartingPlace.Concat(lessThanStartingPlace).ToList();


            foreach (var box in boxes)
            {
                if (box.Destination == currentLocation)
                {
                    timeNeeded += 1;
                }
                else if (box.Destination <= 6)
                {
                    timeNeeded += 6;
                }
                else if (box.Destination > 6)
                {
                    timeNeeded += 9;
                }

                currentLocation = box.Destination;
            }

            Console.WriteLine();
            Console.WriteLine($"Czas przejazdu: {timeNeeded} min");
            Console.WriteLine($"Kolejność: {new Bundle(boxes)}");
        }


    }
}