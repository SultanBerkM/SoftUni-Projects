using System;
using System.Collections.Generic;

namespace Stakove
{
    class Program
    {
        static void Main(string[] args)
        {
            int cars = int.Parse(Console.ReadLine());
            Queue<string> allCars = new Queue<string>();
            
            int counter = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                if (command == "green")
                {
                    for (int i = 0; i < cars; i++)
                    {
                        if (allCars.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine(allCars.Dequeue() + " passed!");
                        counter++;
                    }


                    continue;
                }

                allCars.Enqueue(command);
            }
            Console.WriteLine(counter + " cars passed the crossroads.");
        }
    }
}
