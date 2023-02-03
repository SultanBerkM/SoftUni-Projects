using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string colors;

        public string Color
        {
            get { return colors; }
            set { colors = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Car()
        {
            this.Weight = 0;
            this.Color = null;
        }

        public Car(string model, Engine engine, int weight, string colors):this()
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = colors;
        }
    }
}
