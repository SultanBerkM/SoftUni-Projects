using System;
using System.Linq;

namespace Matrices_SofTuni_EXE1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int primaryDiogonalSum = 0;
            int secondaryDiogonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] lineData = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = lineData[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primaryDiogonalSum += matrix[row, col];
                    }
                }

            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secondaryDiogonalSum += matrix[row, matrix.GetLength(0) - row - 1];

            }
            Console.WriteLine(Math.Abs(primaryDiogonalSum - secondaryDiogonalSum));


        }
    }
}
