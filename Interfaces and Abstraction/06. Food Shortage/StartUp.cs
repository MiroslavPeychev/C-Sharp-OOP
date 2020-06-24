namespace P07.FoodShortage
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var people = new List<IBuyer>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                if (tokens.Length == 4)
                {
                    string id = tokens[2];
                    string birthdate = tokens[3];

                    people.Add(new Citizen(name, age, id, birthdate));
                }

                else if (tokens.Length == 3)
                {
                    string group = tokens[2];

                    people.Add(new Rebel(name, age, group));
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    int allFood = people.Sum(p => p.Food);

                    Console.WriteLine(allFood);
                    break;
                }

                var person = people.FirstOrDefault(p => p.Name == input);

                if (person != null)
                {
                    person.ByFood();
                }
            }
        }
    }
}