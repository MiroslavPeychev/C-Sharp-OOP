namespace _01._Action_Print
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Action<string> print = name => Console.WriteLine(name);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}