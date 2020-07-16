namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.Capacity = capacity;
            this.Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Invalid parking capacity. Parking capacity must be a positive number");
                }

                this.capacity = value;
            }
        }

        public int Count => this.Cars.Count;

        public string AddCar(Car car)
        {
            if (this.Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (this.Cars.Count >= this.Capacity)
            {
                return "Parking is full!";
            }

                this.Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.Cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                this.Cars.Remove(this.Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber));

                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return this.Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string currentNumber in registrationNumbers)
            {
                this.Cars.RemoveAll(c => c.RegistrationNumber == currentNumber);
            }
        }
    }
}