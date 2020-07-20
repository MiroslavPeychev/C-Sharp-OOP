namespace _03._Product_Shop
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, double>> list = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                string[] line = input.Split(", ");
                string shop = line[0];
                string product = line[1];
                double price = double.Parse(line[2]);

                if (!list.ContainsKey(shop))
                {
                    list[shop] = new Dictionary<string, double>();
                }

                list[shop][product] = price;
            }

            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}