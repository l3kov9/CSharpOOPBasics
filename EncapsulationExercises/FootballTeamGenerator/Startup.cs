using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Startup
    {
        public static void Main()
        {
            var teams=new List<Team>();

            while (true)
            {
                var commands = Console.ReadLine()
                    .Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "END")
                {
                    break;
                }

                if (commands[0] == "Team")
                {
                    var team=new Team(commands[1]);
                    teams.Add(team);
                }

                if (commands[0] == "Add")
                {
                    teams
                        .FirstOrDefault(x=>x.Name==commands[1])
                        .AddPlayer(new Player(commands[2],new PlayerStats(int.Parse(commands[3]),int.Parse(commands[4])
                        , int.Parse(commands[5]), int.Parse(commands[6]), int.Parse(commands[7]))));
                }

                if (commands[0] == "Remove")
                {
                    teams.FirstOrDefault(x=>x.Name==commands[1])
                        .RemovePlayer(commands[2]);
                }

                if (commands[0] == "Rating")
                {
                    var rating=teams.FirstOrDefault(x => x.Name == commands[1])
                        .Rating;
                    Console.WriteLine($"{commands[1]} - {rating}");
                }
            }
        }
    }
}
