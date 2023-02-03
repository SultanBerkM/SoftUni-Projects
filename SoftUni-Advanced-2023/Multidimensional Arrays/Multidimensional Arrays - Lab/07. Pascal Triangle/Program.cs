using System;

namespace _07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[n][];

            jaggedArr[0] = new int[1];

            for (int rows = 1; rows < jaggedArr.Length; rows++)
            {
                int[] arr = new int[rows + 1];
            }






















            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int k = 0; k < jaggedArr[i].Length; k++)
                {
                    Console.Write($"{jaggedArr[i][k]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
