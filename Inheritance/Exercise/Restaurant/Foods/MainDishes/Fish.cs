namespace Restaurant.Foods.MainDishes
{
    public class Fish : MainDish
    {
        private const double FiShGrams = 22;
        
        public Fish(string name, decimal price)
            : base(name, price, FiShGrams)
        {
        }
    }
}