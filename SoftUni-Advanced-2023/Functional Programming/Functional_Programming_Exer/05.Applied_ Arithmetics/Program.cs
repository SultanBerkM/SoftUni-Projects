using System;
using System.Linq;

namespace _05.Applied__Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            Func<int[], string, int[]> operation = (inputArr, command) =>
             {
                 switch (command)
                 {
                     case "add":
                         for (int i = 0; i < inputArr.Length; i++)
                         {
                             inputArr[i] = inputArr[i] + 1;
                         }
                         return inputArr; 
                     case "multiply":
                         for (int i = 0; i < inputArr.Length; i++)
                         {
                             inputArr[i] = inputArr[i] *2 ;
                         }
                         return inputArr;
                     case "subtract":
                         for (int i = 0; i < inputArr.Length; i++)
                         {
                             inputArr[i] = inputArr[i] - 1;
                         }
                         return inputArr;
                 }
                 return inputArr;
             };
            while (input != "end")
            {
                if (input == "print")
                {
                     Console.WriteLine(string.Join(' ', arr));
                }
                else
                {
                    arr = operation(arr, input);
                }
                input = Console.ReadLine();
            }
            //Console.WriteLine(string.Join(" ", arr));
        }

    }
}
