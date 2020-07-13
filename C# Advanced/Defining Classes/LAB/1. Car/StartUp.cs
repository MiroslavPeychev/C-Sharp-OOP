namespace CarManufacturer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Car car = new Car("VW", "MK3", 1992);
            
            Console.WriteLine(car.Details);
        }
    }
}