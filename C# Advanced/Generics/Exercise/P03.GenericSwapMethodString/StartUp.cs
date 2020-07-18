
namespace P03.GenericSwapMethodString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            Box<string> box = new Box<string>(names);

            int[] indexesToSwap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexesToSwap[0];
            int secondIndex = indexesToSwap[1];

            box.Swap(names, firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}