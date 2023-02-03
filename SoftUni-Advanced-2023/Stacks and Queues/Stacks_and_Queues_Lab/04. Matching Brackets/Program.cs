using System;
using System.Collections.Generic;

namespace Stakove
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            int endIndex = 0;
            string item = string.Empty;


            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int start = indexes.Pop();
                    endIndex = i - start;
                    item = expression.Substring(start, endIndex + 1);
                    Console.WriteLine(item);
                }

            }

        }
    }
}
