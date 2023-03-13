using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    public class Robot : ID
    {
        public Robot(string model, string id)
        {
            Model = model;
            ID = id;
        }
        public string ID { get; private set; }
        public string Model { get; private set; }

        public string Print()
        {
            return $"{this.ID}";
        }
    }
}