using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Location> teamOnePlayers = new List<Location>();
            teamOnePlayers.Add(new Location(4, 4));
            teamOnePlayers.Add(new Location(0, 2));
            teamOnePlayers.Add(new Location(-4, 4));

            List<Location> teamTwoPlayers = new List<Location>();
            teamTwoPlayers.Add(new Location(-4, -4));
            teamTwoPlayers.Add(new Location(0, -2));
            teamTwoPlayers.Add(new Location(4, -4));

            Court thisCourt = new Court(new Location(-5, 5), new Location(0, 0));
            Game game1 = new Game(teamOnePlayers, teamTwoPlayers, thisCourt);

            Console.WriteLine("Team one player locations:");
            foreach(Location n in )


            Console.ReadKey();
        }
    }
}
