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
            Console.WriteLine($"{team.Name} ovr : {teamOverall}");
            return teamOverall;
        }

        public void Match(Team home,Team away) 
        {
            
            home.Overall = calculateTeamOverall(home);
            away.Overall = calculateTeamOverall(away);

            matchAlgorithm(home,away);

            
            
        }

        private void matchAlgorithm(Team home, Team away)
        {
            int homeXG = 0, awayXG = 0; // Gol Beklentisi
            int homeScore = 0, awayScore = 0; //Skorlar

            int homeRnd=0, homePoint=0,awayRnd=0, awayPoint=0;

            //Because of match is 90 minutes
            for (int i = 0; i < 89; i++)
            {

                for (int j = 0; j < 59; j++)
                {
                    Random rnd = new Random();
                    homeRnd = rnd.Next(1, home.Overall + 1);
                    homePoint = home.Overall * homeRnd;

                    Random rnd2 = new Random();
                    awayRnd = rnd2.Next(1, away.Overall + 1);
                    awayPoint = away.Overall * awayRnd;
                }
                

                if (homePoint > awayPoint)
                {
                    homeXG++;
                }
                else if (awayPoint > homePoint)
                {
                    awayXG++;
                }

                if (homeXG >= 15)
                {
                    Random rndSayi = new Random();
                    int sayi = rndSayi.Next(3);
                    if (sayi>=2)
                    {
                        homeScore++;
                    }
                    homeXG = 0; 
                }
                else if (awayXG >= 15)
                {
                    Random rndSayi = new Random();
                    int sayi = rndSayi.Next(3);
                    if (sayi>=2)
                    {
                        awayScore++;
                    }
                    awayXG = 0;
                }

            }

            Console.WriteLine($"Maç Skoru : {home.Name} {homeScore} - {awayScore} {away.Name}  ");

        }
    }

    public class Fenerbahce : Team 
    {
        
        public Fenerbahce(List<Footballer> footballers) : base(footballers)
        {
            Name = "Fenerbahçe";
        }
    }

    public class Galatasaray : Team
    {
        public Galatasaray(List<Footballer> footballers) : base(footballers)
        {
            Name = "Galatasaray";
        }
    }

}
