namespace CarManufacturer
{
    using System;
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            if (horsePower <= 0 || cubicCapacity <= 0)
            {
                throw new InvalidOperationException("Engine is not valid. Horse power and cubic capacity must be a positive numbers");
            }

            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }
    }
}