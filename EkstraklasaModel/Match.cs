using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class Match
    {
        public int MatchId { get; set; }
        public Team Host { get; set; }
        public Team Visitor { get; set; }
        public DateTime Date { get; set; }
        public int? CountHostGoals { get; set; } = null;
        public int? CountVisitorGoals { get; set; } = null;

        public List<Bet> Bets { get; } = new();

        //public Match(Team host, Team visitor, DateTime date, int countHostGoals, int countVisitorGoals) 
        //{ 
        //    Host = host;
        //    Visitor = visitor;
        //    Date = date;
        //}

        //public Match(Team host, Team visitor)
        //{
        //    Host = host;
        //    Visitor = visitor;
        //}

        //public void SetResult(int countHostGoals, int countVisitorGoals)
        //{
        //    CountHostGoals = countHostGoals;
        //    CountVisitorGoals = countVisitorGoals;
        //}
    }
}
