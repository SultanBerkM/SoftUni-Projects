using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWriter
{
    public interface IWritable
    {
        public void WriteLine(object text);
        public void Write(object text);
    }
}
