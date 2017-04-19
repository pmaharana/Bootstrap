using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class Games
    {
        public int Id { get; set; }

        public int? HomeTeamId { get; set; }
        public Teams HomeTeam { get; set; }

        public int? AwayTeamId { get; set; }
        public Teams AwayTeam { get; set; }

        public string Score { get; set; }



    }
    
}