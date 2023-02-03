using System;
using System.Linq;

namespace matrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixSize = Console.ReadLine().Split(", ");
            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);

            int[,] matrix = new int[rows, cols];

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(", ");

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                    sum += int.Parse(rowData[col]);
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
