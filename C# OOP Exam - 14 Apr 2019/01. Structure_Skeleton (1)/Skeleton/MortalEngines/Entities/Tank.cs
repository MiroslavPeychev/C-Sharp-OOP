namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;

    public class Tank : BaseMachine, ITank
    {
        private const int InitialHealthPoints = 100;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleDefenseMode();

        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode == true)
            {
                this.DefenseMode = false;

                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.DefenseMode = true;

                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            var result = DefenseMode == false ? "OFF" : "ON";

            return base.ToString() + Environment.NewLine + $" *Defense: {result}";
        }
    }
}
