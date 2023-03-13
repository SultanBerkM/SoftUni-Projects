using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BirthdayCelebrations
{
    public class Citizen : ID, IBirthday
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthday = birthday;
        }
        public string ID { get; private set;}
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Birthday { get; set; }

        public string Print()
        {
            return $"{this.Birthday}";
        }
    }
}
