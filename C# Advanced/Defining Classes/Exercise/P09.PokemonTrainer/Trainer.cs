namespace P09.PokemonTrainer
{
    using System;
    using System.Collections.Generic;

    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid name. Name cannot be null or white space!");
                }

                this.name = value;
            }
        }

        public int NumberOfBadges
        {
            get
            {
                return this.numberOfBadges;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Invalid number of badges. Number of badges must be a positive number");
                }

                this.numberOfBadges = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

        public bool ContainsType(string element)
        {
            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.Element == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void DecreaseHealth()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Pokemon currentPokemon = Pokemons[i];
                int defaultHealthDecreacingPoints = 10;

                if (currentPokemon.Health - defaultHealthDecreacingPoints > 0)
                {
                    currentPokemon.Health -= defaultHealthDecreacingPoints;
                }
                else
                {
                    Pokemons.Remove(currentPokemon);
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.NumberOfBadges} {this.Pokemons.Count}";
        }
    }
}