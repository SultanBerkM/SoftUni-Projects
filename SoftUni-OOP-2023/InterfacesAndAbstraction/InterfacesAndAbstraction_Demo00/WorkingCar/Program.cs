using System;

namespace WorkingCar
{
   public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 2, 350, "CW2020K");
            IDrivable car2 = new Car("BMW", 2, 350, "CW2020K");
            IEngine car3 = new Car("BMW", 2, 350, "CW2020K");

            car3.HowItWorks();
            car2.Start();
            car2.Stop();
        }
    }
}
