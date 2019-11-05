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
    partial class TeamsForm : Form
    {
        public TeamsForm()
        {
            InitializeComponent();
            Load += new EventHandler(TeamsFormLoad);
        }

        private BindingSource sportsBinding;
        private BindingSource teamsBinding;
        private BindingSource playersBinding;
        void TeamsFormLoad(object sender, EventArgs e)
        {
            sportsBinding = new BindingSource
            {
                DataSource = App.Instance.Sports
            };
            sportsListBox.DataSource = sportsBinding;
            sportsListBox.DisplayMember = "Name";

            teamsBinding = new BindingSource
            {
                DataSource = App.Instance.Sports[0].Teams
            };
            teamsListBox.DataSource = teamsBinding;
            teamsListBox.DisplayMember = "Name";

            playersBinding = new BindingSource
            {
                DataSource = App.Instance.Sports[0].Teams[0].Players
            };
            playersListBox.DataSource = playersBinding;
            playersListBox.DisplayMember = "Name";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            var name = teamNameTextBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("team name can't be empty");
                return;
            }
            teamsBinding.Add(new Team(name));
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            var name = playerNameTextBox.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("team name can't be empty");
                return;
            }
            playersBinding.Add(new Player(name));
        }


        private void sportsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (teamsBinding != null && sportsListBox.SelectedIndex != -1)
            {
                Sport selected = (Sport)sportsListBox.SelectedValue;
                teamsBinding.DataSource = selected.Teams;
            }
        }

        private void teamsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (playersBinding != null && teamsListBox.SelectedIndex != -1)
            {
                Team selected = (Team)teamsListBox.SelectedValue;
                playersBinding.DataSource = selected.Players;
            }
        }
    }
}
