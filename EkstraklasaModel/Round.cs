using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class Round
    {
        public int RoundId { get; set; }
        public List<Match> Matches { get; } = new();
        public DateTime RoundStart { get; set; }
        public DateTime RoundEnd { get; set; }
        //public void AddMatch(Match match)
        //{
        //    Matches.Add(match);
        //}

        //public Round(DateTime roundStart, DateTime roundEnd)
        //{
        //    RoundStart = roundStart;
        //    RoundEnd = roundEnd;
        //}

        //public Round(Round FirstRound)
        //{
        //    foreach (Match match in FirstRound.Matches)
        //    {
        //        Matches.Add(new Match(match.Visitor, match.Host));
        //    }
        //}

    }
}
