using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SportCar bugatti = new SportCar(1400, 100);

            bugatti.Drive(1);

        }
    }
}
