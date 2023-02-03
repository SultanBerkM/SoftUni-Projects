using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialCars
{
    class Engine
    {
        private int hoursePower;
        private double cubicCapacity;

        public int HorsePower
        {
            get { return this.hoursePower; }
            set { this.hoursePower = value; }
        }

        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            set { this.cubicCapacity = value; }
        }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;

        }
    }
}
