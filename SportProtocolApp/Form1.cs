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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);
        }
        private BindingSource sportsBinding;
        private BindingSource matchesBinding;
        private BindingSource eventsBinding;
        private BindingSource eventsTypesBinding;
        void Form1_Load(object sender, EventArgs e)
        {
            sportsBinding = new BindingSource
            {
                DataSource = App.Instance.Sports
            };
            sportsListBox.DataSource = sportsBinding;
            sportsListBox.DisplayMember = "Name";

            matchesBinding = new BindingSource
            {
                DataSource = App.Instance.Sports[0].Matches
            };
            matchesListBox.DataSource = matchesBinding;
            matchesListBox.DisplayMember = "Name";

            eventsBinding = new BindingSource
            {
                DataSource = App.Instance.Sports[0].Matches[0].Events
            };
            eventsListBox.DataSource = eventsBinding;
            eventsListBox.DisplayMember = "Name";

            eventsTypesBinding = new BindingSource
            {
                DataSource = Enum.GetValues(typeof(SportEventType))
            };
            eTypesCheckedListBox.DataSource = eventsTypesBinding;
            eTypesCheckedListBox.DisplayMember = "Name";
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            var uname = usrNameTextBox.Text;
            var passwd = passwordTextBox.Text;
            adminControlsGroupBox.Enabled = App.Instance.LogIn(uname, passwd);
            loggedInLabel.Text = App.Instance.LoggedInName;
        }

        private void addSportButton_Click(object sender, EventArgs e)
        {
            var sportName = addSportTextBox.Text;
            var etypes = eTypesCheckedListBox.CheckedItems.OfType<SportEventType>().ToList();
            if (sportName.Length == 0)
            {
                MessageBox.Show("sport name can't be empty");
                return;
            }
            sportsBinding.Add(new Sport(sportName, etypes));
        }
        private void editTeamsButton_Click(object sender, EventArgs e)
        {
            var f = new TeamsForm();
            f.ShowDialog();
        }
        private void sportsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (matchesBinding != null && sportsListBox.SelectedIndex != -1)
            {
                Sport selected = (Sport)sportsListBox.SelectedValue;
                matchesBinding.DataSource = selected.Matches;
            }
        }
        private void matchesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (eventsBinding != null && matchesListBox.SelectedIndex != -1)
            {
                Match selected = (Match)matchesListBox.SelectedValue;
                eventsBinding.DataSource = selected.Events;
            }
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            if (sportsListBox.SelectedIndex != -1 && matchesListBox.SelectedIndex != -1)
            {
                var f = new AddEventForm
                {
                    Sport = (Sport)sportsListBox.SelectedValue,
                    Match = (Match)matchesListBox.SelectedValue
                };
                f.ShowDialog();
            }
        }

        private void getStatsButton_Click(object sender, EventArgs e)
        {
            if (sportsListBox.SelectedIndex != -1 && matchesListBox.SelectedIndex != -1)
            {
                var f = new StatsForm
                {
                    Sport = (Sport)sportsListBox.SelectedValue,
                    Match = (Match)matchesListBox.SelectedValue
                };
                f.ShowDialog();
            }
        }
    }
}
