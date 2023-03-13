using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> raidGroup = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                BaseHero hero = null;

                if (heroType == nameof(Druid))
                {
                    hero = new Druid(heroName);
                }
                else if (heroType == nameof(Paladin))
                {
                    hero = new Paladin(heroName);
                }
                else if (heroType == nameof(Rogue))
                {
                    hero = new Rogue(heroName);
                }
                else if (heroType == nameof(Warrior))
                {
                    hero = new Warrior(heroName);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                    continue;
                }

                raidGroup.Add(hero);
            }

            int bossPower = int.Parse(Console.ReadLine());
            int heroTotalPower = 0;

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
                heroTotalPower += hero.Power;
            }

            Output(bossPower, heroTotalPower);
        }

        private static void Output(int bossPower, int heroTotalPower)
        {
            if (heroTotalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
