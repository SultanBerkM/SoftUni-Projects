using System;

namespace _05.DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string end = Console.ReadLine();

            int result = DateModifier.DateModifier1(start, end);
            Console.WriteLine(result);
        }
    }
}
