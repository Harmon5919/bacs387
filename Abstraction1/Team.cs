using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    class Team
    {
        public Team(string teamName, string cityName, List<Person> teamList)
        {
            this.TeamName = teamName;
            this.CityName = cityName;
            this.TeamList = teamList;
        }
        public string TeamName { get; set; }
        public string CityName { get; set; }
        public List<Person> TeamList { get; set; }
    }
}
