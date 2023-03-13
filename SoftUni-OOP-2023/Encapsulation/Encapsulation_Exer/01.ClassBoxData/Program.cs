using System;

namespace ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());

                Box box = new Box(a, b, c);

                Console.WriteLine(box);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
          

           
        }
    }
}
