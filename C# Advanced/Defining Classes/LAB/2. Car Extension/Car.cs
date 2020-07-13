namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {
        private int year;
        private double fuelConsumption;
        private double fuelQuantity;


        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.fuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make { get; set; }

        public string Model { get; set; }

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
                return this.FuelConsumption;
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

        public double FuelConsumption { get; private set; }

        public void Drive(double distance)
        {
            var neededFuel = distance * this.FuelConsumption;


            bool canContinue = this.FuelQuantity - neededFuel >= 0;

            if (canContinue)
            {
                this.FuelQuantity -= neededFuel;
            }
            else
            {
                throw new InvalidOperationException("Not enough fuel.");
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