using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string favouritFood, string name) : base(favouritFood, name)
        {
        }
        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}{Environment.NewLine}DJAAF";
        }
    }
}
