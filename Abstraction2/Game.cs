using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Game
    {
        public Game(List<Person> team1, List<Person> team2, Court thisCourt)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.ThisCourt = thisCourt;
        }
        public List<Person> Team1 { get; set; }
        public List<Person> Team2 { get; set; }
        public Court ThisCourt { get; set; }
        public double GetDistance()
        {
            double xdistance = 0;
            double ydistance = 0;
            double distance = 0;
            xdistance = (this.ThisCourt.Referee.Xlocation) - (this.ThisCourt.Team1[1].XY.XLocation);
            return distance;
        }
    }
}
