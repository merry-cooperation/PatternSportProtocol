using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportProtocolApp
{
    sealed class App
    {
        static App() { }

        public static App Instance { get; } = new App();

        public readonly Dictionary<SportEventType, int> EventPlayersNum;
        private readonly List<User> users;
        private User currentLogIn;
        public BindingList<Sport> Sports { get; }
        private App()
        {
            EventPlayersNum = new Dictionary<SportEventType, int>
            {
                { SportEventType.Goal ,1},
                { SportEventType.Pass ,2},
                { SportEventType.Foul ,1},
                { SportEventType.YellowCard ,1},
                { SportEventType.RedCard ,1}
            };
            users = new List<User>
            {
                new User("admin1","adm","pass"),
                new User("admin2","chief","secret")
            };
            var events = new List<SportEventType>
            {
                SportEventType.Goal,
                SportEventType.Pass
            };
            Sports = new BindingList<Sport>
            {
                new Sport("Football",events),
                new Sport("Basketball",events)
            };
            Sports.AllowNew = true;
            Sports.AllowEdit = false;
            Sports.AllowRemove = false;
        }
        public string LoggedInName
        {
            get
            {
                if (currentLogIn != null)
                {
                    return currentLogIn.DisplayName;
                }
                return "Guest";
            }
        }
        public bool LogIn(string usrname, string passwd)
        {
            currentLogIn = null;
            foreach (var u in users)
            {
                if (u.Username == usrname && u.Password == passwd)
                {
                    currentLogIn = u;
                    return true;
                }
            }
            return false;
        }
    }
}
