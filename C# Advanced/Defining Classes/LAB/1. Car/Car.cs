namespace CarManufacturer
{
    using System;

    public class Car
    {
        
        private int year;

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
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

        public string Details
        {
            get 
            { 
                return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}";
            }
        }
    }
}