using System;

namespace ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);

            
            while (info[0] != "End")
            {
               
                Citizen citizen = new(info[0], info[1], int.Parse(info[2]));

                IPerson person = citizen;
                IResident resident = citizen;

                person.GetName();
                resident.GetName();


                info = Console.ReadLine().Split(' ',
                StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
