using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            private set { salary = value; }
        }
        public Person(string firstName,string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.Age = age;
            this.LastName = lastName;
            this.Salary = salary;
        }

       
    }
}
