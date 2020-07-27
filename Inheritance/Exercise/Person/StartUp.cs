namespace Person
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Person child = new Person(name, age);
                Console.WriteLine(child);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}