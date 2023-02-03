using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackLab_sOFTuNI
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < commandsCount; i++)
            {
                int[] command = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    stack.Push(command[1]);

                }
                else if (command[0] == 2)
                {
                    if (stack.Count != 0)
                        stack.Pop();
                }
                else if (command[0] == 3)
                {
                    if (stack.Count != 0)
                        Console.WriteLine(stack.Max());


                }
                else if (command[0] == 4)
                {
                    if (stack.Count != 0)
                        Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));

        }
    }
}
