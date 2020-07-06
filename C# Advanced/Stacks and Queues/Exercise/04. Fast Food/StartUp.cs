namespace _04._Fast_Food
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(input);

            Console.WriteLine(orders.Max());

            while (orders.Any())
            {
                if (quantityOfFood <= 0)
                {
                    break;
                }

                if (quantityOfFood - orders.Peek() >= 0)
                {
                    quantityOfFood -= orders.Dequeue();
                }
                else
                {
                    break;
                }

            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}