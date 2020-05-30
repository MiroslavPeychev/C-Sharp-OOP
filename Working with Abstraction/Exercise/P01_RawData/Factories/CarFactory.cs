namespace P01_RawData.Factories
{
    public class CarFactory
    {
        public Car Create(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Car car = new Car(model, engine, cargo, tires);

            return car;
        }
    }
}
