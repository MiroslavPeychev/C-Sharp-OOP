namespace DefiningClasses
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            try
            {
                for (int i = 0; i < n; i++)
                {
                    string[] personArgs = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string name = personArgs[0];
                    int age = int.Parse(personArgs[1]);

                    Person person = new Person(name, age);

                    family.AddMember(person);
                }

                Console.WriteLine(family.GetOldestMember());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}