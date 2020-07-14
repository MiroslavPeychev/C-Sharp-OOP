namespace DefiningClasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = "Pesho";
            int age = 20;

            try
            {
                Person person = new Person
                {
                    Name = name,
                    Age = age
                };

                Console.WriteLine($"{person.Name} -> {person.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}