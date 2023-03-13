using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BladeKnight knight = new BladeKnight("Berk", 12);

            Console.WriteLine(knight);
        }
    }
}