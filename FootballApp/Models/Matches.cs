using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApp.Models
{
    public class Matches
    {
        public Competition Competitions { get; set; }
        [JsonProperty("matches")]
        public List<Match> AllMatches { get; set; }

        public class Area
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Competition
        {
            public Area Area { get; set; }
            public string Name { get; set; }
        }

        public class FullTime
        {
            public int HomeTeam { get; set; }
            public int AwayTeam { get; set; }
        }

        public class Score
        {
            public FullTime FullTime { get; set; }
        }

        public class HomeTeam
        {
            public string Name { get; set; }
        }

        public class AwayTeam
        {
            public string Name { get; set; }
        }

        public class Match
        {
            public int Id { get; set; }
            public DateTime UtcDate { get; set; }
            public int Matchday { get; set; }
            public Score Score { get; set; }
            public HomeTeam HomeTeam { get; set; }
            public AwayTeam AwayTeam { get; set; }
        }        
    }
}