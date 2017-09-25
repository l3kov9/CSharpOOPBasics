using System;

namespace _01.Vehicles
{
    public class Startup
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            var truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[1]));

            var commandsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNumber; i++)
            {
                var commandToken = Console.ReadLine().Split();
                var vehicleType = commandToken[1];
                CommandVehicle(car, truck, commandToken, vehicleType);
            }

            Console.WriteLine($"{car.GetType().Name}: {car.FuelQuantity:f2}");
            Console.WriteLine($"{truck.GetType().Name}: {truck.FuelQuantity:f2}");
        }

        private static void CommandVehicle(Vehicle car, Vehicle truck, string[] commandToken, string vehicleType)
        {
            if (vehicleType == "Car")
            {
                switch (commandToken[0])
                {
                    case "Drive":
                        car.TryDrive(double.Parse(commandToken[2]));
                        break;
                    case "Refuel":
                        car.Refuel(double.Parse(commandToken[2]));
                        break;
                }
            }

            if (vehicleType == "Truck")
            {
                switch (commandToken[0])
                {
                    case "Drive":
                        truck.TryDrive(double.Parse(commandToken[2]));
                        break;
                    case "Refuel":
                        truck.Refuel(double.Parse(commandToken[2]));
                        break;
                }
            }
        }
    }
}

