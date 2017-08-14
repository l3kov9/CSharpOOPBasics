using System.Collections.Generic;

namespace Football
{
    public class Team
    {
        public string name;
        public int yearFound;
        public List<Player> players;

        public Team()
        {
            this.name = "Unknown name";
            this.yearFound = 2000;
            this.players=new List<Player>();
        }
    }
}
