using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApp.Models
{
    public class ChampionsGroupStage
    {
        public Competition Competitions { get; set; }
        public Season Seasons { get; set; }
        public List<Standing> Standings { get; set; }

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

        public class Season
        {
            public int Id { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int CurrentMatchday { get; set; }
            public object Winner { get; set; }
        }

        public class Team
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string CrestUrl { get; set; }
        }

        public class Table
        {
            public int Position { get; set; }
            public Team Team { get; set; }
            public int PlayedGames { get; set; }
            public int Won { get; set; }
            public int Draw { get; set; }
            public int Lost { get; set; }
            public int Points { get; set; }
            public int GoalsFor { get; set; }
            public int GoalsAgainst { get; set; }
            public int GoalDifference { get; set; }
        }

        public class Standing
        {
            public string Stage { get; set; }
            public string Type { get; set; }
            public string Group { get; set; }
            public List<Table> Table { get; set; }
        }          
    }
}