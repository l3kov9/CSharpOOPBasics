using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products=new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new NullReferenceException($"{nameof(Name)} cannot be empty.");
                }
                this.name = value;
            }
        }

        private decimal Money
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative.");
                }

                this.money = value;
            }
        }

        public List<Product> Products { get; }

        public bool BuyProduct(Product product)
        {
            if (this.money >= product.Price)
            {
                this.Products.Add(product);
                this.money -= product.Price;
                return true;
            }

            return false;
        }
    }
}
