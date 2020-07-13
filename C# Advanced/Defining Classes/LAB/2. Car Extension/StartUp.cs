namespace CarManufacturer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Car car = new Car("VW", "MK3", 1992, 200, 200);

            car.Drive(2000);

            Console.WriteLine(car.GetSpecifications());
        }
    }
}