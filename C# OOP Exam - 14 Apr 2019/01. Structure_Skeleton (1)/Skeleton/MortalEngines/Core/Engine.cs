namespace MortalEngines.Core
{
    using MortalEngines.Core.Contracts;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.IO.Contracts;
    using System;

    public class Engine : IEngine
    {

        private IReader reader;
        private IWriter writer;
        private IMachinesManager machinesManager;

        public Engine(IReader reader, IWriter writer, IMachinesManager machinesManager)
        {
            this.reader = reader;
            this.writer = writer;
            this.machinesManager = machinesManager;
        }

        public void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine();

                if (input == "Quit")
                {
                    break;
                }

                try
                {
                    var splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    var command = splitted[0];
                    var name = splitted[1];
                    var message = string.Empty;

                    if (command == "HirePilot")
                    {
                        message = this.machinesManager.HirePilot(name);
                    }
                    else if (command == "PilotReport")
                    {
                        message = this.machinesManager.PilotReport(name);
                    }
                    else if (command == "ManufactureTank")
                    {
                        var attack = double.Parse(splitted[2]);
                        var defense = double.Parse(splitted[3]);

                        message = this.machinesManager.ManufactureTank(name, attack, defense);
                    }
                    else if (command == "ManufactureFighter")
                    {
                        var attack = double.Parse(splitted[2]);
                        var defense = double.Parse(splitted[3]);

                        message = this.machinesManager.ManufactureFighter(name, attack, defense);
                    }
                    else if (command == "MachineReport")
                    {
                        message = this.machinesManager.MachineReport(name);
                    }
                    else if (command == "AggressiveMode")
                    {
                        message = this.machinesManager.ToggleFighterAggressiveMode(name);
                    }
                    else if (command == "DefenseMode")
                    {
                        message = this.machinesManager.ToggleTankDefenseMode(name);
                    }
                    else if (command == "Engage")
                    {
                        var machineName = splitted[2];

                        message = this.machinesManager.EngageMachine(name, machineName);
                    }
                    else if (command == "Attack")
                    {
                        var deffendingMachineName = splitted[2];

                        message = this.machinesManager.AttackMachines(name, deffendingMachineName);
                    }

                    this.writer.WriteLine(message);
                }
                catch (ArgumentException ex)
                {
                    this.writer.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
