using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setize = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLength = setize[0];
            int secondSetLength = setize[1];

            HashSet<int> firstOne = new HashSet<int>();
            HashSet<int> secondOne = new HashSet<int>();

            for (int i = 0; i < firstSetLength; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstOne.Add(num);

            }
            for (int i = 0; i < secondSetLength; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondOne.Add(num);

            }
            firstOne.IntersectWith(secondOne);
            Console.WriteLine(string.Join(' ', firstOne));
        }
    }
}
