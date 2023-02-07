using System;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string trainerName)
        {
            PokemonList = new List<Pokemon>();
            Name = trainerName;

        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> PokemonList { get; set; }


    }
}
