namespace P02.VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double AirConditionerConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption + AirConditionerConsumption, tankCapacity)
        {
        }
    }
}