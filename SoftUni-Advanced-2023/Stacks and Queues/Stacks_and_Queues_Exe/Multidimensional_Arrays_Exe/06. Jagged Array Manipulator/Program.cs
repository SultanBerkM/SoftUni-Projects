using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedArr = new double[n][];

            for (int i = 0; i < n; i++)
            {
                double[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jaggedArr[i] = arr;
            }
            int length = jaggedArr.Length;
            for (int i = 0; i < length-1; i++)
            {
                if (jaggedArr[i].Length == jaggedArr[i + 1].Length)
                {
                    for (int k = 0; k < jaggedArr[i].Length; k++)
                    {
                        jaggedArr[i][k] = jaggedArr[i][k] * 2;
                        jaggedArr[i + 1][k] = jaggedArr[i + 1][k] * 2;
                    }
                }
                else
                {
                    for (int k = 0; k < jaggedArr[i].Length; k++)
                    {
                        jaggedArr[i][k] = jaggedArr[i][k] / 2;
                    }
                    for (int k = 0; k < jaggedArr[i+1].Length; k++)
                    {
                        jaggedArr[i + 1][k] = jaggedArr[i+1][k] / 2;
                    }
                }
            }
                  

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }
                string operation = command[0];
                int givenRow = int.Parse(command[1]);
                int givenColumn = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (operation == "Add")
                {
                    if (givenRow < 0 || givenColumn < 0)
                    {
                        continue;
                    }
                    if (jaggedArr.Length > givenRow && jaggedArr[givenRow].Length > givenColumn)
                    {
                        jaggedArr[givenRow][givenColumn] += value;
                    }
                }
                else if (operation == "Subtract")
                {
                    if (givenRow < 0 || givenColumn < 0)
                    {
                        continue;
                    }
                    if (jaggedArr.Length > givenRow && jaggedArr[givenRow].Length > givenColumn)
                    {
                        jaggedArr[givenRow][givenColumn] -= value;
                    }
                }
                
            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int k = 0; k < jaggedArr[i].Length; k++)
                {
                    Console.Write(jaggedArr[i][k] + " ");
                }
                Console.WriteLine();
            }
        }
    } 
}
