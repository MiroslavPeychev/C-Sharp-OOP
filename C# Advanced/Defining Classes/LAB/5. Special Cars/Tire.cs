namespace CarManufacturer
{
    using System;

    public class Tire
    {
        public Tire(int year, double pressure)
        {
            if (year < 0 || pressure < 0)
            {
                throw new InvalidOperationException("Tire is not valid. Year or pressure cannot be less than 0");
            }

            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year { get; }

        public double Pressure { get; set; }
    }
}