using System;

namespace Shop
{
    public class Fruits :Product
    {
        public Fruits(string name, decimal price, string nationality,int quantity) 
            : base(name, price, quantity)
        {
            this.Nationality = nationality;
        }

        public string Nationality { get; set; }

        public override string ProductInfo()
        {
            return base.ProductInfo() + Environment.NewLine + $"Nationality: {this.Nationality}";
        }
    }
}
