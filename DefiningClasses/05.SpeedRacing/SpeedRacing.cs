using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars=new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var fuel = double.Parse(tokens[1]);
                var fuelCost = double.Parse(tokens[2]);

                var car=new Car(model,fuel,fuelCost);

                cars.Add(car);
            }


            while (true)
            {
                var commandDrive = Console.ReadLine()
                    .Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries);
                if (commandDrive[0] == "End")
                {
                    break;
                }

                var carModel = commandDrive[1];
                var amountOfKilometers = int.Parse(commandDrive[2]);
                var carToDrive = cars.First(c => c.model == carModel);

                carToDrive.Drive(amountOfKilometers);
            }

            cars
                .ForEach(c=>Console.WriteLine($"{c.model} {c.fuel:f2} {c.distanceTraveled}"));
        }
    }
}
