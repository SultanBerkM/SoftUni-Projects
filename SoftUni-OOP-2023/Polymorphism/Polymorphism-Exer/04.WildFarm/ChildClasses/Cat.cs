using _04.WildFarm.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.ChildClasses
{
    public class Cat : Feline, ISoundable
    {
        public Cat(string name, double weight, int foodEaten, string region, string breed) : base(name, weight, foodEaten, region, breed)
        {
        }

        public string Sound()
        {
            return "Meow";
        }
    }
}
