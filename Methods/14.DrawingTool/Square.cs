namespace _14.DrawingTool
{
    public class Square
        :Shape
    {
        private int side;

        public Square(int side)
        {
            this.side = side;
        }

        public int Side
        {
            get { return this.side; }
            set { this.side = value; }
        }

        public override void Draw()
        {
            
        }
    }
}
