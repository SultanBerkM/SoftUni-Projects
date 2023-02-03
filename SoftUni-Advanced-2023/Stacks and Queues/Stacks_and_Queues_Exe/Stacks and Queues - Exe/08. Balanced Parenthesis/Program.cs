using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();
            if (parenthesis.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            Stack<char> front = new Stack<char>();

            for (int i = parenthesis.Length - 1; i >= 0; i--)
            {
                front.Push(parenthesis[i]);
            }
            bool flag = false;
            for (int i = 0; i < parenthesis.Length / 2; i++)
            {
                if (parenthesis[i] == '{')
                {
                    front.Pop();
                    for (int j = 0; j < parenthesis.Length; j++)
                    {
                        char current = parenthesis[j];
                        if (parenthesis[j] == '}')
                        {
                            //front.Pop();
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                }
                else if (parenthesis[i] == '(')
                {
                    front.Pop();
                    for (int j = 0; j < parenthesis.Length; j++)
                    {
                        if (parenthesis[j] == ')')
                        {
                            //front.Pop();
                            flag = true;
                        }
                    }

                    if (!flag)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (parenthesis[i] == '[')
                {
                    front.Pop();
                    for (int j = 0; j < parenthesis.Length; j++)
                    {
                        if (parenthesis[j] == ']')
                        {
                            //front.Pop();
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
