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
            List<Player> teamOneBBall = new List<Player>();
            teamOneBBall.Add(new Player("point guard", 1, new Location(4, 4)));
            teamOneBBall.Add(new Player("small forward", 2, new Location(0, 2)));
            teamOneBBall.Add(new Player("center", 3, new Location(-4, 4)));

            List<Player> teamTwoBBall = new List<Player>();
            teamTwoBBall.Add(new Player("point guard", 1, new Location(-4, -4)));
            teamTwoBBall.Add(new Player("small forward", 2, new Location(0, -2)));
            teamTwoBBall.Add(new Player("center", 3, new Location(4, -4)));

            Court basketCourt = new Court(new Location(-5, 5), new Location(0, 0));
            Game basketball1 = new Game("basketball 1", teamOneBBall, teamTwoBBall, basketCourt);
            Console.WriteLine(basketball1.GameType);
            basketball1.GetPlayerList();
            basketball1.GetDistance();
            basketCourt.GetScore();
            Console.WriteLine("\n");

            List<Player> teamOneFlag = new List<Player>();
            teamOneFlag.Add(new Player("running back", 1, new Location(4, 4)));
            teamOneFlag.Add(new Player("safety", 2, new Location(0, 2)));
            teamOneFlag.Add(new Player("center", 3, new Location(-4, 4)));

            List<Player> teamTwoFlag = new List<Player>();
            teamTwoFlag.Add(new Player("running back", 1, new Location(-4, -4)));
            teamTwoFlag.Add(new Player("safety", 2, new Location(0, -2)));
            teamTwoFlag.Add(new Player("center", 3, new Location(4, -4)));

            Court flagField = new Court(new Location(-5, 5), new Location(0, 0));
            Game flagFootBall1 = new Game("flag football 1", teamOneFlag, teamTwoFlag, flagField);
            Console.WriteLine(flagFootBall1.GameType);
            flagFootBall1.GetPlayerList();
            flagFootBall1.GetDistance();
            flagField.GetScore();
            Console.WriteLine("\n");

            List<Player> teamOneSoccer = new List<Player>();
            teamOneSoccer.Add(new Player("running back", 1, new Location(4, 4)));
            teamOneSoccer.Add(new Player("safety", 2, new Location(0, 2)));
            teamOneSoccer.Add(new Player("center", 3, new Location(-4, 4)));

            List<Player> teamTwoSoccer = new List<Player>();
            teamTwoSoccer.Add(new Player("running back", 1, new Location(-4, -4)));
            teamTwoSoccer.Add(new Player("safety", 2, new Location(0, -2)));
            teamTwoSoccer.Add(new Player("center", 3, new Location(4, -4)));

            Court soccerField = new Court(new Location(-5, 5), new Location(0, 0));
            Game soccer1 = new Game("soccer 1", teamOneSoccer, teamTwoSoccer, soccerField);
            Console.WriteLine(soccer1.GameType);
            soccer1.GetPlayerList();
            soccer1.GetDistance();
            soccerField.GetScore();

            Console.ReadKey();
        }
    }
}
