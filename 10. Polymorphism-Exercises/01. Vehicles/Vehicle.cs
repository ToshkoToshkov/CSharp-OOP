namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuel, double fuelConsumption, double airConditionerModifier)
        {
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionerModifier = airConditionerModifier;
        }

        public double Fuel { get; private set; }

        public double FuelConsumption { get; private set; }

        public double AirConditionerModifier { get; set; }

        public void Drive(double distance)
        {
            double requieredFuel = (this.FuelConsumption + this.AirConditionerModifier) * distance;

            if (requieredFuel > this.Fuel)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }

            this.Fuel -= requieredFuel;
        }

        public virtual void Refuel(double amount)
        {
            this.Fuel += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:f2}";
        }

    }
}
