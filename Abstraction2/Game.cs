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

        public void GetPlayerList()
        {
            Console.WriteLine("Team One:");
            foreach (Person n in Team1)
            {
                Console.WriteLine("Player " + n.ID + ": (" + n.XY.Xlocation + "," + n.XY.Ylocation + ")");
            }
            Console.WriteLine("Team Two:");

            foreach (Person n in Team2)
            {
                Console.WriteLine("Player " + n.ID + ": (" + n.XY.Xlocation + "," + n.XY.Ylocation + ")");
            }
        }

        public void GetDistance()
        {
            double distance = 0;
            List<double> team1Ascend = new List<double>();
            List<double> team2Ascend = new List<double>();
            foreach (Person n in Team1)
            {
                distance = Math.Sqrt((n.XY.Xlocation - this.ThisCourt.Referee.Xlocation) * (n.XY.Xlocation - this.ThisCourt.Referee.Xlocation) 
                    + (n.XY.Ylocation - this.ThisCourt.Referee.Ylocation) * (n.XY.Ylocation - this.ThisCourt.Referee.Ylocation));
                team1Ascend.Add(distance);
            }
            foreach (Person x in Team2)
            {
                distance = Math.Sqrt((x.XY.Xlocation - this.ThisCourt.Referee.Xlocation) * (x.XY.Xlocation - this.ThisCourt.Referee.Xlocation)
                    + (x.XY.Ylocation - this.ThisCourt.Referee.Ylocation) * (x.XY.Ylocation - this.ThisCourt.Referee.Ylocation));
                team2Ascend.Add(distance);
            }
            team1Ascend.Sort();
            Console.WriteLine("Team One has players at these distances from the referee:");
            foreach (double n in team1Ascend)
            {
                Console.WriteLine(n);
            }
            team2Ascend.Sort();
            Console.WriteLine("Team Two has players at these distances from the referee:");
            foreach (double x in team2Ascend)
            {
                Console.WriteLine(x);
            }
        }
    }
}
