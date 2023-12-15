using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class PredictedResult
    {
        public Match Match { get; }
        public int PredictedHostGoals { get; }
        public int PredictedVisitorGoals { get; }
        public PredictedResult(Match match, int hostGoals, int visitorGoals)
        {
            Match = match;
            PredictedHostGoals = hostGoals;
            PredictedVisitorGoals = visitorGoals;
        }
    }
}
