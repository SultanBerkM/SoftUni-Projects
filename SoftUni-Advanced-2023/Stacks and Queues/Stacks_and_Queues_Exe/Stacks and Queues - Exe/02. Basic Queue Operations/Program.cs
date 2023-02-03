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
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int add = commands[0];
            int remove = commands[1];
            int search = commands[2];

            Queue<int> berk = new Queue<int>();

            for (int i = 0; i < add; i++)
            {
                berk.Enqueue(tokens[i]);
            }
            for (int i = 0; i < remove; i++)
            {
                berk.Dequeue();
            }
            if (berk.Contains(search))
            {
                Console.WriteLine("true");
            }
            else if (berk.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(berk.Min());
            }

        }
    }
}
