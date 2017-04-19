using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bootstrap.ViewModel;
using Bootstrap.Models;
using Bootstrap.Services;
using Bootstrap.DataContext;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public LeagueContext db = new LeagueContext();

        public SportServices sportServices = new SportServices();
        public TeamServices teamServices = new TeamServices();
        public GameServices gameServices = new GameServices();

        

        public ActionResult Index()
        {
            var sports = sportServices.GetAllSports();
            var teams = teamServices.GetAllTeams();
            var games = gameServices.GetAllGames();

            var vm = new MainPage(sports, teams, games);

            return View(vm);
        }

        //public ActionResult Index()
        //{
        //    var vm = new MainPage
        //    {
        //        ListOfTeams = new List<Teams>
        //        {
        //            new Teams {Name = "a"},

        //            new Teams {Name = "a"},

        //            new Teams {Name = "a"},

        //            new Teams {Name = "a"},
        //        }
        //    };

        //    var name = vm.ListOfTeams.Count;

        //    return View(vm);
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}