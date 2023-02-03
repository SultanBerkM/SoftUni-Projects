using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split()
                 .Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < clothesInBox.Length; i++)
            {
                stack.Push(clothesInBox[i]);
            }
            int rackCapacity = int.Parse(Console.ReadLine());
            int current = rackCapacity;
            int cnt = 1;
            while (stack.Count != 0)
            {
                current = current - stack.Peek();
                if (current < 0)
                {
                    cnt++;
                    current = rackCapacity;
                }
                else
                {
                    stack.Pop();
                }

            }
            Console.WriteLine(cnt);
        }
    }
}
