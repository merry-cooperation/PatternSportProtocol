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
    partial class AddEventForm : Form
    {
        public Sport Sport { get; set; }
        public Match Match { get; set; }

        private BindingSource playersAbinding;
        private BindingSource playersBbinding;
        private BindingSource eventTypesBinding;
        private BindingSource eventsBinding;
        public AddEventForm()
        {
            InitializeComponent();
            Load += new EventHandler(AddEventForm_Load);
        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {
            infoLabel.Text = $"create events for {Sport.Name} match {Match.Name}";

            playersAbinding = new BindingSource
            {
                DataSource = Match.TeamA.Players
            };
            playersACheckedListBox.DataSource = playersAbinding;
            playersACheckedListBox.DisplayMember = "Name";

            playersBbinding = new BindingSource
            {
                DataSource = Match.TeamB.Players
            };
            playersBCheckedListBox.DataSource = playersBbinding;
            playersBCheckedListBox.DisplayMember = "Name";


            eventTypesBinding = new BindingSource
            {
                DataSource = Sport.PossibleEventTypes
            };
            eTypeComboBox.DataSource = eventTypesBinding;
            eTypeComboBox.DisplayMember = "Name";


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

        private void addEventButton_Click(object sender, EventArgs e)
        {
            var etype = (SportEventType)eTypeComboBox.SelectedItem;

            var playersCheckedA = playersACheckedListBox.CheckedItems.OfType<Player>().ToList();
            var playersCheckedB = playersBCheckedListBox.CheckedItems.OfType<Player>().ToList();
            if (playersCheckedA.Count == 0 && playersCheckedB.Count == 0)
            {
                MessageBox.Show("select players for event");
                return;
            }
            if (playersCheckedA.Count > 0 && playersCheckedB.Count > 0)
            {
                MessageBox.Show("can't select players from both teams for event");
                return;
            }

            int playersCheckedNum;
            List<Player> playersList;
            if (playersCheckedA.Count > 0)
            {
                playersCheckedNum = playersCheckedA.Count;
                playersList = playersCheckedA;
            }
            else
            {
                playersCheckedNum = playersCheckedB.Count;
                playersList = playersCheckedB;
            }

            if (playersCheckedNum != App.Instance.EventPlayersNum[etype])
            {
                MessageBox.Show($"invalid number of players for event. You selected {playersCheckedNum}, event requires {App.Instance.EventPlayersNum[etype]}");
                return;
            }

            var minutes = (int)minutesNumericUpDown.Value;

            eventsBinding.Add(new SportEvent(minutes, etype, playersList));
        }
    }
}
