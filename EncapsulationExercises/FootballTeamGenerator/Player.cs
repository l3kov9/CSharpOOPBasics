namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int stats;

        public Player(string name, PlayerStats playerStats)
        {
            this.name = name;
            this.stats = playerStats.GetAveragePlayerStats();
        }

        public string Name { get { return this.name; } }
        public int Stats { get { return this.stats; } }
    }
}
