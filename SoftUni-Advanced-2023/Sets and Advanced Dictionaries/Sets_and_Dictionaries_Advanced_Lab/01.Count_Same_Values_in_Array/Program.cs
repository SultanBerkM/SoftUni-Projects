using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split()
                 .Select(double.Parse).ToArray();

            var dictionary = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!dictionary.ContainsKey(array[i]))
                {
                    dictionary.Add(array[i], 0);
                }

                dictionary[array[i]] += 1;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
