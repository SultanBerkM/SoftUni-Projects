using System;
using System.Collections.Generic;
using System.Linq;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = PrintUpper => PrintUpper[0] == char.ToUpper(PrintUpper[0]);

            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Where(PrintUpper => predicate(PrintUpper)).ToArray();
            Array.ForEach(arr, a => Console.WriteLine(a));

        }


    }
}
