using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine(c.Draw());

            Rectangle r = new(3, 3);
            Console.WriteLine(r.Draw());

            Shape shape = new Circle(3);
            Console.WriteLine(shape.Draw());
        }
    }
}
