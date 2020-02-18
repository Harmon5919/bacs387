using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> playerList = new List<Person>();
            playerList.Add(new Person("Hanna", 24, "Coach"));
            playerList.Add(new Person("Josh", 23, "Quarterback"));
            playerList.Add(new Person("Bob", 30, "Runningback"));
            playerList.Add(new Person("Liz", 19, "Runningback"));
            playerList.Add(new Person("Mary", 21, "Wide Receiver"));
            playerList.Add(new Person("Greg", 32, "Wide Receiver"));
            playerList.Add(new Person("John", 43, "Tight End"));
            playerList.Add(new Person("David", 50, "Cornerback"));
            playerList.Add(new Person("Phil", 36, "Cornerback"));
            playerList.Add(new Person("Seth", 45, "Safety"));
            playerList.Add(new Person("Kevin", 23, "Safety"));
            playerList.Add(new Person("Kyle", 18, "Defensive Tackle"));
            playerList.Add(new Person("Heather", 29, "Defensive End"));
            playerList.Add(new Person("Marcia", 38, "Line Backer"));
            playerList.Add(new Person("Tara", 41, "Kicker"));

            Team Bears = new Team("Bears", "Greeley", playerList);
            Console.WriteLine("Player list for the " + Bears.TeamName + " is:");
            foreach (Person x in playerList)
            {
                Console.WriteLine(x.Name + " " + x.Age + " " + x.Position);
            }
            Console.ReadKey();
        }
    }
}
