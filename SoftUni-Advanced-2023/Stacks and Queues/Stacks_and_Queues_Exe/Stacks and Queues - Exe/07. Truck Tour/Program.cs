using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<List<int>> routeInf = new Queue<List<int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> information = Console.ReadLine().Split()
               .Select(int.Parse).ToList();
                information.Add(i);
               
                routeInf.Enqueue(information);
            }
            

            List<int> gasStation = new List<int>();
            int sumFuel = 0;

            int theRealg = 0;
            bool isTrue = true;

            while(routeInf.Count != 0)
            {
                
                gasStation = routeInf.Dequeue();

                int fuel = gasStation[0];
                int distance = gasStation[1];
                int currentIndex = gasStation[2];

                sumFuel += fuel - distance; 

                if (sumFuel < 0)
                {
                    routeInf.Enqueue(gasStation);
                    sumFuel = 0;

                }
                else
                {
                    theRealg = currentIndex;

                    Queue<List<int>> routeInf2 = new Queue<List<int>>();
                    routeInf2 = routeInf;

                    while (routeInf2.Count != 0)
                    {
                        List<int> gasStation2 = new List<int>();
                        gasStation2 = routeInf2.Dequeue();

                        int fuel2 = gasStation2[0];
                        int distance2 = gasStation2[1];
                        int currentIndex2 = gasStation2[2];

                        sumFuel += fuel2 - distance2;

                        if (sumFuel < 0)
                        {
                            isTrue = false;
                            sumFuel = 0;
                            break;

                        }
                    }
                    if (isTrue)
                    {
                        Console.WriteLine(theRealg);
                        return;
                    }
                }
               
            }
            Console.WriteLine(theRealg);
        }
    }
}

