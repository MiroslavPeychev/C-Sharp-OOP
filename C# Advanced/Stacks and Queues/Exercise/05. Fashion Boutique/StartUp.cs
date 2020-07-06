namespace _05._Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(inputNumbers);

            int racks = 1;
            int sum = 0;

            while (clothes.Any())
            {
                if (sum + clothes.Peek() <= rackCapacity)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}