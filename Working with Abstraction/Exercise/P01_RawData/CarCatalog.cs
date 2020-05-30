namespace P01_RawData
{
    using P01_RawData.Factories;
    using System.Collections.Generic;
    using System.Linq;

    public class CarCatalog
    {
        private const int TireCount = 4;

        private List<Car> cars;
        private EngineFactory engineFactory;
        private CargoFactory cargoFactory;
        private CarFactory carFactory;

        public CarCatalog(EngineFactory engineFactory, CargoFactory cargoFactory, CarFactory carFactory)
        {
            this.cars = new List<Car>();
            this.engineFactory = engineFactory;
            this.cargoFactory = cargoFactory;
            this.carFactory = carFactory;
        }

        public void Add(string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];

            Engine engine = engineFactory.Create(engineSpeed, enginePower);
            Cargo cargo = cargoFactory.Create(cargoWeight, cargoType);
            Tire[] tires = GetTires(parameters.Skip(5).ToList());
            Car car = carFactory.Create(model, engine, cargo, tires);

            cars.Add(car);
        }

        private Tire[] GetTires(List<string> tireParameters)
        {
            Tire[] tires = new Tire[TireCount];

            int tireIndex = 0;

            for (int j = 0; j < 8; j += 2)
            {
                double tirePressure = double.Parse(tireParameters[j]);
                int tireAge = int.Parse(tireParameters[j + 1]);

                Tire tire = new Tire(tirePressure, tireAge);

                tires[tireIndex] = tire;

                tireIndex++;
            }

            return tires;
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }
    }
}