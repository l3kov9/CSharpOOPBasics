namespace _14.DrawingTool
{
    public class CorDraw
    {
        public CorDraw(Shape shape)
        {
            this.Draw(shape);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }
}
