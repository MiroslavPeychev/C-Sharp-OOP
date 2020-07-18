namespace P05.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            List<string> elements = new List<string>();

            for (int i = 0; i < numberOfElements; i++)
            {
                string currentElement = Console.ReadLine();

                elements.Add(currentElement);
            }

            Box<string> box = new Box<string>(elements);

            string elementToCompare = Console.ReadLine();

            int countOfGreaterElements = box.CountGreaterElements(elements, elementToCompare);

            Console.WriteLine(countOfGreaterElements);

        }
    }
}