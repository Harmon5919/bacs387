using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Game
    {
        public Game(List<Location> team1, List<Location> team2, Court thisCourt)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.ThisCourt = thisCourt;
        }
        public List<Location> Team1 { get; set; }
        public List<Location> Team2 { get; set; }
        public Court ThisCourt { get; set; }
        public void GetPlayerList()
        {
            Console.WriteLine("Team One:");
            foreach (Location n in Team1)
            {
                Console.WriteLine("Player " + n + ": (" + n.Xlocation + "," + n.Ylocation + ")");
            }
            Console.WriteLine("Team Two:");
            foreach (Location n in Team2)
            {
                Console.WriteLine("Player " + n + ": (" + n.Xlocation + "," + n.Ylocation + ")");
            }
        }
        public void GetDistance()
        {
            double distance = 0;
            foreach (Location n in Team1)
            {
                distance = Math.Sqrt((n.Xlocation - this.ThisCourt.Referee.Xlocation) * (n.Xlocation - this.ThisCourt.Referee.Xlocation) 
                    + (n.Ylocation - this.ThisCourt.Referee.Ylocation) * (n.Ylocation - this.ThisCourt.Referee.Ylocation));
                Console.WriteLine("Player " + n + " is " + distance + " from the referee");
            }
        }
    }
}
