using System;
using System.IO;
using System.Linq;

namespace TESTOVE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Join(", ",
                Console.ReadLine()
                .Split(", ")
                .Select((string x) => int.Parse(x))
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray()));
        }
    }
}