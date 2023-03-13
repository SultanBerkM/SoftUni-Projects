using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingCar
{
    public class Car : IDrivable, IVehicle, IEngine
    {
        public Car(string model, int age, int hp, string number)
        {
            Made = model;
            Age = age;
            HoursePower = hp;
            Registers = number;
        }
        public string Made { get; private set; }
        public int Age { get; private set; }
        public int HoursePower { get; private set; }
        public string Registers { get; private set; }

        public void HowItWorks()
        {
            Console.WriteLine("The engine works very simple!");
        }

        public void Start()
        {
            Console.WriteLine("Starting the car...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the car...");
        }
    }
}
