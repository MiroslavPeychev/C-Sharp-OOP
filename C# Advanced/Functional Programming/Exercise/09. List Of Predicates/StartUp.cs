namespace _09._List_Of_Predicates
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Func<int, int, bool> isNotDivisible = (x, y) => x % y != 0;

            Action<List<int>> printResultNumbers = n => Console.WriteLine(string.Join(" ", n));

            int number = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isValidNumber = true;

            List<int> result = new List<int>();

            for (int currentNumber = 1; currentNumber <= number; currentNumber++)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (isNotDivisible(currentNumber, numbers[i]))
                    {
                        isValidNumber = false;
                        break;
                    }
                }

                if (isValidNumber)
                {
                    result.Add(currentNumber);
                }

                isValidNumber = true;
            }

            printResultNumbers(result);
        }
    }
}