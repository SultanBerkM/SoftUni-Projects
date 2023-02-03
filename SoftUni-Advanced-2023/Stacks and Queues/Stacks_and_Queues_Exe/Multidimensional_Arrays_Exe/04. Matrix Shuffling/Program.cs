using System;
using System.Linq;

namespace Matrices_Softuni_EXE4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Trim().Split()
                .Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] dataLine = Console.ReadLine().Trim().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = dataLine[col];
                }
            }

            string[] input = Console.ReadLine().Trim().Split();

            while (input[0] != "END")
            {
                string command = input[0];

                switch (command)
                {
                    case "swap":
                        if (input.Length == 5)
                        {
                            int row1 = int.Parse(input[1]);
                            int col1 = int.Parse(input[2]);

                            int row2 = int.Parse(input[3]);
                            int col2 = int.Parse(input[4]);

                            if (row1 < matrix.GetLength(0) && col1 < matrix.GetLength(1)
                           && row2 < matrix.GetLength(0) && col2 < matrix.GetLength(1)
                           && row1 >= 0 && col1 >= 0 && row2 >= 0 && col2 >= 0 && input.Length == 5)
                            {
                                string currentDigit = matrix[row1, col1];
                                matrix[row1, col1] = matrix[row2, col2];
                                matrix[row2, col2] = currentDigit;

                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }



                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int h = 0; h < matrix.GetLength(1); h++)
                            {
                                Console.Write(matrix[i, h] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;

                }

                input = Console.ReadLine().Trim().Split();


            }

        }
    }
}
