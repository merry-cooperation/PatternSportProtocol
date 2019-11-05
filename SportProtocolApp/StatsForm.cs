using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportProtocolApp
{
    partial class StatsForm : Form
    {
        public Sport Sport { get; set; }
        public Match Match { get; set; }
        public StatsForm()
        {
            InitializeComponent();
            Load += new EventHandler(AddEventForm_Load);
        }

        private BindingSource playersBinding;
        private BindingSource eventsBinding;
        private void AddEventForm_Load(object sender, EventArgs e)
        {
            infoLabel.Text = $"get stats for {Sport.Name} match {Match.Name}";

            var pl1 = Match.TeamA.Players.ToList();
            var pl2 = Match.TeamB.Players.ToList();
            var players = new BindingList<Player>(pl1.Concat(pl2).ToList());

            playersBinding = new BindingSource
            {
                DataSource = players
            };
            playersListBox1.DataSource = playersBinding;
            playersListBox1.DisplayMember = "Name";

            eventsBinding = new BindingSource
            {
                DataSource = Match.Events
            };
            eventsListBox.DataSource = eventsBinding;
            eventsListBox.DisplayMember = "Name";
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getStatsButton_Click(object sender, EventArgs e)
        {
            var stat = (string)statsComboBox.SelectedItem;
            if (stat is null || stat.Length == 0)
            {
                MessageBox.Show("select stat to show");
                return;
            }
            var player = (Player)playersListBox1.SelectedItem;

            List<SportEvent> filtered;
            switch (stat)
            {
                case "All goals by player":
                    filtered = Match.Events.Where(x => x.Type == SportEventType.Goal && x.Players.Contains(player)).ToList();
                    eventsBinding.DataSource = filtered;
                    break;
                case "All passes with player":
                    filtered = Match.Events.Where(x => x.Type == SportEventType.Pass && x.Players.Contains(player)).ToList();
                    eventsBinding.DataSource = filtered;
                    break;
                case "All fouls by player":
                    filtered = Match.Events.Where(x => x.Type == SportEventType.Foul && x.Players.Contains(player)).ToList();
                    eventsBinding.DataSource = filtered;
                    break;
                case "All yellow cards for player":
                    filtered = Match.Events.Where(x => x.Type == SportEventType.YellowCard && x.Players.Contains(player)).ToList();
                    eventsBinding.DataSource = filtered;
                    break;
                case "All red cards for player":
                    filtered = Match.Events.Where(x => x.Type == SportEventType.RedCard && x.Players.Contains(player)).ToList();
                    eventsBinding.DataSource = filtered;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
