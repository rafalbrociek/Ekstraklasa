using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class PredictedResult
    {
        public int PredictedResultId { get; set; }
        public Match Match { get; set; }
        public int PredictedHostGoals { get; set; }
        public int PredictedVisitorGoals { get; set; }
        //public PredictedResult(Match match, int hostGoals, int visitorGoals)
        //{
        //    Match = match;
        //    PredictedHostGoals = hostGoals;
        //    PredictedVisitorGoals = visitorGoals;
        //}
    }
}
