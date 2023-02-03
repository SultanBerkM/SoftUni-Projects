using System;
using System.Collections.Generic;

namespace _04.Find_EvensorOdds
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Trim().Split(" ");
            int lowerBound = int.Parse(arr[0]);
            int upperBound = int.Parse(arr[1]);

            List<int> collectionOfNum = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                collectionOfNum.Add(i);
            }

            string oddOrEven = Console.ReadLine();

            Func<List<int>, string, int[]> operation = Mathod;
            int[] returnedFinal = operation(collectionOfNum, oddOrEven);
            Console.WriteLine(string.Join(' ', returnedFinal));
        }

        private static int[] Mathod(List<int> list, string oddOrEven)
        {
            List<int> edited = new List<int>();

            if (oddOrEven == "odd")
            {
                foreach (var item in list)
                {
                    if (item % 2 != 0)
                    {
                        edited.Add(item);
                    }
                }
            }
            else if (oddOrEven == "even")
            {
                foreach (var item in list)
                {
                    if (item % 2 == 0)
                    {
                        edited.Add(item);
                    }
                }
            }
            return edited.ToArray();
        }
    }
}
