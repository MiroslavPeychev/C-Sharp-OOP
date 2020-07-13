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
                    throw new InvalidOperationException("Fuel quantity must be a positive number.");
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
                    throw new InvalidOperationException("Fuel consumption must be a positive number");
                }

                this.fuelConsumption = value;
            }
        }

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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:F2}L");

            return sb.ToString().TrimEnd();
        }
    }
}