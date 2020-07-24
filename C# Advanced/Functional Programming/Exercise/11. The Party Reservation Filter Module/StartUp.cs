namespace _11._The_Party_Reservation_Filter_Module
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> commands = new List<string>();
            Predicate<string> predicate;

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }

                var splittedCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (splittedCommand[0] == "Remove")
                {
                    string secondPart = command.Substring(6, command.Length - 6);

                    int commandIndex = commands.FindIndex(x => x.EndsWith(secondPart));

                    commands.RemoveAt(commandIndex);
                }

                else
                {
                    commands.Add(command);
                }
            }

            foreach (string command in commands)
            {
                string[] splittedCommand = command.Split(';');
                string filterCommand = splittedCommand[1];
                string criterion = splittedCommand[2];

                predicate = GetPredicate(filterCommand, criterion);
                people.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", people));
        }

        public static Predicate<string> GetPredicate(string filterCommand, string criterion)
        {
            switch (filterCommand)
            {
                case "Starts with":
                    return p => p.StartsWith(criterion);

                case "Ends with":
                    return p => p.EndsWith(criterion);

                case "Contains":
                    return p => p.Contains(criterion);

                case "Length":
                    return p => p.Length == int.Parse(criterion);
            }

            return null;
        }
    }
}