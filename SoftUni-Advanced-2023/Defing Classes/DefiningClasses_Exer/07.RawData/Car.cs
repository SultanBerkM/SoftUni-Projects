using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    class Car
    {
        private string model;
        private Tires[] tires = new Tires[4];
        private Engine engine;
        private Cargo cargo;

        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }


        public Tires[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age,
            double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine { Speed = engineSpeed, Power = enginePower };
            this.Cargo = new Cargo { Weight = cargoWeight, Type = cargoType };

            this.Tires[0] = new Tires { Year = tire1Age, Pressure = tire1Pressure };
            this.Tires[1] = new Tires { Year = tire2Age, Pressure = tire2Pressure };
            this.Tires[2] = new Tires { Year = tire3Age, Pressure = tire3Pressure };
            this.Tires[3] = new Tires { Year = tire4Age, Pressure = tire4Pressure };

        }

    }
}
