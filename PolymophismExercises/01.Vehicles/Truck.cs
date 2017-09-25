namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double AcConsumptionMod = 1.6;
        private const double FuelLossFactor = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity*FuelLossFactor, fuelConsumptionPerKm+AcConsumptionMod)
        {
        }
    }
}
