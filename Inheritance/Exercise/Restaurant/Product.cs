namespace Restaurant
{
    public abstract class Product
    {
        protected Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string  Name { get;  }

        public decimal Price { get;  }
    }
}