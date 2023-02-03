using System;
using System.Collections.Generic;

namespace ListsInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Students1 studentBerk = new Students1()
            {
                FirstName = "BerK",
                Courses = new List<Courses1>()
            };

            studentBerk.Courses.Add(new Courses1()
            {
                NickName = "C# Advanced",
                StartingDate = DateTime.Now,
                EndingDate = DateTime.Now.AddDays(60),
                Lecturer = "Viktor Dakov"
            }) ;

            studentBerk.Courses.Add(new Courses1()
            {
                NickName = "C# OOP",
                StartingDate = DateTime.Now.AddDays(60),
                EndingDate = DateTime.Now.AddDays(200),
                Lecturer = "Svetlin Nakov"
            });


            Printer(studentBerk);
              
        }
        static void Printer(Students1 student)
        {
            Console.WriteLine($"{student.FirstName}");
            foreach (var item in student.Courses)
            {
                Console.WriteLine(item.NickName);
                Console.WriteLine(item.StartingDate);
                Console.WriteLine(item.EndingDate);
                Console.WriteLine(item.Lecturer);
            }
            
        }
    }
}
