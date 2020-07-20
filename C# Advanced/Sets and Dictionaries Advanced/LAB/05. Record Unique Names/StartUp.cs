namespace _05._Record_Unique_Names
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfNames = int.Parse(Console.ReadLine());

            HashSet<string> listOfNames = new HashSet<string>();

            for (int i = 0; i < numberOfNames; i++)
            {
                string name = Console.ReadLine();
                listOfNames.Add(name);
            }

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}