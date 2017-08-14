namespace Football
{
    public class Player
    {
        public string name;
        public int age;
        public Team team;

        public Player()
        {
            this.name = "Unknown name";
            this.age = 0;
            this.team=new Team();
        }
    }
}
