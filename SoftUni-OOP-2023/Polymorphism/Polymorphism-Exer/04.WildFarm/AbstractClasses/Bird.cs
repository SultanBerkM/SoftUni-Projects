﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WildFarm.AbstractClasses
{
    public abstract class Bird : Animal
    {
        protected Bird(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
