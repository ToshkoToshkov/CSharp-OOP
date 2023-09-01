namespace Vehicles
{
    internal class Truck : Vehicle
    {
        private const double airConitionerModifierForTruck = 1.6;
        public Truck(double fuel, double fuelConsumption)
            : base(fuel, fuelConsumption, airConitionerModifierForTruck)
        {
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount * 0.95);
        }
    }
}
