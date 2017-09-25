namespace _02.WildFarm
{
    public abstract class Food
    {
        public int quantity { get; set; }

        public Food(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
