using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> collection = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person(input[0], input[1], int.Parse(input[2]));

                collection.Add(person);

            }

            collection = collection.OrderBy(c => c.FirstName).ThenBy(a => a.Age).ToList();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
