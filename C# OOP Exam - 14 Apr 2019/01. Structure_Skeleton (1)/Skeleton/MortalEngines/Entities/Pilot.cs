namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pilot : IPilot
    {
        private string name;

        private IList<IMachine> machines;


        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }
        
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException($"Pilot name cannot be null or empty string.");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine== null)
            {
                throw new NullReferenceException($"Null machine cannot be added to the pilot.");
            }

            machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} - {this.machines.Count} machines");
            foreach (var machine in machines)
            {
                sb.AppendLine($"- {machine.Name}");
                sb.AppendLine($" *Type: {this.GetType().Name}");
                sb.AppendLine($" *Health: {machine.HealthPoints}");
                sb.AppendLine($" *Attack: {machine.AttackPoints}");
                sb.AppendLine($" *Defense: {machine.DefensePoints}");
                sb.AppendLine($" *Targets: {(machine.Targets.Count == 0 ? "None" : string.Join(",", machine.Targets))}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
