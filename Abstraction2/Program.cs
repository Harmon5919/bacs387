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
            List<Person> teamOnePlayers = new List<Person>();
            teamOnePlayers.Add(new Person(1, new Location(4, 4)));
            teamOnePlayers.Add(new Person(2, new Location(0, 2)));
            teamOnePlayers.Add(new Person(3, new Location(-4, 4)));

            List<Person> teamTwoPlayers = new List<Person>();
            teamTwoPlayers.Add(new Person(1, new Location(-4, -4)));
            teamTwoPlayers.Add(new Person(2, new Location(0, -2)));
            teamTwoPlayers.Add(new Person(3, new Location(4, -4)));

            Court thisCourt = new Court(new Location(-5, 5), new Location(0, 0));
            Game game1 = new Game(teamOnePlayers, teamTwoPlayers, thisCourt);
            game1.GetPlayerList();
            game1.GetDistance();
            if (thisCourt.GetScore() == false)
            {
                Console.WriteLine("A basket has not been scored");
            }
            else
            {
                Console.WriteLine("A basket has been scored");
            }
            Console.ReadKey();
        }
    }
}
