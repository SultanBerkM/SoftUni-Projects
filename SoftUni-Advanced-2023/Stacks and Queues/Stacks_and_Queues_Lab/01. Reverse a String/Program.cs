using System;
using System.Collections;
using System.Collections.Generic;

namespace StackLab_sOFTuNI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var reversedStrings = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                reversedStrings.Push(input[i]);
            }
            string output = string.Empty;
            int count = reversedStrings.Count;
            for (int i = 0; i < count; i++)
            {
                output += reversedStrings.Pop();
            }
            Console.WriteLine(output);
        }
    }
}
