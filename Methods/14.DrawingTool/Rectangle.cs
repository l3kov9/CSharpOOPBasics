using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DrawingTool
{
    public class Rectangle 
        :Shape
    {
        private int length;
        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public override void Draw()
        {
            
        }
    }
}
