namespace P01_RawData.Factories
{
    public class CargoFactory
    {
        public Cargo Create(int weight, string type)
        {
            return new Cargo(weight, type);
        }
    }
}