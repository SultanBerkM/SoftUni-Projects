using _04.WildFarm.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.ChildClasses
{
    public class Owl : Bird, ISoundable
    {
        public Owl(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
        }

        public string Sound()
        {
            return "Hoot Hoot";
        }

       
    }
}
