using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string command1 = string.Empty;
            while ((command1 = Console.ReadLine()) != "Tournament")
            {
                string[] pokemonInformation = command1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonInformation[0];
                string pokemonName = pokemonInformation[1];
                string pokemonElement = pokemonInformation[2];
                int pokemonHealth = int.Parse(pokemonInformation[3]);

                Trainer trainer = trainers.SingleOrDefault(t => t.Name == trainerName);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                
                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                    trainer.PokemonList.Add(pokemon);
                }
                else
                {
                    trainer.PokemonList.Add(pokemon);
                }
                
            }

            string command2 = string.Empty;
            while ((command2 = Console.ReadLine()) != "End")
            {
                switch (command2)
                {
                    case "Fire":
                        CheckAndRemovePokemons(trainers, command2);
                        break;
                    case "Water":
                        CheckAndRemovePokemons(trainers, command2);
                        break;
                    case "Electricity":
                        CheckAndRemovePokemons(trainers, command2);
                        break;
                    default:
                        break;
                }
            }

            PrintByNumberOfBadges(trainers);
        }

        public static void PrintByNumberOfBadges(List<Trainer> trainers)
        {
            foreach (var item in trainers.OrderByDescending(item => item.NumberOfBadges))
            {
                Console.WriteLine($"{item.Name} {item.NumberOfBadges} {item.PokemonList.Count}");
            }
        }

        public static void CheckAndRemovePokemons(List<Trainer> trainers, string command2)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.PokemonList.Any(p => p.Element == command2))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    for (int i = 0; i < trainer.PokemonList.Count; i++)
                    {
                        trainer.PokemonList[i].Health -= 10;
                    }
                    trainer.PokemonList.RemoveAll(p => p.Health <= 0);
                }
            }
        }
    }
}
