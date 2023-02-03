using System;

namespace DefiningClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carBerk = new Car()
            {
                Year = DateTime.Now,
                Model = "Audi",
                Type = "Rs6",
            };

            Students studentBerk = new Students();
            studentBerk.FirstName = "Berk";
            studentBerk.SecondName = "Mehmed";
            studentBerk.Age = 15;
            studentBerk.AverageGrade = 5.90;
            studentBerk.eachStudentCar = carBerk;
            //studentBerk.eachStudentCar.Model = "Audi";
            //studentBerk.eachStudentCar.Type = "Rs6";
            //studentBerk.eachStudentCar.Year = DateTime.Now;


            Students studentGosho = new Students()
            {
                FirstName = "Georgi",
                SecondName = "Georgiev",
                Age = 15,
                AverageGrade = 5.40
            };
            Car carGosho = new Car()
            {
                Year = DateTime.UtcNow,
                Model = "Lada",
                Type = "Niva",
            };
            Print(studentBerk, carBerk);
            Console.WriteLine("=======");
            Print(studentGosho, carGosho);

            Console.WriteLine("-------------------");
            Console.WriteLine(studentBerk.FirstName);
            Console.WriteLine(studentBerk.SecondName);
            Console.WriteLine($"His car model and type is {studentBerk.eachStudentCar.Model}/{studentBerk.eachStudentCar.Type} and it is produced {studentBerk.eachStudentCar.Year:Y}");

        }

        static void Print(Students students, Car car)
        {
            Console.WriteLine(students.FirstName);
            Console.WriteLine(students.SecondName);
            Console.WriteLine(students.Age);
            Console.WriteLine(students.AverageGrade);
            Console.WriteLine($"His car model and type is {car.Model}/{car.Type} and it is produced {car.Year:Y}");
        }
    }
}
