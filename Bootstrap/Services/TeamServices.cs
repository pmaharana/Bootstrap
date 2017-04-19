using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.DataContext;
using Bootstrap.Models;

namespace Bootstrap.Services
{
    public class TeamServices
    {
        public LeagueContext db = new LeagueContext();

        public List<Teams> GetAllTeams()
        {
            var teams = db.Teams.ToList();
            return teams;
        }

    }
}