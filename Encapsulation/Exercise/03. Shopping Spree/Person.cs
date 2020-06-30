namespace P04.ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Products
        {
            get => this.bagOfProducts;
        }

        public bool PersonCanAffortProduct(Product product)
        {
            if ( this.money>=product.Cost)
            {
                money -= product.Cost;
                bagOfProducts.Add(product);
                return true;
            }

            return false;

        }
    }
}