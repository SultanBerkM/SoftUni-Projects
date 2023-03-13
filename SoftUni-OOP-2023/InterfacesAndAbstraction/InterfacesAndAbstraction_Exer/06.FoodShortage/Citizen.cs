﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoodShortage
{
    public class Citizen :  IBuyer
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

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }

        public string Print()
        {
            return $"{this.Birthday}";
        }
    }
}
