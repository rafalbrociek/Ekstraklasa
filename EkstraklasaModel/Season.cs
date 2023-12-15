using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class Season
    {
        public List<Round> FirstRounds { get; set; } = new List<Round>();
        public List<Round> SecondRounds { get; set; } = new List<Round>();
        public void AddRound(Round round)
        {
            FirstRounds.Add(round);
            SecondRounds.Add(new Round(round));
        }
        public string Name { get; set; }
        public Season(string name)
        {
            Name = name;
        }
    }
}
