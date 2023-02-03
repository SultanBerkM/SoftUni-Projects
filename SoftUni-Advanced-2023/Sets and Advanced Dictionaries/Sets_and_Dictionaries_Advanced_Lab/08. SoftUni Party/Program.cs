using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                guests.Add(input);
                input = Console.ReadLine();
            }
            string secInput = Console.ReadLine();

            while (secInput != "END")
            {
                if (guests.Contains(secInput))
                {
                    guests.Remove(secInput);
                }
                secInput = Console.ReadLine();
            }
            Console.WriteLine(guests.Count);
            //guests = guests.OrderBy(x => x).ToHashSet();
            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
