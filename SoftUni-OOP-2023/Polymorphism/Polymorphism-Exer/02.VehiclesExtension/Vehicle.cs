using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double tankCapacity;
              
        protected Vehicle(double fuelQuantity, double fuelConsumptionLPerKm, double tankCpacity)
        {
            if (fuelQuantity > tankCpacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }
          
            FuelConsumptionLPerKm = fuelConsumptionLPerKm;
            TankCapacity = tankCpacity;
        }

        public double FuelQuantity { get;  set; }
        public double FuelConsumptionLPerKm { get;  set; }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                tankCapacity = value; 
            }
        }

        public abstract void Drive(double km);
        public abstract void Refuel(double litters);

        protected void FuelValitator(double gasilineLitters)
        {
            if (gasilineLitters <= 0)
            {
                throw new Exception("Fuel must be a positive number");
            }
        }

    }
}
