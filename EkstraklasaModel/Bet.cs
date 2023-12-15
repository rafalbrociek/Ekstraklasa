using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class Bet
    {
        public User UserOwner { get; set; }
        public Round Round { get; set; }
        List<PredictedResult> PredictedResults { get; set; }
        //public void AddResult(PredictedResult result)
        // TODO: Builder to ustawienia wyników meczów w całej kolejce
        public Bet(User userOwner, Round round)
        {
            UserOwner = userOwner;
            Round = round;
        }
    }
}
