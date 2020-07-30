using System.Reflection.Metadata;

namespace Restaurant.Beverages.HotBeverages
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMililiters = 50;
        private const decimal CoffeePrice = 3.5m;
        
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMililiters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; }
    }
}