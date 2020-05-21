namespace MortalEngines.Entities
{
    using System.Collections.Generic;
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Text;

    public abstract class BaseMachine : IMachine
    {
        private string name;

        private IPilot pilot;

        private IList<string> targets;

        protected BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"Machine name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException($"Pilot cannot be null.");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get
            {
                return this.targets;
            }
        }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException($"Target cannot be null");
            }

            if (target.HealthPoints - (AttackPoints - target.DefensePoints) > 0)
            {
                target.HealthPoints -= AttackPoints - target.DefensePoints;
            }
            else
            {
                target.HealthPoints = 0;
            }

            targets.Add(target.Name);

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"- {this.Name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Health: {this.HealthPoints:F2}");
            sb.AppendLine($" *Attack: {this.AttackPoints:F2}");
            sb.AppendLine($" *Defense: {this.DefensePoints:F2}");
            sb.AppendLine($" *Targets: {(targets.Count == 0 ? "None" : string.Join(",", targets))}");

            return sb.ToString().TrimEnd();
        }
    }
}
