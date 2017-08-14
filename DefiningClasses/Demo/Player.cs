public class Player
{
    public Player()
    {
        this.team=new Team();
        this.firstName = "Unknown first name";
        this.lastName = "Unknown last name";
        this.age = 0;
    }

    public string firstName;
    public string lastName;
    public int age;
    public Team team;
}

