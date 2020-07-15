namespace P07.RawData
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            HashSet<Car> cars = new HashSet<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            try
            {
                for (int i = 0; i < numberOfCars; i++)
                {
                    string[] carArgs = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string model = carArgs[0];

                    int engineSpeed = int.Parse(carArgs[1]);
                    int enginePower = int.Parse(carArgs[2]);

                    int cargoWeight = int.Parse(carArgs[3]);
                    string cargoType = carArgs[4];

                    Engine engine = CreateEngine(engineSpeed, enginePower);
                    Cargo cargo = CreateCargo(cargoWeight, cargoType);
                    List<Tire> tireSet = new List<Tire>();
                    
                    GetTires(carArgs, tireSet);

                    Car car = CreateCar(model, engine, cargo, tireSet);

                    cars.Add(car);
                }

                string command = Console.ReadLine();

                if (command == "fragile")
                {
                    HashSet<Car> result = cars
                        .Where(c => c.Cargo.Type == command &&
                         c.Tires.Any(t => t.Pressure < 1))
                        .ToHashSet();

                    foreach (Car car in result)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
                else if (command == "flamable")
                {
                    HashSet<Car> result = cars
                        .Where(c => c.Cargo.Type == command &&
                        c.Engine.Power > 250)
                        .ToHashSet();

                    foreach (Car car in result)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        private static void GetTires(string[] carArgs, List<Tire> tireSet)
        {
            for (int j = 5; j < carArgs.Length; j += 2)
            {
                double tirePressure = double.Parse(carArgs[j]);
                int tireAge = int.Parse(carArgs[j + 1]);

                Tire currentTire = CreateTire(tirePressure, tireAge);
                tireSet.Add(currentTire);
            }
        }

        static Engine CreateEngine(int engineSpeed, int enginePower)
        {
            return new Engine(engineSpeed, enginePower);
        }

        static Cargo CreateCargo(int cargoWeight, string cargoType)
        {
            return new Cargo(cargoWeight, cargoType);
        }

        static Tire CreateTire(double pressure, int age)
        {
            return new Tire(pressure, age);
        }

        static Car CreateCar(string model, Engine engine, Cargo cargo, List<Tire> tireSet)
        {
            return new Car(model, engine, cargo, tireSet);
        }
    }
}