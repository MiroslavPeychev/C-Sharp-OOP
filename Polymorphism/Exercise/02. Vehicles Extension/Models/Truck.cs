namespace P02.VehiclesExtension
{
    class Truck : Vehicle
    {
        private const double AirConditionerConsumption = 1.6;
        private const double WastedFuel = 0.05;


        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption + AirConditionerConsumption, tankCapacity)
        {
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
            this.FuelQuantity -= amount * WastedFuel;
        }
    }
}