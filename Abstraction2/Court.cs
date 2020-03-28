using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2
{
    class Court
    {
        public Court(Location referee, Location ball)
        {
            this.Referee = referee;
            this.Ball = referee;
        }
        public Location Referee { get; set; }
        public Location Ball { get; set; }
  
        public bool GetScore()
        {
            bool score = false;
            List<Location> teamOneGoal = new List<Location>();
            teamOneGoal.Add(new Location(-1, -5));
            teamOneGoal.Add(new Location(0, -5));
            teamOneGoal.Add(new Location(1, -5));
            teamOneGoal.Add(new Location(-1, -4));
            teamOneGoal.Add(new Location(0, -4));
            teamOneGoal.Add(new Location(1, -4));
            List<Location> teamTwoGoal = new List<Location>();
            teamTwoGoal.Add(new Location(-1, 5));
            teamTwoGoal.Add(new Location(0, 5));
            teamTwoGoal.Add(new Location(1, 5));
            teamTwoGoal.Add(new Location(-1, 4));
            teamTwoGoal.Add(new Location(0, 4));
            teamTwoGoal.Add(new Location(1, 4));

            foreach (Location n in teamOneGoal)
            {
                
                if (this.Ball.Xlocation == n.Xlocation && this.Ball.Ylocation == n.Ylocation)
                {
                    score = true;
                }
            }
            foreach (Location x in teamTwoGoal)
            {
                if (this.Ball.Xlocation == x.Xlocation && this.Ball.Ylocation == x.Ylocation)
                {
                    score = true;
                }
            }
            if (score == false)
            {
                Console.WriteLine("A goal has not been scored");
            }
            else
            {
                Console.WriteLine("A goal has been scored");
            }
            return score;
        }
    }
}
