using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoodShortage
{
    public interface IBuyer
    {
        public void BuyFood();

        public string Name { get; }
        public int Food { get;}
    }
}
