namespace _07._Predicate_For_Names
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            Func<string, bool> checkLength = n => n.Length <= length;

            Action<string> print = p => Console.WriteLine(p);

            Console.ReadLine()
                .Split()
                .Where(checkLength)
                .ToList()
                .ForEach(print);
        }
    }
}