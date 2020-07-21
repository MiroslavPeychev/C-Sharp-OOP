namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (var @char in inputLine)
            {
                if (symbols.ContainsKey(@char) == false)
                {
                    symbols[@char] = 0;
                }

                symbols[@char]++;
            }

            foreach (var kvp in symbols)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}