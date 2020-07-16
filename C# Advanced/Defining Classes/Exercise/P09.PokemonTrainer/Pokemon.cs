namespace P09.PokemonTrainer
{
    using System;

    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
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

        public string Element
        {
            get
            {
                return this.element;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid element. Element cannot be null or white space!");
                }

                this.element = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Invalid health. Please, enter value between zero and 100");
                }

                this.health = value;
            }
        }
    }
}