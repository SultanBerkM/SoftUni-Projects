using System;
using System.Collections.Generic;

namespace _05.SpecialCars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> yearTires = new();
            List<double> pressure = new();
            string[] tyreInfoRaw = Console.ReadLine().Split();

            while (tyreInfoRaw[0] != "No")
            {
                for (int i = 1; i <= tyreInfoRaw.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        yearTires.Add(int.Parse(tyreInfoRaw[i]));
                    }
                    else
                    {
                        pressure.Add(double.Parse(tyreInfoRaw[i]));
                    }

                }
                Tire[] tires = new Tire[4];
                for (int i = 0; i < tyreInfoRaw.Length / 2; i++)
                {
                    new Tire(yearTires[i], pressure[i]);
                }
            }

            string[] engineInfoRaw = Console.ReadLine().Split();
            while (engineInfoRaw[0] != "Engine")
            {
                int hp = int.Parse(engineInfoRaw[0]);
                double cubicCap = double.Parse(engineInfoRaw[1]);

                Engine engine = new Engine(hp, cubicCap);
                

                engineInfoRaw = Console.ReadLine().Split();
            }

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            //1. save the given information
            //2. put them into classes with array
            //3. Load the props
            //4. Read the inf about the cars

        }
    }
}
