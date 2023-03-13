using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private string toppings;
        private double grams;

        public Topping(string topping, double grams)
        {
            this.Toppings = topping;
            this.Grams = grams;
        }
        public double Grams
        {
            get { return grams; }
            private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{this.Toppings} weight should be in the range [1..50].");
                } 
                grams = value; 
            }
        }

        public string Toppings
        {
            get { return toppings; }
            set 
            {
                if (value == "meat" || value == "Meat"
                    || value == "veggies" || value == "Veggies"
                    || value == "cheese" || value == "Cheese"
                    || value == "sauce"   || value == "Sauce")
                {
                    toppings = value;
                }
                else
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                
            }
        }
        public double ToppingCalories()
        {
            double toppingModifier = 0;
          

            if (this.Toppings == "meat" || this.Toppings == "Meat")
            {
                toppingModifier = 1.2;
            }
            else if (this.Toppings == "veggies" || this.Toppings == "Veggies")
            {
                toppingModifier = 0.8;
            }
            else if (this.Toppings == "cheese" || this.Toppings == "Cheese")
            {
                toppingModifier = 1.1;
            }
            else if (this.Toppings == "sauce" || this.Toppings == "Sauce")
            {
                toppingModifier = 0.9;
            }


            return 2 * (toppingModifier * this.Grams);
        }
    }
}
