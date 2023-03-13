using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConsumptionCar = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionLPerKm, int tankCpacity)
            : base(fuelQuantity, fuelConsumptionLPerKm, tankCpacity)
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
            FuelValitator(litters);

            double fuel = litters;

            if (FuelQuantity + fuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel;
            }
        }
    }
}
