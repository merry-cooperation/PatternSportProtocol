using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportProtocolApp
{
    class SportEvent
    {
        public string Name
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var p in Players)
                {
                    sb.Append(p.Name);
                    sb.Append(" ");
                }
                return $"{Minutes} minutes, {Type}, {sb.ToString()}";
            }
        }
        public SportEventType Type { get; }
        public int Minutes { get; }
        public BindingList<Player> Players { get; }
        public SportEvent(int minutes, SportEventType type, List<Player> players)
        {
            Type = type;
            Minutes = minutes;
            Players = new BindingList<Player>(players);
        }

    }
}
