namespace _04._Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> list = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < number; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                string continent = line[0];
                string country = line[1];
                string sity = line[2];

                if (!list.ContainsKey(continent))
                {
                    list[continent] = new Dictionary<string, List<string>>();
                }

                if (!list[continent].ContainsKey(country))
                {
                    list[continent][country] = new List<string>();
                }

                list[continent][country].Add(sity);
            }

            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"    {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}