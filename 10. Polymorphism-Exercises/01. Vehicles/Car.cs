namespace Vehicles
{
    internal class Car : Vehicle
    {
        private const double airConitionerModifierForCar = 0.9;
        public Car(double fuel, double fuelConsumption) 
            : base(fuel, fuelConsumption, airConitionerModifierForCar)
        {
        }
    }
}
