using System.Collections.Generic;

public class Team
{
    public Team()
    {
        this.players=new List<Player>();
        this.name = "Unknown";
        this.yearFound = 2000;
    }

    public string name;
    public int yearFound;
    public List<Player> players;
}
