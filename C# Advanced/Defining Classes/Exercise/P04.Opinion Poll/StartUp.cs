namespace DefiningClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();

            int membersCount = int.Parse(Console.ReadLine());

            try
            {
                for (int i = 0; i < membersCount; i++)
                {
                    string[] personArgs = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string name = personArgs[0];
                    int age = int.Parse(personArgs[1]);

                    Person person = new Person(name, age);

                    family.AddMember(person);
                }

                HashSet<Person> result = family.GetAllPeopleAbove30();
                Console.WriteLine(string.Join(Environment.NewLine, result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}