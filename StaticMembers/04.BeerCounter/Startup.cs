using System;
using System.Linq;

namespace _04.BeerCounter
{
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                var drinkingCommand = Console.ReadLine();
                if (drinkingCommand == "End")
                {
                    break;
                }

                var beers = drinkingCommand
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                BeerCounter.BuyBeer(beers[0]);
                BeerCounter.DrinkBeer(beers[1]);
            }

            Console.WriteLine($"{BeerCounter.BeerInStock} {BeerCounter.BeersDrankCount}");
        }
    }
}
