using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class BrowsePerson : Form
    {
        private List<PersonModel> personList;
        private PersonModel personToDisplay;
        private int currentRecord;
        private int firstRecord;
        private int lastRecord;


        public BrowsePerson()
        {
            InitializeComponent();
        }

        private void PersonNavigation_Load(object sender, EventArgs e)
        {
            personList = new List<PersonModel>();
            personList = SqlFactory.CreateTournamentRepo().GetPersonAll();
            loadFirstRecord();
        }

        private void Buttons_Navigation_Manager(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                switch (b.Name)
                {
                    case "firstBtn":
                        loadFirstRecord();
                        break;
                    case "prevBtn":
                        loadPreviousRecord();
                        break;
                    case "nxtBtn":
                        loadNextRecord();
                        break;
                    case "lastBtn":
                        loadLastRecord();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
              "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NextPrevButtonManager();
        }

        private void loadFirstRecord()
        {
            currentRecord = firstRecord;
            setPerson();
            setStatusTipMessage();
        }

        private void loadLastRecord()
        {
            lastRecord = personList.Count - 1;
            currentRecord = lastRecord;
            setPerson();
            setStatusTipMessage();
        }

        private void loadNextRecord()
        {
            currentRecord++;
            if (currentRecord > lastRecord)
            {
                currentRecord = lastRecord;
            }
            setPerson();
            setStatusTipMessage();
        }

        private void loadPreviousRecord()
        {
            currentRecord--;
            if (currentRecord < firstRecord)
            {
                currentRecord = firstRecord;
            }
            setPerson();
            setStatusTipMessage();
        }


        private void setPerson()
        {
            if (personList.Count > 0)
            {
                personToDisplay = personList[currentRecord];
                setSlectedPerson();
            }
        }

        private void setSlectedPerson()
        {
            if (personToDisplay != null)
            {
                firstNameTxt.Text = personToDisplay.FirstName;
                lastNameTxt.Text = personToDisplay.LastName;
                txtEmail.Text = personToDisplay.EmailAdress;
                phoneNumberTxt.Text = personToDisplay.PhoneNumber;
            }
        }

        private void NextPrevButtonManager()
        {
            if (currentRecord > firstRecord)
            {
                prevBtn.Enabled = true;
            }
            else
            {
                prevBtn.Enabled = false;
            }

            if (currentRecord < lastRecord)
            {
                nxtBtn.Enabled = true;
            }
            else
            {
                nxtBtn.Enabled = false;
            }
        }
        private void setStatusTipMessage()
        {
            toolStripStatusLabel1.Text = $"Browsing People... entry No. {currentRecord + 1} out of {personList.Count}";
        }

    }
}
