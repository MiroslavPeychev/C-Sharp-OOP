namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> colorClothCount = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] colorClothes = Console.ReadLine().Split(" -> ");

                string color = colorClothes[0];
                string[] clothes = colorClothes[1].Split(",");

                if (colorClothCount.ContainsKey(color) == false)
                {
                    colorClothCount[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string cloth = clothes[j];

                    if (colorClothCount[color].ContainsKey(cloth) == false)
                    {
                        colorClothCount[color][cloth] = 0;
                    }

                    colorClothCount[color][cloth]++;
                }
            }

            string[] seachedCloth = Console
                .ReadLine()
                .Split();

            string colorToFind = seachedCloth[0];
            string clothToFind = seachedCloth[1];

            foreach (var kvp in colorClothCount)
            {
                string color = kvp.Key;
                var clothCount = kvp.Value;

                Console.WriteLine($"{color} clothes:");

                foreach (var kvpClothCount in clothCount)
                {
                    string cloth = kvpClothCount.Key;
                    int count = kvpClothCount.Value;

                    if (color == colorToFind && cloth == clothToFind)
                    {
                        Console.WriteLine($"* {cloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }
                }
            }
        }
    }
}