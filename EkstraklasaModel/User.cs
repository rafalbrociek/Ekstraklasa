using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public List<Bet> Bets { get; } = new();
        //public User(string name, string login)
        //{
        //    Name = name;
        //    Login = login;
        //}
    }
}
