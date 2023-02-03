using System;
using System.Collections.Generic;
using System.Linq;

namespace Matrices_Softuni_EXE4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            string originalSnake = string.Empty;

            Stack<string> snakeChars = new Stack<string>();

            for (int i = snake.Length - 1; i >= 0; i--)
            {
                snakeChars.Push(snake[i].ToString());

            }

            int rows = size[0];
            int cols = size[1];
            string[,] matrix = new string[rows, cols];

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                counter++;
                if (counter % 2 != 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeChars.Pop();
                        if (snakeChars.Count == 0)
                        {
                            for (int i = snake.Length - 1; i >= 0; i--)
                            {
                                snakeChars.Push(snake[i].ToString());

                            }
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeChars.Pop();
                        if (snakeChars.Count == 0)
                        {
                            for (int i = snake.Length - 1; i >= 0; i--)
                            {
                                snakeChars.Push(snake[i].ToString());

                            }
                        }
                    }
                }

            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int h = 0; h < matrix.GetLength(1); h++)
                {
                    Console.Write(matrix[i, h]);
                }
                Console.WriteLine();
            }





        }
    }
}
