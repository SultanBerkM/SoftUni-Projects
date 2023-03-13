using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings = new List<Topping>();
        private Dough dough;

        public Pizza(string name)
        {
            this.Name = name;
        }
        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public List<Topping> Toppings
        {
            get { return toppings; }
            set
            {
                if (value.Count > 10 || value.Count < 0 )
                {
                    throw new Exception("Number of toppings should be in range [0..10].");
                }
                toppings = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count < 10)
            {
                toppings.Add(topping);
            }
            else
            {
                throw new Exception("Number of toppings should be in range [0..10].");
               
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == string.Empty || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public string SumOfCalories()
        {
            double sum = 0;
            sum = dough.DoughCalories();

            foreach (var top in toppings)
            {
                sum += top.ToppingCalories();
            }

            return $"{this.Name} - {sum:f2} Calories.";
        }


    }
}
