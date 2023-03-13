using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInput = Console.ReadLine().Split();
                Pizza pizza = new Pizza(pizzaInput[1]);

                string[] input = Console.ReadLine().Split();

                while (input[0] != "END")
                {
                    if (input[0] == "Dough")
                    {
                        Dough dough = new Dough(input[1], input[2], double.Parse(input[3]));
                        pizza.Dough = dough;
                    }
                    else if (input[0] == "Topping")
                    {
                        Topping topping = new Topping(input[1], double.Parse(input[2]));
                        pizza.AddTopping(topping);
                    }

                    input = Console.ReadLine().Split();
                }

                Console.WriteLine(pizza.SumOfCalories()); 
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return;
            }
           
        }
    }
}
