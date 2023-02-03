using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person2 = new Person(name, age);
          

            Console.WriteLine($"{person2.Name} - {person2.Age}");
           //1
        }
    }
}