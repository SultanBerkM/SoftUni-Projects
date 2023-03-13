using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : AbstractClassCar, IElectricCar
    {
        public int Battery { get; }
       
        public Tesla(string model, string color, int batteries):base(model, color)
        {
           
            this.Battery = batteries;
        }
       

        public override string ToString()
        {
            return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries";

        }
    }
}
