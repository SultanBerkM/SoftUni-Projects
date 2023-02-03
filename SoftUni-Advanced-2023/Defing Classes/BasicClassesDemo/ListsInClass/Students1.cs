using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsInClass
{
    class Students1
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        public double AverageGrade { get; set; }

        public List<Courses1> Courses { get; set; }

        public void AddCourses(Courses1 course)
        {
            Courses.Add(course);

        }
    }
}
