using System;

namespace _01.Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> returningNames = (string[] n) => Array.ForEach(n, n => Console.WriteLine(n));

            string[] names = Console.ReadLine().Split(' ',
                              StringSplitOptions.RemoveEmptyEntries);
            
            returningNames(names);


        }
        
    }
}
