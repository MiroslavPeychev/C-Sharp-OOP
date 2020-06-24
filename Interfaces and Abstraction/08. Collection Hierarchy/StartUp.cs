namespace P09.CollectionHierarchy
{
    using P09.CollectionHierarchy.Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var input = Console.ReadLine().Split();
            

            foreach (string element in input)
            {
                Console.Write($"{addCollection.Add(element)} ");
            }

            Console.WriteLine();

            foreach (string element in input)
            {
                Console.Write($"{addRemoveCollection.Add(element)} ");
            }

            Console.WriteLine();

            foreach (string element in input)
            {
                Console.Write($"{myList.Add(element)} ");
            }

            Console.WriteLine();

            int removeOperationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < removeOperationsCount; i++)
            {
                Console.Write($"{addRemoveCollection.Remove()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < removeOperationsCount; i++)
            {
                Console.Write($"{myList.Remove()} ");
            }

            Console.WriteLine();
        }
    }
}