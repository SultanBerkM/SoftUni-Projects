using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Person p = new Person();
            p.Name = "Berk";

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);

        }
    }
}
