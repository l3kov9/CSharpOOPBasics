using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    public class RawData
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var cars=new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var model = tokens[0];
                var engineSpeed = double.Parse(tokens[1]);
                var enginePower = double.Parse(tokens[2]);
                var cargoWeight = double.Parse(tokens[3]);
                var cargoType = tokens[4];
                
                var carEngine=new Engine(engineSpeed,enginePower);
                var carCargo=new Cargo(cargoWeight,cargoType);
                var tires=new Tire[4]
                {
                    new Tire(double.Parse(tokens[5]),int.Parse(tokens[6])),
                    new Tire(double.Parse(tokens[7]),int.Parse(tokens[8])),
                    new Tire(double.Parse(tokens[9]),int.Parse(tokens[10])),
                    new Tire(double.Parse(tokens[11]),int.Parse(tokens[12]))
                };

                var car =new Car(model, carEngine, carCargo, tires);
                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                cars
                    .Where(c=>c.cargo.cargoType=="fragile" && c.tyres.Any(x=>x.pressure<1))
                    .ToList()
                    .ForEach(c=>Console.WriteLine($"{c.model}"));
            }
            else if (command == "flamable")
            {
                cars.Where(c=>c.cargo.cargoType=="flamable" && c.engine.enginePower>250)
                    .ToList()
                    .ForEach(c=>Console.WriteLine($"{c.model}"));
            }
        }
    }
}
