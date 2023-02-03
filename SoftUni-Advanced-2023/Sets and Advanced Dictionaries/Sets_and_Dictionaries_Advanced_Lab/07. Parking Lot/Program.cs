using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ",
                StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> parkedCars = new HashSet<string>();

            while (input[0] != "END")
            {
                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                {
                    parkedCars.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    parkedCars.Remove(carNumber);
                }
                input = Console.ReadLine().Split(", ",
               StringSplitOptions.RemoveEmptyEntries);
            }
            if (parkedCars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in parkedCars)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
