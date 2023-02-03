using System;

namespace Fileds
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students();
            student.FirstName = "Berk";
            student.SecondName = "Mehmed";
            Console.WriteLine(student.FullName); 
        }
    }
}
