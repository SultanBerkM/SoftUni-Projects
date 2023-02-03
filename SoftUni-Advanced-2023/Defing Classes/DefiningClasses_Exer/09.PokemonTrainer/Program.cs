using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string[] input = Console.ReadLine().Trim().Split();
                if (input[0] == "Tournament")
                {
                    break;
                }

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);


                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                foreach (var item in trainers)
                {
                    if (item.Name == trainerName)
                    {
                        item.CollectionOfPokemons.Add(pokemon);
                        flag = true;
                        break;
                    }

                }
                if (flag)
                {
                    flag = false;
                    continue;
                }

                Trainer trainer = new Trainer(trainerName, pokemon);

                trainers.Add(trainer);
                

            }
          
            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    for (int i = 0; i < trainer.CollectionOfPokemons.Count; i++)
                    {
                        if (trainer.CollectionOfPokemons[i].Element == command)
                        {
                            trainer.Badges++;
                            break;
                        }
                        else
                        {
                            trainer.CollectionOfPokemons[i].Health -= 10;

                            if (trainer.CollectionOfPokemons[i].Health <= 0)
                            {
                                trainer.CollectionOfPokemons.Remove(trainer.CollectionOfPokemons[i]);
                            }
                        }
                    }
                    //command = Console.ReadLine();
                }
                command = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(b => b.Badges).ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.CollectionOfPokemons.Count}");
            }
        }
    }
}
