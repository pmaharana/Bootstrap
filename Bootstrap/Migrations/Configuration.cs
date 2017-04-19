namespace Bootstrap.Migrations
{
    using Bootstrap.DataContext;
    using Bootstrap.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bootstrap.DataContext.LeagueContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        LeagueContext db = new LeagueContext();

        protected override void Seed(Bootstrap.DataContext.LeagueContext db)
        {
            var sports = new List<Sports>
            {
                new Sports{Name = "Basketball"},
                new Sports{Name = "Baseball"},
                new Sports{Name = "Ping Pong"},
                new Sports{Name = "Football"},
                new Sports{Name = "Golf"},
                new Sports{Name = "Darts"},
                new Sports{Name = "Quidditch"},
            };

            sports.ForEach(s => db.Sports.AddOrUpdate(o => o.Name, s));
            

            var teams = new List<Teams>
            {
                new Teams{Name = "Lucca Goers", NumberOfPlayers=11, SportId=3},
                new Teams{Name = "Ruby Railways", NumberOfPlayers=13, SportId=1},
                new Teams{Name = "The Sea Sharpers", NumberOfPlayers=5, SportId=2},
                new Teams{Name = "Yugioh Duelists", NumberOfPlayers=4, SportId=4},
                new Teams{Name = "Vegeta's Destroyers", NumberOfPlayers=6, SportId=6},
            };

            teams.ForEach(s => db.Teams.AddOrUpdate(o => o.Name, s));

            var games = new List<Games>
            {
                new Games{HomeTeamId=3, AwayTeamId=1, Score="32-11"},
                new Games{HomeTeamId=1, AwayTeamId=2, Score="100-7"},
                new Games{HomeTeamId=4, AwayTeamId=3, Score="46-45"},
                new Games{HomeTeamId=2, AwayTeamId=4, Score="97-82"},
            };

            games.ForEach(s => db.Games.AddOrUpdate(o => o.Score, s));
            db.SaveChanges();


        }
    }
}
