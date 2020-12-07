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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournamentAll();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cboLoadExistingTournament.DataSource = tournaments;
            cboLoadExistingTournament.DisplayMember = "TournamentName";
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            CreateTournamentForm tournamentForm = new CreateTournamentForm();
            tournamentForm.Show();
        }

        private void btnLoadTournament_Click(object sender, EventArgs e)
        {
            TournamentModel tournamentModel = (TournamentModel)cboLoadExistingTournament.SelectedItem;
            TournamentViewerForm tournamentViewerForm = new TournamentViewerForm(tournamentModel);
            tournamentViewerForm.Show();
        }
    }
}
