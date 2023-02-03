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

            int counter = 0;

            string[,] charMatrix = new string[rows, cols];
            for (int row = 0; row < charMatrix.GetLength(0); row++)
            {
                string[] dataLine = Console.ReadLine().Split();
                //.Select(char.Parse).ToArray();

                for (int col = 0; col < charMatrix.GetLength(1); col++)
                {
                    charMatrix[row, col] = dataLine[col];
                }
            }
            {

                for (int row = 0; row < charMatrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < charMatrix.GetLength(1) - 1; col++)
                    {
                        if (charMatrix[row, col] == charMatrix[row, col + 1] &&
                            charMatrix[row, col] == charMatrix[row + 1, col] &&
                            charMatrix[row, col] == charMatrix[row + 1, col + 1])
                            counter++;
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
