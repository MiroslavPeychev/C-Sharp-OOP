namespace P09.PokemonTrainer
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            try
            {
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "Tournament")
                    {
                        break;
                    }

                    string[] tokens = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string trainerName = tokens[0];
                    string pokemonName = tokens[1];
                    string pokemonElement = tokens[2];
                    int pokemonHealth = int.Parse(tokens[3]);

                    Trainer currentTrainer = CreateTrainer(trainerName);
                    Pokemon currentPokemon = CreatePokemon(pokemonName, pokemonElement, pokemonHealth);

                    currentTrainer.Pokemons.Add(currentPokemon);

                    bool wasAdded = false;

                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Name == trainerName)
                        {
                            trainer.Pokemons.Add(currentPokemon);
                            wasAdded = true;
                            break;
                        }
                    }

                    if (!wasAdded)
                    {
                        trainers.Add(currentTrainer);
                    }
                }

                while (true)
                {
                    string secondInput = Console.ReadLine();

                    if (secondInput == "End")
                    {
                        break;
                    }

                    for (int i = 0; i < trainers.Count; i++)
                    {
                        Trainer currentTrainer = trainers[i];

                        if (currentTrainer.ContainsType(secondInput))
                        {
                            currentTrainer.NumberOfBadges++;
                        }
                        else
                        {
                            currentTrainer.DecreaseHealth();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }

            trainers = trainers.OrderByDescending(t => t.NumberOfBadges).ToList();

            foreach (Trainer trainer in trainers)
            {
                Console.WriteLine(trainer.ToString().TrimEnd());
            }
        }

        public static Trainer CreateTrainer(string name)
        {
            return new Trainer(name);
        }

        public static Pokemon CreatePokemon(string name, string element, int health )
        {
            return new Pokemon(name, element, health);
        }
    }
}