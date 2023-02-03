using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool engineFlag = false;
            bool carFlag = false;

            List<Engine> listOfEngines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());
            int displacement = 0;
            string efficiency = string.Empty;

            int weight = 0;
            string color = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                if (engineInfo.Length >= 3)
                {
                    if (engineFlag = int.TryParse(engineInfo[2], out displacement))
                    {

                    }
                    else
                    {
                        efficiency = engineInfo[2];
                    }

                }
                if (engineInfo.Length == 4)
                {
                    efficiency = engineInfo[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                listOfEngines.Add(engine);

                displacement = 0;
                efficiency = string.Empty;
            }

            int m = int.Parse(Console.ReadLine());
            List<Car> garage = new List<Car>();
            for (int i = 0; i < m; i++)
            {

                string[] carInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                string carEngine = carInfo[1];

                if (carInfo.Length >= 3)
                {
                    if (carFlag = int.TryParse(carInfo[2], out weight))
                    {

                    }
                    else
                    {
                        color = carInfo[2];
                    }

                }
                if (carInfo.Length == 4)
                {
                    color = carInfo[3];
                }

                foreach (var eng in listOfEngines)
                {
                    if (eng.Model == carEngine)
                    {
                        Car car = new Car(carModel, eng, weight, color);
                        garage.Add(car);

                        weight = 0;
                        color = string.Empty;
                        break;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (var car in garage)
            {
                sb.AppendLine(car.Model + ":");
                sb.AppendLine(" " + car.Engine.Model + ":");
                sb.AppendLine("  Power: " + car.Engine.Power);

                if (car.Engine.Displacement == 0)
                    sb.AppendLine("  Displacement: " + "n/a");
                else
                    sb.AppendLine("  Displacement: " + car.Engine.Displacement);

                if (car.Engine.Effiviency == null || car.Engine.Effiviency == string.Empty)
                    sb.AppendLine("  Efficiency: " + "n/a");
                else
                    sb.AppendLine("  Efficiency: " + car.Engine.Effiviency);

                if (car.Weight == 0)
                    sb.AppendLine(" Weight: " + "n/a");
                else
                    sb.AppendLine(" Weight: " + car.Weight);

                if (car.Color == null || car.Color == string.Empty)
                    sb.AppendLine(" Color: " + "n/a");
                else
                    sb.AppendLine(" Color: " + car.Color);
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
