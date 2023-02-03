using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            listOfNumbers = listOfNumbers.OrderByDescending(x => x)
                .Take(3)
                .ToList();
            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}