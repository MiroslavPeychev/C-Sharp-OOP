using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security;

namespace Animals
{
    public class Engine
    {
        private const string END_OF_INPUT_COMMANDS = "Beast!";
        private readonly List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {


            string type;
            while ((type = Console.ReadLine()) != END_OF_INPUT_COMMANDS)
            {
                string[] animalArgs = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                Animal animal;

                try
                {
                    animal = GetAnimal(type, animalArgs);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
                
                this.animals.Add(animal);
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (Animal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string type, string[] animalArgs)
        {
            string name = animalArgs[0];
            int age = int.Parse(animalArgs[1]);
            string gender = GetGender(animalArgs);

            Animal animal = null;

            if (type == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (type == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (type == "Kitten")
            {
                animal = new Kitten(name, age, gender);
            }
            else if (type == "TomCat")
            {
                animal = new Kitten(name, age, gender);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }

            return animal;
        }

        private string GetGender(string[] animalArgs)
        {
            string gender = null;

            if (animalArgs.Length >= 3)
            {
                gender = animalArgs[2];
            }

            return gender;
        }
    }
}
