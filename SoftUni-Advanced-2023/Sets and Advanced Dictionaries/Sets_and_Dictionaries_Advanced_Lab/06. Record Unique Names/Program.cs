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
            HashSet<string> namesLists = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                namesLists.Add(name);

            }
            foreach (var item in namesLists)
            {
                Console.WriteLine(item);
            }
        }
    }
}
