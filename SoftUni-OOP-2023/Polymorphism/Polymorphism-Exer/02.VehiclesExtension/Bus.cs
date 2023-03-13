using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Bus : Vehicle
    {
        private const double AirConsumptionBus = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionLPerKm, double tankCpacity)
            : base(fuelQuantity, fuelConsumptionLPerKm, tankCpacity)
        {
           
        }

        public override void Drive(double km)
        {

            double expense = km * (FuelConsumptionLPerKm + AirConsumptionBus);

            Driving(km, expense);
        }
               

        public void DriveEmpty(double km)
        {

            double expense = km * FuelConsumptionLPerKm;

            Driving(km, expense);
        }
        public override void Refuel(double litters)
        {
            FuelValitator(litters);
             
            double fuel = litters;
            if (FuelQuantity + fuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
            }
            else
            {
                FuelQuantity += fuel;
            }
            
        }

        private void Driving(double km, double expense)
        {
            if (FuelQuantity - expense >= 0)
            {
                FuelQuantity -= expense;
                Console.WriteLine($"Bus travelled {km} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }

    }
}
