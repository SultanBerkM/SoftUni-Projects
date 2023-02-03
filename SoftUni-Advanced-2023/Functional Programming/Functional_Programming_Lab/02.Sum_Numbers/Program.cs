using System;
using System.Collections.Generic;
using System.Linq;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
             .Split(", ")
             .Select(x => int.Parse(x))
             .ToArray();

            Console.WriteLine(array.Length);
            Console.WriteLine(Adding(array));

        }
        static int Adding(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
