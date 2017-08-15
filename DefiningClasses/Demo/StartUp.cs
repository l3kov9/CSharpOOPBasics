using System;
using System.Collections.Generic;
using System.Linq;
using Demo;

public class StartUp
{
    public static void Main()
    {
        var firstPlayer = new Player
        {
            age = 28,
            firstName = "Emil",
            lastName = "Lekov",
            team = new Team
            {
                name = "Man Utd",
                yearFound = 1878
                
            }
        };

        var team=new Team();
        team.players.Add(firstPlayer);

        Console.WriteLine(team.players.Where(x=>x.age==28).FirstOrDefault().team.name);

        var dice=new Dice(10);

        Console.WriteLine(dice.Roll());
    }
}

