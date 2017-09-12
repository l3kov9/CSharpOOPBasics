using System.Linq;

namespace FootballTeamGenerator
{
    public class PlayerStats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public PlayerStats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.endurance = endurance;
            this.sprint = sprint;
            this.dribble = dribble;
            this.passing = passing;
            this.shooting = shooting;
        }

        public int GetAveragePlayerStats()
        {
            var stats = new int[] {this.endurance, this.sprint, this.dribble, this.passing, this.shooting};
            return (int)stats.Average();
        }
    }
}
