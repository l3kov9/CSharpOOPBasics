﻿using System;
using System.Text;

namespace _02.BookShop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get { return this.author; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name.");
                }
                this.author = value;
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Invalid title.");
                }
                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid.");
                }
                this.price=value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine(this.GetType().Name)
                .Append("Title: ").AppendLine(this.Title)
                .Append("Author: ").AppendLine(this.Author)
                .Append("Price: ").Append($"{this.Price:f1}")
                .AppendLine();

            return sb.ToString();
        }


    }
}
