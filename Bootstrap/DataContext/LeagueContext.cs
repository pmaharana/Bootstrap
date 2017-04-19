using Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bootstrap.DataContext
{
    public class LeagueContext :DbContext
    {
        public LeagueContext():base()
        {

        }

        public DbSet<Games> Games { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Teams> Teams { get; set; }

    }
}