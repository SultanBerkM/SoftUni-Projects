using System;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            Vehicle vehicle = default;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[1] == "Car")
                {
                    vehicle = car;
                }
                else if (command[1] == "Truck")
                {
                    vehicle = truck;
                }


                if (command[0] == "Drive")
                {
                    vehicle.Drive(double.Parse(command[2]));
                }
                else if (command[0] == "Refuel")
                {
                    vehicle.Refuel(double.Parse(command[2]));
                }


            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");

        }
    }
}
