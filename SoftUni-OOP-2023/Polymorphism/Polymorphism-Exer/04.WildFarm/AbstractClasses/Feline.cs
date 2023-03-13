using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.AbstractClasses
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, int foodEaten, string region, string breed) : base(name, weight, foodEaten, region)
        {
            Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

    }
}
