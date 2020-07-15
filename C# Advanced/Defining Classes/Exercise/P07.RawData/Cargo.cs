namespace P07.RawData
{
    using System;

    public class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Invalid weight. Weight must be a positive number!");
                }

                this.weight = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid type. Type cannot be null or white space!");
                }

                this.type = value;
            }
        }
    }
}