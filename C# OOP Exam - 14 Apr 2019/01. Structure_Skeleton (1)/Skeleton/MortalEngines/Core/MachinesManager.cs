namespace MortalEngines.Core
{
    using Contracts;
    using MortalEngines.Common;
    using MortalEngines.Entities;
    using MortalEngines.Entities.Contracts;
    using System.Collections.Generic;

    public class MachinesManager : IMachinesManager
    {
        private Dictionary<string, IPilot> pilots;

        private Dictionary<string, IMachine> machines;

        public MachinesManager()
        {
            this.pilots = new Dictionary<string, IPilot>();
            this.machines = new Dictionary<string, IMachine>();
        }

        public string HirePilot(string name)
        {
            if (!pilots.ContainsKey(name))
            {
                IPilot pilot = new Pilot(name);

                //pilots[name] = pilot;
                pilots.Add(name, pilot);

                return string.Format(OutputMessages.PilotHired, name);
            }

            return string.Format(OutputMessages.PilotExists, name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (!machines.ContainsKey(name))
            {
                ITank tank = new Tank(name, attackPoints, defensePoints);

                machines[name] = tank;

                var attackPointsNow = tank.AttackPoints;
                var defencePointsNow = tank.DefensePoints;

                return string.Format(OutputMessages.TankManufactured, name, attackPointsNow, defencePointsNow);
            }

            return string.Format(OutputMessages.MachineExists, name);
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (!machines.ContainsKey(name))
            {
                IFighter fighter = new Fighter(name, attackPoints, defensePoints);

                machines[name] = fighter;
                var mode = fighter.AggressiveMode == true ? "ON" : "OFF";
                var attackPointsNow = fighter.AttackPoints;
                var defencePointsNow = fighter.DefensePoints;


                return string.Format(OutputMessages.FighterManufactured, name, attackPointsNow, defencePointsNow, mode);
            }

            return string.Format(OutputMessages.MachineExists, name);
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            IPilot pilot = null;
            IMachine machine = null;

            if (!pilots.ContainsKey(selectedPilotName))
            {
                return string.Format(OutputMessages.PilotNotFound, selectedPilotName);
            }

            pilot = pilots[selectedPilotName];

            if (!machines.ContainsKey(selectedMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, selectedMachineName);
            }

            machine = machines[selectedMachineName];

            if (machine.Pilot != null)
            {
                return string.Format(OutputMessages.MachineHasPilotAlready, selectedMachineName);
            }

            pilot.AddMachine(machine);
            machine.Pilot = pilot;

            return string.Format(OutputMessages.MachineEngaged, selectedPilotName, selectedMachineName);

        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            IMachine attackingMachine = null;
            IMachine defendingMachine = null;

            if (!machines.ContainsKey(attackingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, attackingMachineName);
            }

            attackingMachine = machines[attackingMachineName];

            if (!machines.ContainsKey(defendingMachineName))
            {
                return string.Format(OutputMessages.MachineNotFound, defendingMachineName);
            }

            defendingMachine = machines[defendingMachineName];

            if (attackingMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, attackingMachineName);
            }

            if (defendingMachine.HealthPoints == 0)
            {
                return string.Format(OutputMessages.DeadMachineCannotAttack, defendingMachineName);
            }

            attackingMachine.Attack(defendingMachine);

            return string.Format(OutputMessages.AttackSuccessful, defendingMachineName, attackingMachineName, defendingMachine.HealthPoints);
        }

        public string PilotReport(string pilotReporting)
        {
            IPilot pilot = null;

            if (pilots.ContainsKey(pilotReporting))
            {
                pilot = pilots[pilotReporting];
            }

            return pilot.Report();
        }

        public string MachineReport(string machineName)
        {
            IMachine machine = null;

            if (machines.ContainsKey(machineName))
            {
                machine = machines[machineName];
            }

            return machine.ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            if (!machines.ContainsKey(fighterName))
            {
                return string.Format(OutputMessages.MachineNotFound, fighterName);
            }

            IFighter fighter = (IFighter)machines[fighterName];

            fighter.ToggleAggressiveMode();

            return string.Format(OutputMessages.FighterOperationSuccessful, fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            ITank tank = null;

            if (!machines.ContainsKey(tankName))
            {
                return string.Format(OutputMessages.MachineNotFound, tankName);
            }

            tank = (ITank)machines[tankName];

            tank.ToggleDefenseMode();

            return string.Format(OutputMessages.TankOperationSuccessful, tankName);
        }
    }
}