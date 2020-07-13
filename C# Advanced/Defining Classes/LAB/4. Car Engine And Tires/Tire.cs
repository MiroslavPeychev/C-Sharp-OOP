namespace CarManufacturer
{
    using System;
    public class Tire
    {
        public Tire(int year, double pressure)
        {
            if (year < 2010 || pressure < 0)
            {
                throw new InvalidOperationException("Tire is not valid. Year cannot be less than 2010 and pressure cannot be less than 0");
            }

            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year { get; }

        public double Pressure { get; set; }
    }
}