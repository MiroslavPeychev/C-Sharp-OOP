namespace PlayersAndMonsters.Models.Cards
{
    using PlayersAndMonsters.Models.Cards.Contracts;
    using System;

    public abstract class Card : ICard
    {
        private string name;
        private int damegePoints;
        private int healthPoints;
        public Card(string name, int damagePoints, int healthPoints)
        {
            this.Name = name;
            this.DamagePoints = damagePoints;
            this.HealthPoints = healthPoints;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string.");
                }

                this.name = value;
            }
        }

        public int DamagePoints
        {
            get
            {
                return this.damegePoints;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's damage points cannot be less than zero.");
                }

                this.damegePoints = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            private set
            {
                if (value<0)
                {
                    this.healthPoints = 0;
                    throw new ArgumentException("Card's HP cannot be less than zero.");
                }

                this.healthPoints = value;
            }
        }
    }
}
