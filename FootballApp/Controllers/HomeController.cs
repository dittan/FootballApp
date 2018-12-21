using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballApp.Models;
using Newtonsoft.Json;
using RestSharp;

namespace FootballApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teams()
        {
            return View();
        }

        public ActionResult Matches()
        {
            var client = new RestClient("http://api.football-data.org/");

            var request = new RestRequest("v2/competitions/PL/matches?status=FINISHED", Method.GET);    
            request.AddHeader("X-Auth-Token", "89b1396c62ff41119cabd0a504ec09bf");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var match = JsonConvert.DeserializeObject<Matches>(content);
            var matches = match.AllMatches;
            matches.Reverse();

            return View(matches);
        }

        public ActionResult LiveMatches()
        {
            return View();
        }

        public ActionResult StandingsCl()
        {
            var getGroupstandings = GetClGroupStage();
            var getUpComingMatches = GetUpComingClMatches();

            GroupUpComingChampionsViewModel model = new GroupUpComingChampionsViewModel();
            model.ListGroupStage = getGroupstandings;
            model.ListUpComingMatches = getUpComingMatches;

            return View(model);
        }

        public List<ChampionsGroupStage.Standing> GetClGroupStage()
        {
            var client = new RestClient("http://api.football-data.org/");

            var request = new RestRequest("v2/competitions/CL/standings?standingType=TOTAL", Method.GET);
            request.AddHeader("X-Auth-Token", "89b1396c62ff41119cabd0a504ec09bf");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var standing = JsonConvert.DeserializeObject<ChampionsGroupStage>(content);
            var standings = standing.Standings;

            return standings;
        }

        public List<UpComingMatchesChampions.Match> GetUpComingClMatches()
        {
            var client = new RestClient("http://api.football-data.org/");

            var request = new RestRequest("v2/competitions/CL/matches?status=SCHEDULED&limit=1", Method.GET);
            request.AddHeader("X-Auth-Token", "89b1396c62ff41119cabd0a504ec09bf");

            IRestResponse response = client.Execute(request);
            var content = response.Content;

            var match = JsonConvert.DeserializeObject<UpComingMatchesChampions>(content);
            var matches = match.Matches;

            return matches;
        }
    }
}