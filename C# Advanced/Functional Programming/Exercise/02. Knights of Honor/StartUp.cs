namespace _02._Knights_of_Honor
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => $"Sir {n}")
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}