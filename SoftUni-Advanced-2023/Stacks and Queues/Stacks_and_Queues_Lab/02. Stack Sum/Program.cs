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
            Stack<int> integerStack = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray());

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] operation = command.Split();
                switch (operation[0])
                {
                    case "add":
                        int firstNum = int.Parse(operation[1]);
                        int secondNum = int.Parse(operation[2]);

                        integerStack.Push(firstNum);
                        integerStack.Push(secondNum);
                        break;
                    case "remove":
                        int removingCount = int.Parse(operation[1]);
                        if (removingCount <= integerStack.Count)
                        {
                            for (int i = 0; i < removingCount; i++)
                            {
                                integerStack.Pop();
                            }
                        }
                        break;

                }


                command = Console.ReadLine().ToLower();

            }
            Console.WriteLine("Sum: " + integerStack.Sum());
        }
    }
}
