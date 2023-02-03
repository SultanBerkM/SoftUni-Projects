using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var markets = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ");

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!markets.ContainsKey(shop))
                {
                    markets.Add(shop, new Dictionary<string, double>());
                }
                markets[shop].Add(product, price);

                input = Console.ReadLine().Split(", ");
            }

            foreach (var shoppy in markets)
            {
                Console.WriteLine($"{shoppy.Key}->");
                foreach (var product in shoppy.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

        }
    }
}
