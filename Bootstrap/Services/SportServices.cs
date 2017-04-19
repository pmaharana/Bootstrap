using Bootstrap.DataContext;
using Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Services
{
    public class SportServices
    {
       public LeagueContext db = new LeagueContext();

        public List<Sports> GetAllSports()
        {
            var sports = db.Sports.ToList();
            return sports;
        }
    }
}