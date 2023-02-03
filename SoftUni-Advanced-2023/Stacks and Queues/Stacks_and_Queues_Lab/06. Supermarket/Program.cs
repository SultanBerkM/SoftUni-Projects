using System;
using System.Collections.Generic;

namespace Stakove
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            //string name = Console.ReadLine();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End")
                {
                    break;
                }
                customers.Enqueue(name);
                if (name == "Paid")
                {
                    while (customers.Count > 1)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                    customers.Clear();
                }





            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
