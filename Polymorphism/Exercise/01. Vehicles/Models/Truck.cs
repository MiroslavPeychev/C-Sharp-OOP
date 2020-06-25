namespace P01.Vehicles.Models
{
    class Truck : Vehicle
    {
        private const double AirConditionerConsumption = 1.6;
        private const double WastedFuel = 0.05;


        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption + AirConditionerConsumption)
        {
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
            this.FuelQuantity -= amount * WastedFuel;
        }
    }
}