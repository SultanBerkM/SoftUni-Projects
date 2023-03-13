using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirConsumptionTruck = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionLPerKm, double tankCpacity)
            : base(fuelQuantity, fuelConsumptionLPerKm, tankCpacity)
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
            FuelValitator(litters);

            double fuel = litters - litters * 0.05;

            if (FuelQuantity + fuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel;
            }
        }
    }
}
