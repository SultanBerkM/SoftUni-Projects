using System;
using System.Collections.Generic;
using System.Linq;

namespace Stakove
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] data = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int pushCount = data[0];
            int popCount = data[1];
            int seekingNum = data[2];

            int[] dataInput = new int[pushCount];
            dataInput = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();

            for (int i = 0; i < pushCount; i++)
            {
                stack.Push(dataInput[i]);
            }
            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(seekingNum))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }


        }
    }
}
