using System;
using System.Linq;

namespace _05.PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            
            
               
        }

        

        private static void IndexValidator(int[] array, int elementOne)
        {
            if (elementOne > array.Length)
            {
                throw new Exception("The index does not exist!");
            }
        }
    }
}
