using Bootstrap.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.Models;


namespace Bootstrap.Services
{
    public class GameServices
    {
        LeagueContext db = new LeagueContext();

        public List<Games> GetAllGames()
        {
            var games = db.Games.ToList();
            return games;
        }


    }
}