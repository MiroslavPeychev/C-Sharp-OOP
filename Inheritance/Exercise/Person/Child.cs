namespace Person
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Child : Person
    {
        private const int MAX_CHILD_AGE = 15;
        private const int MIN_CHILD_AGE = 0;

        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            protected set
            {
                if (value > 15)
                {
                    throw new InvalidOperationException($"Age must be number betweenn {MIN_CHILD_AGE} and {MAX_CHILD_AGE}. Please, enter a valid number");
                }

                base.Age = value;
            }
        }
    }
}