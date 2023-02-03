using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers
{
    class Members
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        public double AverageGrade { get; set; }

        public void Print()
        {
            Console.WriteLine($"{this.FirstName}");
        }
    }
}
