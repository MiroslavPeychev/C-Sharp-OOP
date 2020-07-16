namespace SoftUniParking
{
    using System;
    using System.Text;

    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid make. Make cannot be null or white space!");
                }

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid model. Model cannot be null or white space!");
                }

                this.model = value;
            }
        }

        public int  HorsePower
        {
            get
            {
                return this.horsePower;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Invalid horse power. Horse power must be a positive number");
                }

                this.horsePower = value;
            }
        }

        public string  RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Invalid registration number. Registration number cannot be null or white space!");
                }

                this.registrationNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"Make: {this.Make}")
                .AppendLine($"Model: {this.Model}")
                .AppendLine($"HorsePower: {this.HorsePower}")
                .AppendLine($"RegistrationNumber: {this.RegistrationNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}