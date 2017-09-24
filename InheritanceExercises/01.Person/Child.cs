﻿using System;

namespace _01.Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get { return base.Age; }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15 years.");
                }
                base.Age = value;
            }
        }

        public override string Name
        {
            get { return base.Name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("The name must be more than 3 letters.");
                }
                base.Name = value;
            }
        }
    }
}