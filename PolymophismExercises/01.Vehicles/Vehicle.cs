using System;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity { get; set; }

        private double FuelConsumptionPerKm { get; set; }


        //Todo Drive

        public void TryDrive(double distance)
        {
            if (distance * this.FuelConsumptionPerKm > this.FuelQuantity)
            {
                Console.WriteLine($"{GetType().Name} needs refueling.");
            }
            else
            {
                this.FuelQuantity -= this.FuelConsumptionPerKm * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km.");
            }
        }

        public void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }
    }
}
