using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ")
                 .Select(int.Parse).ToArray();

            int[,] matrix = new int[size[0], size[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
            int maxNum = int.MinValue;
            int[,] copyMatrix = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] > maxNum)
                    {
                        maxNum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        copyMatrix[row, col] = matrix[row, col];
                        copyMatrix[row, col + 1] = matrix[row, col + 1];
                        copyMatrix[row + 1, col] = matrix[row + 1, col];
                        copyMatrix[row + 1, col + 1] = matrix[row + 1, col + 1];
                    }
                }

            }
            Console.WriteLine(maxNum);
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    Console.WriteLine(copyMatrix + ", ");
                }
            }
        }
    }
}
