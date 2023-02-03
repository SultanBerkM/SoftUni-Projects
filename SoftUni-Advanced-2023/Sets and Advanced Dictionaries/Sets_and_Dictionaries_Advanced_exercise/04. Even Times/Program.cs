using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> integers = new Dictionary<int, int>();
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!integers.ContainsKey(number))
                {
                    integers.Add(number, counter);
                }
                else
                {
                    integers[number] += 1;
                }
            }
            foreach (var item in integers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
