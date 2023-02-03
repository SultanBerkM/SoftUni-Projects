using System;
using System.Linq;

namespace matrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(", ");

            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            int[,] matrix = new int[rows, cols];
            int[] sumOfColums = new int[cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }

            for (int c = 0; c < cols; c++)
            {
                int sum = 0;
                for (int r = 0; r < rows; r++)
                {
                    sum += matrix[r, c];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
