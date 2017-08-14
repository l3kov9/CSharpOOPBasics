using System;

namespace Football
{
    public class Football
    {
        public static void Main()
        {
            var player=new Player();

            player.name = "Emil Lekov";
            player.age = 28;
            player.team.name = "Manchester United";
            player.team.yearFound = 1878;
            player.team.players.Add(player);
            player.team.players.Add(player);

            foreach (var footballer in player.team.players)
            {
                Console.WriteLine($"{footballer.name} - Age: {footballer.age}, " +
                                  $"Team: {footballer.team.name}\nYear Found:{footballer.team.yearFound}\n" +
                                  $"Total Footballers: {string.Join(", ",footballer.team.players.Count)}\n");
            }
        }
    }
}
