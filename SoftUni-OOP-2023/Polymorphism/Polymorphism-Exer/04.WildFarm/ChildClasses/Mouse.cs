using _04.WildFarm.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.ChildClasses
{
    public class Mouse : Pet, ISoundable
    {
        public Mouse(string name, double weight, int foodEaten, string region) : base(name, weight, foodEaten, region)
        {
        }

        public string Sound()
        {

            return "Squeak";
        }

       
    }
}
