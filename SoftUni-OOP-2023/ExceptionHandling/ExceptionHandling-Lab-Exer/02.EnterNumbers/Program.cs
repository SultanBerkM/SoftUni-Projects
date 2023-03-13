using System;
using System.Collections.Generic;

namespace _02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentChecker = 1;
            List<int> list = new();
            for (int i = 0; i < 10; i++)
            {
                try
                {

                    int number;


                    try
                    {
                        number = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        i--;
                        throw new ArgumentException("Invalid Number!");
                    }

                    if (number > currentChecker && number < 100)
                    {
                        currentChecker = number;
                    }
                    else
                    {
                        i--;
                        throw new ArgumentException($"Your number is not in range {currentChecker} - 100!");
                    }

                    list.Add(number);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);

                }

            }


            Console.WriteLine(string.Join(", ", list));

        }


    }
}
