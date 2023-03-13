using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumptionLPerKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionLPerKm = fuelConsumptionLPerKm;
           
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumptionLPerKm { get; set; }
     

        public abstract void Drive(double km);
        public abstract void Refuel(double litters);
       
    }
}
