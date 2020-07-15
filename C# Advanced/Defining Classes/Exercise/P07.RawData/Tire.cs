namespace P07.RawData
{
    using System;
    public class Tire
    {
        private double pressure;
        private int age;

        public Tire( double pressure,int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        public double Pressure
        {
            get
            {
                return this.pressure;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Invalid pressure. Pressure must be a positive number!");
                }

                this.pressure = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Invalid age. Age must be a positive number!");
                }

                this.age = value;
            }
        }
    }
}