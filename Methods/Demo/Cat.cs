using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    public class Cat
    {
        private string name;
        private string color;
        private Position position;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
            this.position = new Position(0,0);
        }

        public string Name => this.name;

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string GetDescription()
        {
            return $"I am {this.name} and I have {this.color} color.";
        }

        public static int numberOfLegs()
        {
            return 4;
        }

        public Position Move(int xOffset, int yOffset)
        {
            this.position=new Position(this.position.X + xOffset, this.position.Y+yOffset);
            return this.position;
        }

        public override string ToString()
        {
            return
                $"Current Cat Position: x = {this.position.X}, y = {this.position.Y}.\nCat name: {this.name}, color: {this.Color}";
        }

        public void Attack(params Cat[] cats)
        {
            
        }
    }
}
