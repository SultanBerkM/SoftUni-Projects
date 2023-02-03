using System;
using System.Linq;

namespace matrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;

            int[,] squareMatrix = new int[rows, cols];

            int sum = 0;
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                string[] lineData = Console.ReadLine().Split();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = int.Parse(lineData[col]);
                    if (row == col)
                    {
                        sum += squareMatrix[row, col];
                    }
                }
            }
            Console.WriteLine(sum);

        }
    }
}
