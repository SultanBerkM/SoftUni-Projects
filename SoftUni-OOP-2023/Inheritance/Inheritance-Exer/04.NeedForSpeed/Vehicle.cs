using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public virtual double DefaultFuelConsumption { get; set; }
        public  double FuelConsumption { get; set; }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;

            this.DefaultFuelConsumption = 1.25;
        }
        public virtual void Drive(double kilometers)
        {
            this.FuelConsumption = DefaultFuelConsumption;

            Fuel -= kilometers * FuelConsumption;
        }


    }
}
