﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BorderControl
{
    public class Citizen : ID
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            ID = id;
        }
        public string ID { get; private set;}
        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Print()
        {
            return $"{this.ID}";
        }
    }
}
