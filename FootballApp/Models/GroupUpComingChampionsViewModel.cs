using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballApp.Models
{
    public class GroupUpComingChampionsViewModel
    {
        public List<ChampionsGroupStage.Standing> ListGroupStage { get; set; }
        public List<UpComingMatchesChampions.Match> ListUpComingMatches { get; set; }
    }
}