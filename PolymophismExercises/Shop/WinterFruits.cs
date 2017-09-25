
namespace Shop
{
    public class WinterFruits : Fruits
    {
        public WinterFruits(string name, decimal price, string nationality,int quantity) 
            : base(name, price*1.15m, nationality,quantity)
        {
        }
    }
}
