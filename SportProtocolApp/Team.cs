using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportProtocolApp
{
    class Team
    {
        public BindingList<Player> Players { get; }
        public string Name { get; }
        public Team(string name)
        {
            Name = name;
            Players = new BindingList<Player>
            {
                new Player($"{Name} player 1"),
                new Player($"{Name} player 2")
            };
        }
    }
}
