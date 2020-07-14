namespace DefiningClasses
{
    using System;

    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;


        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = travelledDistance;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Model cannot be null or white space. Please, enter valid model.");
                }

                this.model = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Fuel amount must be a positive number.");
                }

                this.fuelAmount = value;
            }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }

            private set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Fuel consumption per kilometer must be a positive number");
                }

                this.fuelConsumptionPerKilometer = value;
            }
        }

        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Traveled kilometers cannot be negative number");
                }

                this.travelledDistance = value;
            }
        }

        public void DriveCar(int amountOfKm)
        {
            double neededFuel = this.FuelConsumptionPerKilometer * amountOfKm;

            bool canMove = this.FuelAmount - neededFuel >= 0;

            if (canMove)
            {
                this.FuelAmount -= neededFuel;
                this.travelledDistance += amountOfKm;
            }
            else
            {
                throw new InvalidOperationException("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.TravelledDistance}";
        }
    }
}