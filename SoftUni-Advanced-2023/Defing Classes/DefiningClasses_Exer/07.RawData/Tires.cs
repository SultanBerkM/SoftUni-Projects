using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    class Tires
    {
        private int year;
        private double pressure;

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

    }
}
