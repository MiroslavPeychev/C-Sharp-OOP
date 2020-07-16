namespace P08.CarSalesman
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();

            int numberOfinputEngines = int.Parse(Console.ReadLine());

            try
            {
                for (int i = 0; i < numberOfinputEngines; i++)
                {
                    string[] engineArgs = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    Engine engine = null;

                    string model = engineArgs[0];
                    int power = int.Parse(engineArgs[1]);

                    if (engineArgs.Length == 4)
                    {
                        int displacement = int.Parse(engineArgs[2]);
                        string efficiency = engineArgs[3];

                        engine = new Engine(model, power, displacement, efficiency);
                    }
                    else if (engineArgs.Length == 3)
                    {
                        int displacement;

                        bool isDisplacement = int.TryParse(engineArgs[2], out displacement);

                        if (isDisplacement)
                        {
                            engine = new Engine(model, power, displacement);
                        }
                        else
                        {
                            string efficiency = engineArgs[2];
                            engine = new Engine(model, power, efficiency);
                        }
                    }
                    else if (engineArgs.Length == 2)
                    {
                        engine = new Engine(model, power);
                    }

                    if (engine != null)
                    {
                        engines.Add(engine);
                    }
                }

                int numberOfCars = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfCars; i++)
                {
                    string[] carArg = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    Car car = null;

                    string model = carArg[0];
                    string inputEngineModel = carArg[1];
                    Engine engine = engines.First(e => e.Model == inputEngineModel);

                    if (carArg.Length == 2)
                    {
                        car = new Car(model, engine);
                    }
                    else if (carArg.Length == 3)
                    {
                        double weight;

                        bool isWeight = double.TryParse(carArg[2], out weight);

                        if (isWeight)
                        {
                            car = new Car(model, engine, weight);
                        }
                        else
                        {
                            string color = carArg[2];
                            car = new Car(model, engine, color);
                        }
                    }
                    else if (carArg.Length == 4)
                    {
                        double weight = double.Parse(carArg[2]);
                        string color = carArg[3];

                        car = new Car(model, engine, weight, color);
                    }

                    if (car != null)
                    {
                        cars.Add(car);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}