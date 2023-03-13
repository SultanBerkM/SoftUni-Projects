using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWriter
{
    public class ConsoleWriter : IWritable
    {
        public void Write(object text)
        {
            Console.Write(text);
        }

        public void WriteLine(object text)
        {
            Console.WriteLine(text);
        }
    }
}
