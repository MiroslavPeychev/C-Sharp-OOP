namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelConsumption;
        private double fuelQuantity;


        public Car()
            : this("VW", "Golf", 2025, 200, 10)
        {
        }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value < 1886)
                {
                    throw new InvalidOperationException("Year cannot be less than 1886.");
                }

                this.year = value;
            }
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("FuelQuantity must be a positive number.");
                }

                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }

            private set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("FuelConsumption must be a positive number");
                }

                this.fuelConsumption = value;
            }
        }

        public Engine Engine { get; }

        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            var neededFuel = this.FuelConsumption / 100.0 * distance;

            bool canContinue = this.FuelQuantity - neededFuel >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= neededFuel;
            }
            else
            {
                throw new InvalidOperationException("Not enough fuel to perform this trip!");
            }
        }

        public string GetSpecifications()
        {
            StringBuilder carInfo = new StringBuilder();
            carInfo.AppendLine($"Make: {this.Make}");
            carInfo.AppendLine($"Model: {this.Model}");
            carInfo.AppendLine($"Year: {this.Year}");
            carInfo.AppendLine($"Fuel: {this.FuelQuantity:F2}L");

            return carInfo.ToString().TrimEnd();
        }
    }
}