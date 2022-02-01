using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerOOP
{
    public class Team
    {
        public Team(List<Footballer> cfootballers) 
        {
            this.footballers = cfootballers;
        }

        public string Name { get; set; }
        public int Overall { get; set; }
        List<Footballer> footballers = new List<Footballer>();

        public int calculateTeamOverall(Team team) 
        {
            int teamOverall = 0;
            foreach (var footballer in team.footballers)
            {
                teamOverall += footballer.Overall;
            }
            teamOverall = teamOverall / footballers.Count;
            return teamOverall;
        }

        public int Match(Team home,Team away) 
        {
            int result=0;

            home.Overall = calculateTeamOverall(home);
            away.Overall = calculateTeamOverall(away);


            ///1 Home winner
            ///0 Draw
            ///2 Away winner
            return result;
        }



    }

    public class Fenerbahce : Team 
    {
        public Fenerbahce(List<Footballer> footballers) : base(footballers)
        {
            
        }
    }

    public class Galatasaray : Team
    {
        public Galatasaray(List<Footballer> footballers) : base(footballers)
        {

        }
    }

}
