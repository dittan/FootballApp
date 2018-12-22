using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApp.Models
{
    public class UpComingMatchesChampions
    {
        public int Count { get; set; }
        public Competition Competitions { get; set; }
        public List<Match> Matches { get; set; }

        public class Area
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Competition
        {
            public int Id { get; set; }
            public Area Area { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public string Plan { get; set; }
            public DateTime LastUpdated { get; set; }
        }

        public class HomeTeam
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class AwayTeam
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Match
        {
            public int Id { get; set; }
            public DateTime UtcDate { get; set; }
            public string Status { get; set; }
            public int Matchday { get; set; }
            public string Stage { get; set; }
            public object Group { get; set; }
            public DateTime LastUpdated { get; set; }
            public HomeTeam HomeTeam { get; set; }
            public AwayTeam AwayTeam { get; set; }
        }
    }
}