using System;
using System.Collections.Generic;

namespace _04.OpinionPoll
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

            List<Person> people = family.GetOldestMembers();

            foreach (var item in people)
            {
                Console.WriteLine(item.Name + " - " + item.Age);
            }

        }
    }
}
