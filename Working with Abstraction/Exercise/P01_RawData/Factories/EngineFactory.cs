namespace P01_RawData.Factories
{
    public class EngineFactory
    {
        public Engine Create(int speed, int power)
        {
            return new Engine(speed, power);
        }
    }
}