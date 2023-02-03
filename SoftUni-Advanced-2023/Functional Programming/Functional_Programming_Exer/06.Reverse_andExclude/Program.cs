using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Reverse_andExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divider = int.Parse(Console.ReadLine());

            Func<int[], int[]> leftOnes = (int[] l) =>
            {
                List<int> result = new List<int>();
                for (int i = 0; i < l.Length; i++)
                {
                    if (l[i] % divider != 0)
                    {
                        result.Add(l[i]);
                    }
                }
                return result.ToArray();
            };
            Func<int[], int[]> reversing = (int[] r) =>
            {
                List<int> reversed = new List<int>();
                for (int i = r.Length - 1; i >= 0; i--)
                {
                    reversed.Add(r[i]);
                }
                return reversed.ToArray();
            };

            int[] arrayEdited = reversing(leftOnes(arr));
            Console.WriteLine(string.Join(' ', arrayEdited));
           


        }

    }
}
