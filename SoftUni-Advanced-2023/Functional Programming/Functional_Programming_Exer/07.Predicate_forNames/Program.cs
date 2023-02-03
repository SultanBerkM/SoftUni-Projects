using System;
using System.Collections.Generic;

namespace _07.Predicate_forNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Trim().Split();

            Predicate<string> filter = (string allNames) => allNames.Length <= n;
           
            Action<string[], Predicate<string>> specializeNames = (name, filterInAct) =>
            {
                
                foreach (var item in names)
                {
                    if (filterInAct(item))
                    {
                        Console.WriteLine(item);                                                           
                    }
                }
               
            };
            specializeNames(names, filter);
          


          

        }
    }
}
