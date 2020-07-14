namespace DefiningClasses
{
    using System;

    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidOperationException("Name is invalid. Name should not be null or white space. Please enter a valid name");
                }

                this.name = value;
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
                    throw new InvalidOperationException("Age must be a positive number");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }
    }
}