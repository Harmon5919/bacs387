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
            bool Score = false;
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

            foreach (Location n in teamOneBasket)
            {
                
                if (this.Ball.Xlocation == n.Xlocation && this.Ball.Ylocation == n.Ylocation)
                {
                    Score = true;
                }
            }
            foreach (Location x in teamTwoBasket)
            {
                if (this.Ball.Xlocation == x.Xlocation && this.Ball.Ylocation == x.Ylocation)
                {
                    Score = true;
                }
            }
            return Score;
        }
    }
}
