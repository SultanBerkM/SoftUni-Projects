using System;
using System.Linq;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int minVal = int.MinValue;
            //int result = 0;
            int[] intArr = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            Func<int[], int> smaller = s =>
            {
                foreach (var item in intArr)
                {
                    if (item > minVal)
                    {
                        minVal = item;
                    }
                }
                return minVal;
            };

            Console.WriteLine(smaller(intArr)); 
            

        }

        
        
    }
}
