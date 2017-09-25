using System;

namespace Shop
{
    public class Chocolate : Product
    {
        private int calories;

        public Chocolate(string name, decimal price, int calories,int quantity) 
            : base(name, price, quantity)
        {
            this.calories = calories;
        }

        public override string ProductInfo()
        {
            return base.ProductInfo() + Environment.NewLine + $"Calories: {this.calories}\nQuantity: {this.quantity}";
        }
    }
}
