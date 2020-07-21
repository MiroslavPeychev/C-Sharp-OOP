namespace _03._Periodic_Table
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            HashSet<string> list = new HashSet<string>();


            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < tokens.Length; j++)
                {
                    list.Add(tokens[j]);
                }
            }

            Console.WriteLine(string.Join(" ", list.OrderBy(x => x)));
        }
    }
}