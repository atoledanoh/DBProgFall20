using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = SqlFactory.CreateTournamentRepo().GetTeamAll();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cboSelectTeam.DataSource = null;
            cboSelectTeam.DataSource = availableTeams;
            cboSelectTeam.DisplayMember = "TeamName";

            lstTournamentTeams.DataSource = null;
            lstTournamentTeams.DataSource = selectedTeams;
            lstTournamentTeams.DisplayMember = "TeamName";

            lstPrizes.DataSource = null;
            lstPrizes.DataSource = selectedPrizes;
            lstPrizes.DisplayMember = "PlaceName";
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)cboSelectTeam.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            //open create prize form
            CreatePrizeForm prizeForm = new CreatePrizeForm(this);
            prizeForm.MdiParent = ActiveForm;
            prizeForm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            //get back from the form at pize model
            //take prize model and add it to the list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void lnkCreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm teamForm = new CreateTeamForm(this);
            teamForm.MdiParent = ActiveForm;
            teamForm.Show();
        }

        private void btnRemoveSelectedPlayer_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)lstTournamentTeams.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void btnRemoveSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)lstPrizes.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            //validate data
            decimal fee = 0;
            bool isValidFee = decimal.TryParse(txtEntryFee.Text, out fee);

            if (!isValidFee)
            {
                MessageBox.Show("Please provide fee in a valid format",
                    "Fee not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //create tournament model
            TournamentModel tournamentModel = new TournamentModel();
            tournamentModel.TournamentName = txtTournamentName.Text;
            tournamentModel.EntryFee = fee;
            tournamentModel.Prizes = selectedPrizes;
            tournamentModel.EnteredTeams = selectedTeams;

            //wire up matchups
            TournamentLogic.CreateRounds(tournamentModel);

            IDataConnection tournamentRepo = SqlFactory.CreateTournamentRepo();
            tournamentRepo.CreateTournament(tournamentModel);


            //GlobalConfig.Connection.CreateTournament(tournamentModel);

            TournamentViewerForm tournamentViewer = new TournamentViewerForm(tournamentModel);
            tournamentViewer.MdiParent = ActiveForm;
            tournamentViewer.Show();
            this.Close();
        }
    }
}
