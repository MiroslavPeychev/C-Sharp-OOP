namespace SoftUniParking
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var car = CreateCar("Skoda", "Fabia", 65, "CC1856BG");
                var car2 = CreateCar("Audi", "A3", 110, "EB8787MN");

                Console.WriteLine(car.ToString());
                //Make: Skoda
                //Model: Fabia
                //HorsePower: 65
                //RegistrationNumber: CC1856BG

                Parking parking = CreateParking(5);
                Console.WriteLine(parking.AddCar(car));
                //Successfully added new car Skoda CC1856BG

                Console.WriteLine(parking.AddCar(car));
                //Car with that registration number, already exists!

                Console.WriteLine(parking.AddCar(car2));
                //Successfully added new car Audi EB8787MN

                Console.WriteLine(parking.GetCar("EB8787MN").ToString());
                //Make: Audi
                //Model: A3
                //HorsePower: 110
                //RegistrationNumber: EB8787MN

                Console.WriteLine(parking.RemoveCar("EB8787MN"));
                //Successfullyremoved EB8787MN

                Console.WriteLine(parking.Count); //1
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }

        }
        public static Car CreateCar(string make, string model, int horsePower, string registrationNumber)
        {
            return new Car(make, model, horsePower, registrationNumber);
        }

        public static Parking CreateParking(int capacity)
        {
            return new Parking(capacity);
        }
    }
}