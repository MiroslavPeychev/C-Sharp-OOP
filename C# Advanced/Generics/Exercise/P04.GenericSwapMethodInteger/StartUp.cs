namespace P04.GenericSwapMethodInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < linesCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                numbers.Add(number);
            }

            Box<int> box = new Box<int>(numbers);

            int[] indexesToSwap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexesToSwap[0];
            int secondIndex = indexesToSwap[1];

            box.Swap(numbers, firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}