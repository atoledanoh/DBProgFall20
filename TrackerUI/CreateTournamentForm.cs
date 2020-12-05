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
    public partial class CreateTournamentForm : Form, IPrizeRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeamAll();
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
            prizeForm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            //get back from the form at pize model
            //take prize model and add it to the list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }
    }
}
