using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();
            LoadRounds();
        }

        private void LoadFormData()
        {
            lblTournamentName.Text = tournament.TournamentName;
        }

        private void WireUpRoundsList()
        {
            cboRound.DataSource = null;
            cboRound.DataSource = rounds;

        }

        public void WireUpMatchupList()
        {
            lstMatchup.DataSource = null;
            lstMatchup.DataSource = selectedMatchups;
            lstMatchup.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds = new List<int>();
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
            WireUpRoundsList();
        }

        private void cboRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)cboRound.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }
            }
            WireUpMatchupList();
        }

        private void LoadMatchup()
        {
            MatchupModel matchupModel = (MatchupModel)lstMatchup.SelectedItem;

            for (int i = 0; i < matchupModel.Entries.Count; i++)
            {
                //team one
                if (i == 0)
                {
                    if (matchupModel.Entries[0].TeamCompeting != null)
                    {
                        lblTeamOne.Text = matchupModel.Entries[0].TeamCompeting.TeamName;
                        txtTeamOneScore.Text = matchupModel.Entries[0].Score.ToString();

                        lblTeamTwo.Text = "Bye";
                        txtTeamTwoScore.Text = "0";
                    }
                    else
                    {
                        lblTeamOne.Text = "Team not set yet";
                        txtTeamOneScore.Text = "";
                    }
                }

                //team two
                if (i == 1)
                {
                    if (matchupModel.Entries[1].TeamCompeting != null)
                    {
                        lblTeamTwo.Text = matchupModel.Entries[1].TeamCompeting.TeamName;
                        txtTeamTwoScore.Text = matchupModel.Entries[1].Score.ToString();
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
            LoadMatchup();
        }
    }
}
