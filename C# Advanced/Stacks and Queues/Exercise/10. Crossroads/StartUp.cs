namespace _10._Crossroads
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Queue<string> carsInQueue = new Queue<string>();
            int countOfPassedCars = 0;

            while (input != "END")
            {
                int currentGreenLight = greenLight;
                int currentFreeWindow = freeWindow;

                if (input != "green")
                {
                    carsInQueue.Enqueue(input);
                }
                else
                {
                    while (carsInQueue.Any() && currentGreenLight > 0)
                    {
                        string currentCar = carsInQueue.Peek();
                        if (currentGreenLight >= currentCar.Length)
                        {
                            currentGreenLight -= currentCar.Length;
                            carsInQueue.Dequeue();
                            countOfPassedCars++;
                        }
                        else
                        {
                            string leftOverOfCars = currentCar.Substring(currentGreenLight);
                            currentGreenLight = 0;

                            if (leftOverOfCars.Length > freeWindow)
                            {
                                PrintCarCrash(leftOverOfCars, currentCar, freeWindow);
                                return;
                            }
                            else
                            {
                                carsInQueue.Dequeue();
                                countOfPassedCars++;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{countOfPassedCars} total cars passed the crossroads.");
        }

        private static void PrintCarCrash(string lastCarToPass, string currentCar, int freeWindow)
        {
            StringBuilder sb = new StringBuilder();

            int characterToHit = freeWindow;

            sb.AppendLine("A crash happened!");
            sb.AppendLine($"{currentCar} was hit at {lastCarToPass[characterToHit]}.");

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}