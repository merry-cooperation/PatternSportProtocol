using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportProtocolApp
{
    class User
    {
        public string DisplayName { get; }
        public string Username { get; }
        public string Password { get; }
        public User(string dispName, string username, string passwd)
        {
            DisplayName = dispName;
            Username = username;
            Password = passwd;
        }
    }
}
