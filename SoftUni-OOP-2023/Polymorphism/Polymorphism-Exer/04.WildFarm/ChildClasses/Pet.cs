using _04.WildFarm.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.ChildClasses
{
    public class Pet : Mammal
    {
        public Pet(string name, double weight, int foodEaten, string region) : base(name, weight, foodEaten, region)
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
