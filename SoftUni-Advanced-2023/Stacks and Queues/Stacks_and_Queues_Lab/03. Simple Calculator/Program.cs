using System;
using System.Collections.Generic;

namespace Stakove
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(' ');

            Stack<string> digits = new Stack<string>();

            int sum = 0;

            for (int j = expression.Length - 1; j >= 0; j--)
            {
                digits.Push(expression[j]);
            }
            while (digits.Count > 1)
            {
                int firstNum = int.Parse(digits.Pop());
                char sign = char.Parse(digits.Pop());
                int secNum = int.Parse(digits.Pop());
                if (sign == '+')
                {
                    sum = secNum + firstNum;

                }
                else if (sign == '-')
                {
                    sum = firstNum - secNum;
                }
                digits.Push(sum.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
