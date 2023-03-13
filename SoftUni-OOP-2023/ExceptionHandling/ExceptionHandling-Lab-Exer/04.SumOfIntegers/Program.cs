using System;

namespace _04.SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] elements = Console.ReadLine().Split();
            int sum = 0;
            int current = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                try
                {
                    current =  Convert.ToInt32(elements[i]);
                }
                catch (FormatException)
                {
                    current = 0;
                    Console.WriteLine($"The element '{elements[i]}' is in wrong format!");
                }
                catch(OverflowException)
                {
                     current = 0;
                    Console.WriteLine($"The element '{elements[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{elements[i]}' processed - current sum: {sum += current}");
                }
                
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
