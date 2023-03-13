using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConsumptionCar = 0.9;
        public Car(double fuelQuantity, double fuelConsumptionLPerKm)
            : base(fuelQuantity, fuelConsumptionLPerKm)
        {
            
        }

        public override void Drive(double km)
        {
            double expense = km * (FuelConsumptionLPerKm + AirConsumptionCar);

            if (FuelQuantity - expense >= 0)
            {
                FuelQuantity -= expense;
                Console.WriteLine($"Car travelled {km} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public override void Refuel(double litters)
        {
            double fuel = litters;
            FuelQuantity += fuel;
        }
    }
}
