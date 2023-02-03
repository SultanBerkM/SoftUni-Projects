using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Cars> garage = new List<Cars>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(' ',
                     StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1Km = double.Parse(carInfo[2]);

                Cars car = new Cars(model, fuelAmount, fuelConsumptionFor1Km);

                garage.Add(car);
               
            }
            string[] instructions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (instructions[0] != "End")
            {
                string currentModel = instructions[1];
                int drivingKm = int.Parse(instructions[2]);

                foreach (var auto in garage)
                {
                    if (auto.Model == currentModel)
                    {
                        Cars currentCar = auto;

                        currentCar.MovingCar(currentModel, drivingKm);

                        break;
                    }
                }
                instructions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            }
            foreach (var auto in garage)
            {
                Console.WriteLine($"{auto.Model} {auto.FuelAmount:f2} {auto.TravelledDistance}");
            }
        }
    }
}
