namespace ClassBoxData
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                this.ValidateParameter(value, nameof(this.Length));
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            private set
            {
                ValidateParameter(value, nameof(this.Width));
                this.width = value;
            }
        }

        private void ValidateParameter(double value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{parameterName} cannot be zero or negative.");
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                this.ValidateParameter(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            return 2 * (this.length * this.width) + this.CalculateLateralSurfaceArea();
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * (this.length * this.height + this.width * this.height);
        }

        public double CalculateVolume()
        {
            return this.width * this.height * this.length;
        }
    }
}