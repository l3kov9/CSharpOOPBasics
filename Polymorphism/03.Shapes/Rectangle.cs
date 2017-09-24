namespace _03.Shapes
{
    public class Rectangle : Shape
    {
        private int height;

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        private int width;

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return this.Height * 2 + this.Width * 2;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
