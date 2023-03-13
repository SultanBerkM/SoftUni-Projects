using System;
using System.Collections.Generic;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthday> allCreatures = new List<IBirthday>();

            //string[] input = Console.ReadLine().Trim().Split();

            while (true)
            {
               string[] input = Console.ReadLine().Trim().Split();

                if (input[0] == "End")
                {
                    break;
                }
                else if (input[0] == "Pet")
                {
                    IBirthday pet = new Pet(input[1], input[2]);
                    allCreatures.Add(pet);
                }
                else if (input[0] == "Citizen")
                {
                    IBirthday citizen = new Citizen(input[1], int.Parse(input[2]), input[3], input[4]);
                    allCreatures.Add(citizen);
                }
                else if(input[0] == "Robot")
                {
                    continue;
                }

               
            }

            string year = Console.ReadLine();
            allCreatures.RemoveAll(i => !i.Birthday.EndsWith(year));

            foreach (var id in allCreatures)
            {
                Console.WriteLine(id.Print());
            }
        }
    }
}
