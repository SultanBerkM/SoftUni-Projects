using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_AdvancedDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Trim().Split(" -> ");
                string[] clothing = input[1].Split(',');

                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe.Add(input[0], new Dictionary<string, int>());
                }
                for (int k = 0; k < clothing.Length; k++)
                {
                    if (!wardrobe[input[0]].ContainsKey(clothing[k]))
                    {
                        wardrobe[input[0]].Add(clothing[k], 0);
                    }
                    wardrobe[input[0]][clothing[k]]++;
                }
            }
            string[] extraCommand = Console.ReadLine().Trim().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                if (extraCommand[0] == color.Key)
                {
                    foreach (var clothing in color.Value)
                    {
                        if (extraCommand[1] == clothing.Key)
                        { Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)"); }
                        else
                        {
                            Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                        }
                    }

                }
                else
                {

                    foreach (var clothing in color.Value)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }

            }
        }
    }
}
