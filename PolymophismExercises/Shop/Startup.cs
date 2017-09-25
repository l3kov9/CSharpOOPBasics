using System;

namespace Shop
{
    public class Startup
    {
        public static void Main()
        {
            var kiwi=new WinterFruits("Kiwi",2m,"Brazilian",13);
            Console.WriteLine(kiwi.ProductInfo());

            var snickers=new Chocolate("Snickers",1.10m,1144,19);
            snickers.Buy(22);
            Console.WriteLine(snickers.ProductInfo());
        }
    }
}
