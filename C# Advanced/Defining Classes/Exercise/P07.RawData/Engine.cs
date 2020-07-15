namespace P07.RawData
{
    using System;
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Speed must be a positive number");
                }

                this.speed = value;
            }
        }

        public int Power
        {
            get
            {
                return this.power;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Power must be a positive number");
                }

                this.power = value;
            }
        }
    }
}