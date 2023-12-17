using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class Season
    {
        public int SeasonId { get; set; }
        public List<Round> FirstRounds { get; } = new();
        public List<Round> SecondRounds { get; } = new();
        //public void AddRound(Round round)
        //{
        //    FirstRounds.Add(round);
        //    SecondRounds.Add(new Round(round));
        //}
        //public string Name { get; set; }
        //public Season(string name)
        //{
        //    Name = name;
        //}
    }
}
