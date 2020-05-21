namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;

    public class Fighter : BaseMachine, IFighter
    {
        private const int InitialHealthPoints = 200;
        
        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleAggressiveMode();
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode == true)
            {
                this.AggressiveMode = false;

                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
            else
            {
                this.AggressiveMode = true;

                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
        }

        public override string ToString()
        {
            var result = AggressiveMode == false ? "OFF" : "ON";

            return base.ToString() + Environment.NewLine + $" *Aggressive: {result}";
        }
    }
}
