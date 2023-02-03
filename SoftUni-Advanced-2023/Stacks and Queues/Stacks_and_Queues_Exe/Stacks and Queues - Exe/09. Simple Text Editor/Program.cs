using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> oldStrings = new Stack<string>();
            oldStrings.Push(string.Empty);

            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string[] operations = Console.ReadLine().Split(' ', 
                    StringSplitOptions.RemoveEmptyEntries);

                if (operations[0] == "1")
                {
                    string append = operations[1];
                    text+=append;

                    oldStrings.Push(text);
                }
                else if (operations[0] == "2")
                {
                    int erasingCnt = int.Parse(operations[1]);
                    text = text.Remove(text.Length - erasingCnt, erasingCnt);

                    oldStrings.Push(text);
                }
                else if (operations[0] == "3")
                {
                    int indexReturn = int.Parse(operations[1]);
                    Console.WriteLine(text[indexReturn-1]);

                    //oldStrings.Push(string.Empty);
                }
                else if (operations[0] == "4")
                {
                    oldStrings.Pop();
                    text = oldStrings.Pop();

                    oldStrings.Push(string.Empty);
                }
            }
            
        }
        
    }
}
