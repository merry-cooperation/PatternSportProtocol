using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportProtocolApp
{
    class Match
    {
        public Team TeamA { get; }
        public Team TeamB { get; }
        private DateTime date;
        public string Name
        {
            get
            {
                return $"{date.Date:d} {TeamA.Name} vs {TeamB.Name}";
            }
        }
        public BindingList<SportEvent> Events { get; }

        public Match(DateTime date, Team teamA, Team teamB)
        {
            this.date = date;
            TeamA = teamA;
            TeamB = teamB;
            Events = new BindingList<SportEvent>()
            {
                new SportEvent(2,SportEventType.Pass,new List<Player>(){TeamA.Players[0]})
            };
        }
    }
}
