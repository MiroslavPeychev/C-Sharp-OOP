namespace _2._Stack_Sum
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(input);
            string commandInfo = Console.ReadLine()
                .ToLower();

            while (commandInfo != "end")
            {
                var tokens = commandInfo.Split();
                var command = tokens[0].ToLower();

                if (command == "add")
                {

                    int number1 = int.Parse(tokens[1]);
                    int number2 = int.Parse(tokens[2]);
                    stack.Push(number1);
                    stack.Push(number2);

                }
                else if (command == "remove")
                {
                    int countOfRemovedNums = int.Parse(tokens[1]);

                    if (stack.Count < countOfRemovedNums)
                    {
                        commandInfo = Console.ReadLine()
                            .ToLower();

                        continue;
                    }

                    for (int i = 0; i < countOfRemovedNums; i++)
                    {
                        stack.Pop();
                    }
                }

                commandInfo = Console.ReadLine()
                    .ToLower();
            }

            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}