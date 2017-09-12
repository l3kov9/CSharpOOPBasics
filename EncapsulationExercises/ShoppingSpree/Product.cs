﻿using System;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty.");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Price)} cannot be nagative.");
                }
                this.price = value;
            }
        }
    }
}
