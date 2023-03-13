using System;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    throw new ArithmeticException();
                }
                Console.WriteLine(Math.Sqrt(n));
            }
            catch
            {
                Console.WriteLine("Invalid number.");

            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
