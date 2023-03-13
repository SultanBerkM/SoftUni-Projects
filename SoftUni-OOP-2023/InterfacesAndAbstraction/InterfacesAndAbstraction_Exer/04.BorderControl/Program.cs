using System;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ID> allCreatures = new List<ID>();

            string[] input = Console.ReadLine().Trim().Split();

            while (input[0] != "End")
            {
                if (input.Length == 2)
                {
                    Robot robot = new Robot(input[0], input[1]);
                    allCreatures.Add(robot);
                }
                else if (input.Length == 3)
                {
                    Citizen citizen = new Citizen(input[0], int.Parse(input[1]), input[2]);
                    allCreatures.Add(citizen);
                }

                input = Console.ReadLine().Trim().Split();
            }

            string names = Console.ReadLine();

           

            
        }
    }
}
