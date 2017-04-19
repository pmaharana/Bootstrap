using Bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.ViewModel
{
    public class MainPage
    {
        public List<Sports> ListOfSports { get; set; }
        public List<Teams> ListOfTeams { get; set; }
        public List<Games> GameRecords { get; set; }

    }
}