using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackLab_sOFTuNI
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
            int toss = int.Parse(Console.ReadLine());
            int i = 0;
            while (kids.Count > 1)
            {
                i++;
                if (i == toss)
                {
                    string name = kids.Dequeue();
                    i = 0;
                    Console.WriteLine($"Removed {name}");
                }
                else
                {
                    string name = kids.Dequeue();
                    kids.Enqueue(name);
                }

            }
            foreach (var item in kids)
            {
                Console.WriteLine("Last is " + item);
            }



        }
    }
}
