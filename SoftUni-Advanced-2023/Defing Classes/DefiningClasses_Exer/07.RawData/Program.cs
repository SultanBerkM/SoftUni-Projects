using System;
using System.Collections.Generic;

namespace _07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> garage = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);

                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);

                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);

                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                
                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                garage.Add(car);
            }

            string command = Console.ReadLine();
            List<Car> print = new List<Car>();

            if (command == "flammable")
            {
                foreach (var item in garage)
                {
                    if (item.Engine.Power > 250 && item.Cargo.Type == "flammable")
                    {
                        print.Add(item);

                    }
                }
               
            }
            else if (command == "fragile")
            {
                foreach (var item in garage)
                {
                    foreach (var tyres in item.Tires)
                    {
                        if (tyres.Pressure < 1 && item.Cargo.Type == "fragile")
                        {
                            print.Add(item);
                            break;
                        }
                    }
                                          
                   
                }
            }
            

            foreach (var auto in print)
            {
                Console.WriteLine($"{auto.Model}");
            }
           
        }
    }
}
