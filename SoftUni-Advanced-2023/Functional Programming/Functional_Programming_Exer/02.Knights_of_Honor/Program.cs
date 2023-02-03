using System;

namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> addingHonor = (string[] n) => Array.ForEach(n, n => Console.WriteLine("Sir " + n));
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            addingHonor(names);
        }
    }
}
