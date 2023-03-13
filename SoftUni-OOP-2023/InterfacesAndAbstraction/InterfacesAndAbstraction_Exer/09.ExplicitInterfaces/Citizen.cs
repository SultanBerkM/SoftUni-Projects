﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Country { get; private set; }

        void IResident.GetName()
        {
            Console.WriteLine("Mr/Ms/Mrs " + this.Name);
        }
        void IPerson.GetName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
