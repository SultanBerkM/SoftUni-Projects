using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.OldestFamilyMember
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person(name, age);

               family.AddMember(person);
                             
            }

            Person oldest = family.GetOldestMemebr();
            Console.WriteLine(oldest.Name + " " + oldest.Age);
            
            



        }
    }
}
