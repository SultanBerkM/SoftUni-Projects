using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= end; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> dividerFilter = (d) =>//return true or false
            {
                foreach (var item in dividers)
                {
                    if (d % item != 0)
                    {
                        return false;
                    }
                }
                return true;
            };
            Func<Predicate<int>, List<int>, int[]> editedArr = (filter, nums) =>
            {
                List<int> editList = new List<int>();
                foreach (var item in nums)
                {
                    if (filter(item))
                    {
                        editList.Add(item);
                    }
                }
                return editList.ToArray();
            };

            int[] result = editedArr(dividerFilter, numbers);
            Console.WriteLine(string.Join(' ', result));
            
        }
    }
}
