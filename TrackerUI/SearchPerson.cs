using System;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class SearchPerson : Form
    {
        private PersonModel searchPersonObj;
        public SearchPerson()
        {
            InitializeComponent();
            
        }

        private void SearchPerson_Load(object sender, EventArgs e)
        {
            searchPersonObj = new PersonModel();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = searchInputTxt.Text;
                searchPersonObj.LastName = searchValue;
                var returnedValue = 
                    SqlFactory.CreateTournamentRepo().GetPersonSearch(searchPersonObj);
                personDgv.DataSource = returnedValue;
            }
            catch(Exception ex)
            {
                MessageBox.Show
                   (ex.GetType().ToString(), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
