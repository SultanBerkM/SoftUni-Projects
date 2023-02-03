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

            var info = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!info.ContainsKey(continent))
                {
                    info.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!info[continent].ContainsKey(country))
                {
                    info[continent].Add(country, new List<string>());
                }
                info[continent][country].Add(city);
            }

            foreach (var continent in info)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"   {country.Key} -> {string.Join(", ", country.Value)} ");

                }
            }
        }
    }
}
