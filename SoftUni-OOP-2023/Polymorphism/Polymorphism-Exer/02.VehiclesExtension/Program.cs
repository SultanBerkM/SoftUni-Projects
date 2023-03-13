using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), int.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), int.Parse(truckInfo[3]));
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), int.Parse(busInfo[3]));

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
                else if (command[1] == "Bus")
                {
                    vehicle = bus;
                }


                try
                {
                    if (command[0] == "Drive")
                    {
                        vehicle.Drive(double.Parse(command[2]));
                    }
                    else if (command[0] == "Refuel")
                    {
                        vehicle.Refuel(double.Parse(command[2]));
                    }
                    else if (command[0] == "DriveEmpty")
                    {
                        if (vehicle is Bus vehicleBus)
                        {
                            vehicleBus.DriveEmpty(double.Parse(command[2]));
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");

        }
    }
}
