namespace CarManufacturer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Engine engine = new Engine(560, 6300);
            Tire[] tires = new Tire[4]
            {
                new Tire(2015, 2.5),
                new Tire(2015, 2.1),
                new Tire(2017, 0.5),
                new Tire(2017, 2.3)

            };


            Car car = new Car();

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Car forthCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires);

            Console.WriteLine(car.GetSpecifications());
        }
    }
}