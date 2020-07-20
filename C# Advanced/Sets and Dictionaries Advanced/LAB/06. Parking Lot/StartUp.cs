namespace _06._Parking_Lot
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            HashSet<string> listOfCars = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];
                string carPlate = tokens[1];

                if (command == "IN")
                {
                    listOfCars.Add(carPlate);
                }
                else if (command == "OUT")
                {
                    if (listOfCars.Contains(carPlate))
                    {
                        listOfCars.Remove(carPlate);
                    }
                }
            }

            if (listOfCars.Count > 0)
            {
                foreach (var item in listOfCars)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}