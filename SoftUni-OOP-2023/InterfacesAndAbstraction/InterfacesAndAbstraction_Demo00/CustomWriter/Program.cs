using System;

namespace CustomWriter
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWritable write = new ConsoleWriter();

            Line line = new Line(write);

            line.Draw(10);



        }
    }
}
