namespace _6._Supermarket
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Queue<string> listOfCustomersNames = new Queue<string>();


            while (input != "End")
            {
                if (input == "Paid")
                {
                    List<string> listOfPaidCustomers = new List<string>();

                    while (listOfCustomersNames.Count > 0)
                    {
                        listOfPaidCustomers.Add(listOfCustomersNames.Dequeue());
                    }

                    Console.WriteLine(string.Join(Environment.NewLine, listOfPaidCustomers));
                }
                else
                {
                    listOfCustomersNames.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{listOfCustomersNames.Count} people remaining.");
        }
    }
}