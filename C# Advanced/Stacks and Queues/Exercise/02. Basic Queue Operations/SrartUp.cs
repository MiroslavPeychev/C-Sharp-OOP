namespace _02._Basic_Queue_Operations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SrartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numbersToEnqueue = input[0];
            int numbersToDequeue = input[1];
            int numbersToFind = input[2];

            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numbersToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}