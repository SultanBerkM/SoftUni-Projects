using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.AbstractClasses
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight, int foodEaten, string region) : base(name, weight, foodEaten)
        {
            LivingRegion = region;
        }

        public string LivingRegion { get; set; }
      
    }
}
