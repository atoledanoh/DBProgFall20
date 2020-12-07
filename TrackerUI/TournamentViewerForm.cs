using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            lblTournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            cboRound.DataSource = rounds;
            lstMatchup.DataSource = selectedMatchups;
            lstMatchup.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currentRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currentRound)
                {
                    currentRound = matchups.First().MatchupRound;
                    rounds.Add(currentRound);
                }
            }

            LoadMatchups(1);
        }

        private void cboRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)cboRound.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !chkUnplayed.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            lblTeamOne.Visible = isVisible;
            lblTeamOneScore.Visible = isVisible;
            txtTeamOneScore.Visible = isVisible;
            lblTeamTwo.Visible = isVisible;
            lblTeamTwoScore.Visible = isVisible;
            txtTeamTwoScore.Visible = isVisible;
            lblVersus.Visible = isVisible;
            btnScore.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        lblTeamOne.Text = m.Entries[0].TeamCompeting.TeamName;
                        txtTeamOneScore.Text = m.Entries[0].Score.ToString();

                        lblTeamTwo.Text = "<<< Bye >>>";
                        txtTeamTwoScore.Text = "0";
                    }
                    else
                    {
                        lblTeamOne.Text = "Team not set yet";
                        txtTeamOneScore.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        lblTeamTwo.Text = m.Entries[1].TeamCompeting.TeamName;
                        txtTeamTwoScore.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        lblTeamTwo.Text = "Team not set yet";
                        txtTeamTwoScore.Text = "";
                    }
                }
            }
        }

        private void lstMatchup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)lstMatchup.SelectedItem);
        }

        private void chkUnplayed_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)cboRound.SelectedItem);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)lstMatchup.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(txtTeamOneScore.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(txtTeamTwoScore.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }
                }
            }

            TournamentLogic.UpdateTournamentResults(tournament);

            LoadMatchups((int)cboRound.SelectedItem);
        }
    }
}
