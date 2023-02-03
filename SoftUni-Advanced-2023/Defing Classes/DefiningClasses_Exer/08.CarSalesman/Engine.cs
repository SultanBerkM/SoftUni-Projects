using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string effiviency;

        public string Effiviency
        {
            get { return effiviency; }
            set { effiviency = value; }
        }


        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine()
        {
            this.Displacement = 0;
            this.Effiviency = null;
        }

        public Engine(string model, int power, int displacement, string effiviency) : this()
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Effiviency = effiviency;
        }
    }
}
