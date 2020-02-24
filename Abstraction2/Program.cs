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
            teamOnePlayers.Add(new Person(new Location(1,1))); 
            teamOnePlayers.Add(new Person(new Location(2, 2)));
            teamOnePlayers.Add(new Person(new Location(3, 3)));
            List<Person> teamTwoPlayers = new List<Person>();
            teamTwoPlayers.Add(new Person(new Location(4, 4)));
            teamTwoPlayers.Add(new Person(new Location(5, 5)));
            teamTwoPlayers.Add(new Person(new Location(6, 6)));
            List<Location> teamOneBasket = new List<Location>();
            teamOneBasket.Add(new Location(-1, -5));
            teamOneBasket.Add(new Location(0, -5));
            teamOneBasket.Add(new Location(1, -5));
            teamOneBasket.Add(new Location(-1, -4));
            teamOneBasket.Add(new Location(0, -4));
            teamOneBasket.Add(new Location(1, -4));
            List<Location> teamTwoBasket = new List<Location>();
            teamTwoBasket.Add(new Location(-1, 5));
            teamTwoBasket.Add(new Location(0, 5));
            teamTwoBasket.Add(new Location(1, 5));
            teamTwoBasket.Add(new Location(-1, 4));
            teamTwoBasket.Add(new Location(0, 4));
            teamTwoBasket.Add(new Location(1, 4));
            Location ball = new Location(0, 0);
            Person reff = new Person(new Location(5, 5));
            Game game1 = new Game(teamOnePlayers, teamTwoPlayers, teamOneBasket, teamTwoBasket, reff, ball);
            

        }
    }
}
