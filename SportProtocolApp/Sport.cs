using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportProtocolApp
{
    class Sport
    {
        public BindingList<Team> Teams { get; }
        public BindingList<Match> Matches { get; }
        public BindingList<SportEventType> PossibleEventTypes { get; }
        public string Name { get; }
        public Sport(string name, List<SportEventType> sportEventTypes)
        {
            Name = name;
            Teams = new BindingList<Team>()
            {
                new Team($"{Name} team 1"),
                new Team($"{Name} team 2")
            };
            Matches = new BindingList<Match>()
            {
                new Match(DateTime.Today,Teams[0],Teams[1])
            };
            PossibleEventTypes = new BindingList<SportEventType>(sportEventTypes);
        }
    }
}
