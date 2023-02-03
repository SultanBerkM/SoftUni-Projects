using System;
using System.Collections.Generic;
using System.Linq;

namespace Demos
{
    class Program
    {
        static double[] TwentyUp(double[] arr, Func<double, double> filter)
        {
            List<double> edited = new List<double>();
            for (int i = 0; i < arr.Length; i++)
            {
                edited.Add(filter(arr[i]));
            }
            return edited.ToArray();
        }
        static void Main(string[] args)
        {
            Func<double, double> twentyUp = d => d + d * 0.20;

            double[] arr = Console.ReadLine()
                .Split(", ",
                StringSplitOptions.RemoveEmptyEntries)
                .Select((x) => double.Parse(x))
                .ToArray();

            double[] editedArr = TwentyUp(arr, twentyUp);

            foreach (var item in editedArr)
            {
                Console.WriteLine($"{item:f2}");
            }



        }


    }
}
