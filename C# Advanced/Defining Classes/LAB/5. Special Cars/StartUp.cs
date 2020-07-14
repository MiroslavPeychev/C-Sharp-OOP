namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                Tire[] tiresOfOneCars = new Tire[4];
                string[] inputTire = input.Split();

                int yearFirstTire = int.Parse(inputTire[0]);
                double pressureFirstTire = double.Parse(inputTire[1]);
                Tire firstTire = new Tire(yearFirstTire, pressureFirstTire);
                tiresOfOneCars[0] = firstTire;

                int yearSecondTire = int.Parse(inputTire[2]);
                double pressureSecondTire = double.Parse(inputTire[3]);
                Tire secondTire = new Tire(yearSecondTire, pressureSecondTire);
                tiresOfOneCars[1] = secondTire;

                int yearThirdTire = int.Parse(inputTire[4]);
                double pressureThirdTire = double.Parse(inputTire[5]);
                Tire thirdTire = new Tire(yearThirdTire, pressureThirdTire);
                tiresOfOneCars[2] = thirdTire;

                int yearFourthTire = int.Parse(inputTire[6]);
                double pressureFourthTire = double.Parse(inputTire[7]);
                Tire fourthTire = new Tire(yearFourthTire, pressureFourthTire);
                tiresOfOneCars[3] = fourthTire;

                tires.Add(tiresOfOneCars);

                input = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] engineInput = input.Split();
                int horsePower = int.Parse(engineInput[0]);
                double cubicCapacity = double.Parse(engineInput[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);

                input = Console.ReadLine();
            }

            List<Car> specialCars = new List<Car>();

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] carInput = input.Split();

                string make = carInput[0];
                string model = carInput[1];
                int year = int.Parse(carInput[2]);
                double fuelQuantity = double.Parse(carInput[3]);
                double fuelConsumption = double.Parse(carInput[4]);
                int enginIndex = int.Parse(carInput[5]);
                int tiresIndex = int.Parse(carInput[6]);

                Car currentCar = new Car(make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumption,
                    engines[enginIndex],
                    tires[tiresIndex]);

                specialCars.Add(currentCar);

                input = Console.ReadLine();
            }

            specialCars = specialCars.Where(x => x.Year >= 2017)
                .Where(x => x.Tires.Select(t => t.Pressure).Sum() >= 9)
                .Where(x => x.Tires.Select(t => t.Pressure).Sum() <= 10)
                .Where(x => x.Engine.HorsePower > 330)
                .ToList();

            foreach (var car in specialCars)
            {
                car.Drive(20);
                StringBuilder carInfo = new StringBuilder();
                carInfo.AppendLine($"Make: {car.Make}");
                carInfo.AppendLine($"Model: {car.Model}");
                carInfo.AppendLine($"Year: {car.Year}");
                carInfo.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                carInfo.Append($"FuelQuantity: {car.FuelQuantity}");

                Console.WriteLine(carInfo.ToString());
                carInfo.Clear();
            }
        }
    }
}