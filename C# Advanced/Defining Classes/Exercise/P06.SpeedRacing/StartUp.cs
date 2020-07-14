namespace DefiningClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            HashSet<Car> cars = new HashSet<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKilometer = double.Parse(carInfo[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(currentCar);
            }

            while (true)
            {
                try
                {
                    string[] commandLine = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string command = commandLine[0];

                    if (command == "End")
                    {
                        break;
                    }

                    if (command == "Drive")
                    {
                        string carModel = commandLine[1];
                        int amountOfKm = int.Parse(commandLine[2]);

                        Car currentCar = cars
                            .Where(c => c.Model == carModel)
                            .FirstOrDefault();

                        currentCar.DriveCar(amountOfKm);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}