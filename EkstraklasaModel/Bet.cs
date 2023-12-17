using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class Bet
    {
        public int BetId { get; set; }
        public User UserOwner { get; set; }
        public Match Match { get; set; }
        PredictedResult PredictedResult { get; set; }

        //public Bet(User userOwner, Round round)
        //{
        //    UserOwner = userOwner;
        //    Round = round;
        //}
    }
}
