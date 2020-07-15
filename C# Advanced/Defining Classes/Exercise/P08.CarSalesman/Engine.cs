namespace P08.CarSalesman
{
    using System;
    using System.Text;

    public class Engine
    {
        private const string DefaultValueString = "n/a";
        private const int DefaultValueInt = -1;

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid model. Model cannot be null or white space!");
                }

                this.model = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Power must be a positive number");
                }

                this.power = value;
            }
        }

        public int? Displacement { get; set; }
       
        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid efficiency. Efficiency cannot be null or white space!");
                }

                this.efficiency = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string displacementStr = this.Displacement.HasValue ? this.Displacement.ToString() : "n/a";
            string efficiencyStr = String.IsNullOrEmpty(this.Efficiency) ?
                "n/a" : this.Efficiency;

            sb
                .AppendLine($"{this.Model}:")
                .AppendLine($"    Power: {this.Power}")
                .AppendLine($"    Displacement: {displacementStr}")
                .AppendLine($"    Efficiency: {efficiencyStr}");

            return sb.ToString().TrimEnd();
        }
    }
}