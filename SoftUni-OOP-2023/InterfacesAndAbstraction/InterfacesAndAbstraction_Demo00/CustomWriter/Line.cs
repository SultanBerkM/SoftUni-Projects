using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWriter
{
    public class Line
    {
        public IWritable write;
        public Line(IWritable write)
        {
            this.write = write;
        }
        public void Draw(int length)
        {
            for (int i = 0; i < length; i++)
            {
                write.WriteLine('|');
            }
        }
    }
}
