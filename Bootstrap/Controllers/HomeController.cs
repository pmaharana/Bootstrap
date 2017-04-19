using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bootstrap.ViewModel;
using Bootstrap.Models;

namespace Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new MainPage
            {
                ListOfTeams = new List<Teams>
                {
                    new Teams {Name = "a"},

                    new Teams {Name = "a"},

                    new Teams {Name = "a"},

                    new Teams {Name = "a"},
                }
            };
            return View(vm);
        }

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