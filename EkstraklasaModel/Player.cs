﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class Player
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Team Team { get; set; }
        public Position Position { get; set; }

        public Player(string firstName, string lastName, Team team, Position position) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Team = team;
            this.Position = position;
        }
    }
}
