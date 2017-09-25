namespace Shop
{
    public class SummerFruit : Fruits
    {
        public SummerFruit(string name, decimal price, string nationality,int quantity) 
            : base(name, price*0.95m, nationality,quantity)
        {
        }
    }
}
