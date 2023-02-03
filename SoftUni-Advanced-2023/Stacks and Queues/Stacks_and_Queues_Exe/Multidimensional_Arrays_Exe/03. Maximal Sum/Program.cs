using System;
using System.Linq;

namespace Matrices_Softuni_EXE2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixeSize = Console.ReadLine().Split()
                 .Select(int.Parse).ToArray();
            int rows = matrixeSize[0];
            int cols = matrixeSize[1];

            int maxValue = int.MinValue;
            int sum = 0;

            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] dataLine = Console.ReadLine().Trim().Split()
                .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = dataLine[col];
                }
            }

            int[,] copyMatrix = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxValue)
                    {
                        maxValue = sum;

                        copyMatrix[0, 0] = matrix[row, col];
                        copyMatrix[0, 1] = matrix[row, col + 1];
                        copyMatrix[0, 2] = matrix[row, col + 2];
                        copyMatrix[1, 0] = matrix[row + 1, col];
                        copyMatrix[1, 1] = matrix[row + 1, col + 1];
                        copyMatrix[1, 2] = matrix[row + 1, col + 2];
                        copyMatrix[2, 0] = matrix[row + 2, col];
                        copyMatrix[2, 1] = matrix[row + 2, col + 1];
                        copyMatrix[2, 2] = matrix[row + 2, col + 2];

                    }
                }
            }
            Console.WriteLine("Sum = " + maxValue);
            for (int i = 0; i < copyMatrix.GetLength(0); i++)
            {
                for (int h = 0; h < copyMatrix.GetLength(0); h++)
                {
                    Console.Write(copyMatrix[i, h] + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
