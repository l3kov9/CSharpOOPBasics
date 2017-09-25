using System;

namespace Shop
{
    public abstract class Product
    {
        private string name;
        private decimal price;
        public int quantity { get; set; }

        public Product(string name, decimal price,int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name of the product must be more than 3 letters.");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get => this.price;
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("The price must be between 0 and 100 leva.");
                }
                this.price = value;
            }
        }

        public virtual string ProductInfo()
        {
            return $"Product name: {this.name} \nPrice: {this.price:f2}";
        }

        public void Buy(int quantityToBuy)
        {
            if (this.quantity >= quantityToBuy)
            {
                this.quantity -= quantityToBuy;
                Console.WriteLine($"{quantityToBuy} {GetType().Name} Bought");
            }
            else
            {
                Console.WriteLine($"Only {this.quantity} {GetType().Name} left");
                this.quantity = 0;
            }
        }
    }
}
