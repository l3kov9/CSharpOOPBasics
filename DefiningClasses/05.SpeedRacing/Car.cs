using System;

namespace _05.SpeedRacing
{
    public class Car
    {
        public string model;
        public double fuel;
        public double fuelCost;
        public double distanceTraveled;

        public Car(string model, double fuel, double fuelCost)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelCost = fuelCost;
            this.distanceTraveled = 0;
        }

        public void Drive(int amountOfKilometers)
        {
            if (amountOfKilometers <= this.fuel / this.fuelCost)
            {
                this.distanceTraveled += amountOfKilometers;
                this.fuel -= this.fuelCost * amountOfKilometers;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}
