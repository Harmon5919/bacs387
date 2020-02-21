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
            List<Location> court = new List<Location>();
            court.Add(new Location(0, 0));
            court.Add(new Location(0, 1));

            Person referee = new Person("Bob", "referee", new Location(0, 0));
            List<Person> teamOnePlayers = new List<Person>();
            teamOnePlayers.Add("Steve", "position1", );
            List<Game> game1 = new List<Game>();
            game1.Add("Bears", "Greeley", teamOnePlayers);
            

        }
    }
}
