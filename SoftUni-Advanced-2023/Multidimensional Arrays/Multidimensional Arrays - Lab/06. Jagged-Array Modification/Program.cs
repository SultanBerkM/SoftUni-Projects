using System;
using System.Linq;

namespace matrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            string[] instructions = Console.ReadLine().Split();
            while (instructions[0] != "END")
            {
                string command = instructions[0];
                int row = int.Parse(instructions[1]);
                int col = int.Parse(instructions[2]);
                int value = int.Parse(instructions[3]);

                if (command == "Add")
                {
                    if (row < 0 || row >= jaggedArray.Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else if (col < 0 || col >= jaggedArray[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    if (row < 0 || row >= jaggedArray.Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else if (col < 0 || col >= jaggedArray[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
                instructions = Console.ReadLine().Split();
            }
            foreach (int[] item in jaggedArray)
            {
                Console.WriteLine(string.Join(' ', item));
            }
        }
    }
}
