using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkstraklasaModel
{
    public class User
    {
        string Name { get; set; }
        string Login { get; set; }
        public User(string name, string login)
        {
            Name = name;
            Login = login;
        }
    }
}
