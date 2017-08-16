namespace _04.BeerCounter
{
    public class BeerCounter
    {
        private static int beerInStock;
        private static int beersDrankCount;

        public static int BeerInStock
        {
            get { return BeerCounter.beerInStock; }
            set { BeerCounter.BeerInStock = value; }
        }

        public static int BeersDrankCount
        {
            get { return BeerCounter.beersDrankCount; }
            set { BeerCounter.beersDrankCount = value; }
        }

        public static void BuyBeer(int bottlesCount)
        {
            BeerCounter.beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            BeerCounter.beerInStock -= bottlesCount;
            BeerCounter.beersDrankCount += bottlesCount;
        }
    }
}
