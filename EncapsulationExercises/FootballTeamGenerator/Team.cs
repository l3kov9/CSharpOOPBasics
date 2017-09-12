using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> Footballers;
        private int rating;

        public string Name { get; }
        public int Rating { get; }

        public Team(string name)
        {
            this.name = name;
            this.Footballers=new List<Player>();
            this.rating = rating;
        }

        public void AddPlayer(Player player)
        {
            this.Footballers.Add(player);
        }

        public void RemovePlayer(string name)
        {
            this.Footballers.Remove(Footballers.FirstOrDefault(x=>x.Name==name));
        }
    }
}
