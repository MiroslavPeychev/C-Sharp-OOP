namespace P05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var listOfCitizensAndRobots = new List<IIndentification>();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                string id = input[input.Length - 1];

                if (input.Length == 2)
                {
                    string model = input[0];
                    listOfCitizensAndRobots.Add(new Robot(model, id));
                }

                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    listOfCitizensAndRobots.Add(new Citizen(name, age, id));
                }
            }

            string lastDigits = Console.ReadLine();

            foreach (var entry in listOfCitizensAndRobots.Select(x => x.Id).Where(x => x.EndsWith(lastDigits)).ToList())
            {
                Console.WriteLine(entry);
            }
        }
    }
}