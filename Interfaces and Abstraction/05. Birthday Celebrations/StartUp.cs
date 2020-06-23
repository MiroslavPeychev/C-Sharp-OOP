namespace P06.BirthdayCelebrations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var listOfCitizensRobotsAndPets = new List<IBirthable>();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                else if (input[0] == "Citizen")
                {
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string id = input[3];
                    string birthdate = input[4];
                    listOfCitizensRobotsAndPets.Add(new Citizen(name, age, id, birthdate));
                }

                else if (input[0] == "Pet")
                {
                    string name = input[1];
                    string birthdate = input[2];
                    listOfCitizensRobotsAndPets.Add(new Pet(name, birthdate));
                }
            }

            string year = Console.ReadLine();

            //listOfCitizensRobotsAndPets
            //    .Select(x => x.Birthdate)
            //    .Where(x => x.EndsWith(year))
            //    .ToList()
            //    .ForEach(Console.WriteLine);

            foreach (var entry in listOfCitizensRobotsAndPets
                .Select(x => x.Birthdate)
                .Where(x => x.EndsWith(year))
                .ToList())
            {
                Console.WriteLine(entry);
            }
        }
    }
}