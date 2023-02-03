using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Predicate_Party_
{
    class Program
    {
        static bool Checker(string filter, string word, string text)
        {
            switch (filter)
            {
                case "StartsWith": return text.StartsWith(word);
                case "EndsWith": return text.EndsWith(word);
                case "Length": return text.Length == int.Parse(word);

            }
            return false;
        }
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Trim().
                Split().ToList();

            List<string> instructions = Console.ReadLine().Trim().
               Split().ToList();


            Func<List<string>, string, string, List<string>> addingOperation = (guestList, filter, word) =>
            {
                List<string> output = new List<string>();

                foreach (var name in names)
                {
                    if (Checker(filter, word, name))
                    {
                        output.Add(name);
                        output.Add(name);
                    }
                    else
                    {
                        output.Add(name);
                    }
                }
                names = output;
               
                return names;
            };

            Func<List<string>, string, string, List<string>> removingOperation = (guestList, filter, word) =>
            {

                for (int i = 0; i < names.Count; i++)
                {
                    if (Checker(filter, word, names[i]))
                    {
                        names.Remove(names[i]);
                    }
                }
                  
                
                return names;
            };

            while (instructions[0] != "Party!")
            {
                string mainCom = instructions[0];

                if (mainCom == "Remove")
                {
                    names = removingOperation(names, instructions[1], instructions[2]);
                }
                else if (mainCom == "Double")
                {
                    names = addingOperation(names, instructions[1], instructions[2]);
                }

                instructions = Console.ReadLine().Trim().
               Split().ToList();
            }


            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
        }


    }
}
