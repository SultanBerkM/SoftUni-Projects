using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!symbols.ContainsKey(text[i]))
                {
                    symbols.Add(text[i], 0);
                }
                symbols[text[i]]++;
            }
            foreach (var item in symbols)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
