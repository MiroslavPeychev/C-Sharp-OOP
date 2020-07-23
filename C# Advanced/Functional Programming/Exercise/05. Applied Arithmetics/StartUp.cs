namespace _05._Applied_Arithmetics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Func<List<int>, List<int>> addFunc = x => x.Select(a => a += 1).ToList();
            Func<List<int>, List<int>> subtractFunc = x => x.Select(a => a -= 1).ToList();
            Func<List<int>, List<int>> multiplyFunc = x => x.Select(a => a * 2).ToList();
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));


            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = addFunc(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtractFunc(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiplyFunc(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}