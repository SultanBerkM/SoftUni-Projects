using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingCar
{
    public interface IVehicle
    {
        public string Made { get; }

        public int Age { get; }

        public int HoursePower { get; }

        public string Registers { get; }
    }
}
