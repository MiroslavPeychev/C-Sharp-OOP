namespace P06.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            List<double> elements = new List<double>();

            for (int i = 0; i < numberOfElements; i++)
            {
                double currentElement = double.Parse(Console.ReadLine());

                elements.Add(currentElement);
            }

            Box<double> box = new Box<double>(elements);

            double elementToCompare = double.Parse(Console.ReadLine());

            int countOfGreaterElements = box.CountGreaterElements(elements, elementToCompare);

            Console.WriteLine(countOfGreaterElements);
        }
    }
}