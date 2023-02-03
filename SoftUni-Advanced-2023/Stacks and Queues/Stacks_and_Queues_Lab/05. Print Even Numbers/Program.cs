using System;
using System.Collections.Generic;

namespace Stakove
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            var nums = Console.ReadLine().Split();
            Queue<int> evenNums = new Queue<int>();
            foreach (var item in nums)
            {
                numbers.Enqueue(int.Parse(item));
            }
            int count = numbers.Count;
            for (int i = 0; i < count; i++)
            {
                if (numbers.Peek() % 2 != 0)
                {
                    numbers.Dequeue();
                }
                else
                {
                    evenNums.Enqueue(numbers.Dequeue());
                }
            }
            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
