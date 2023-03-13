using System;
using System.Collections.Generic;

namespace _06.FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<IBuyer> buyers = new List<IBuyer>();

          

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ',
              StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 3)
                {
                    IBuyer rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    buyers.Add(rebel);
                }
                else if (input.Length == 4)
                {
                    IBuyer citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    buyers.Add(citizen);
                }

                
            }

            string names = Console.ReadLine();

            while (names != "End")
            {
                foreach (var people in buyers)
                {
                    if (people.Name == names)
                    {
                        people.BuyFood();
                    }
                }
                names = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
