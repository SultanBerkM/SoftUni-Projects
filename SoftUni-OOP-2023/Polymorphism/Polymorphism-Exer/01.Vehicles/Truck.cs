using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConsumptionTruck = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionLPerKm) 
            : base(fuelQuantity, fuelConsumptionLPerKm)
        {
           
        }

        public override void Drive(double km)
        {
            double expense = km * (FuelConsumptionLPerKm + AirConsumptionTruck);

            if (FuelQuantity - expense >= 0)
            {
                FuelQuantity -= expense;
                Console.WriteLine($"Truck travelled {km} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void Refuel(double litters)
        {
            double fuel = litters - litters * 0.05;
            FuelQuantity += fuel;
        }
    }
}
