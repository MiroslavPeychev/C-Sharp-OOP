namespace P02.VehiclesExtension
{
    using P02.VehiclesExtension;
    using P02.VehiclesExtension.Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] carArgs = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carArgs[1]);
            double carFuelConsumption = double.Parse(carArgs[2]);
            int carTankCapasity = int.Parse(carArgs[3]);

            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapasity);

            string[] truckArgs = Console.ReadLine().Split();

            double truckFuelQuantity = double.Parse(truckArgs[1]);
            double truckFuelConsumption = double.Parse(truckArgs[2]);
            int truckTankCapasity = int.Parse(truckArgs[3]);


            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapasity);

            string[] busArgs = Console.ReadLine().Split();

            double busFuelQuantity = double.Parse(busArgs[1]);
            double busFuelConsumption = double.Parse(busArgs[2]);
            int busTankCapasity = int.Parse(busArgs[3]);


            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapasity);


            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];
                string commandType = commandArgs[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandArgs[2]);

                    if (commandType == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if(commandType == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(bus.Drive(distance));
                    }
                }
                else if(command == "Refuel")
                {
                    double fuelAmount = double.Parse(commandArgs[2]);

                    try
                    {
                        if (commandType == "Car")
                        {
                            car.Refuel(fuelAmount);
                        }
                        else if (commandType == "Truck")
                        {
                            truck.Refuel(fuelAmount);
                        }
                        else
                        {
                            bus.Refuel(fuelAmount);
                        }
                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                }
                else
                {
                    double distance = double.Parse(commandArgs[2]);

                    Console.WriteLine(bus.DriveEmpty(distance)); 
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}