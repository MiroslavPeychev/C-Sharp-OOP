namespace _8._Traffic_Jam
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var countPerGreenLight = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            var totalCarsPassed = 0;

            while (true)
            {
                var currentLine = Console.ReadLine();

                if (currentLine == "end")
                {
                    Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
                    break;
                }

                if (currentLine != "green")
                {
                    cars.Enqueue(currentLine);
                }
                else
                {
                    int carToPass = Math.Min(countPerGreenLight, cars.Count);

                    for (int i = 0; i < carToPass; i++)
                    {
                        string currentCar = cars.Dequeue();
                        Console.WriteLine($"{currentCar} passed!");

                        totalCarsPassed++;
                    }
                }
            }
        }
    }
}