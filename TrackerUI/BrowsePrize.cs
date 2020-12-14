using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{

    public partial class BrowsePrize : Form
    {
        private List<PrizeModel> prizeList;
        private PrizeModel prizeToDisplay;
        private int currentRecord;
        private int firstRecord;
        private int lastRecord;

        private void MaintainPrizes_Load(object sender, EventArgs e)
        {
            prizeList = new List<PrizeModel>();
            prizeList = SqlFactory.CreateTournamentRepo().GetPrizeAll();
            loadFirstRecord();
        }


        public BrowsePrize()
        {
            InitializeComponent();
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
            setPrize();
            setStatusTipMessage();
        }

        private void loadLastRecord()
        {
            lastRecord = prizeList.Count - 1;
            currentRecord = lastRecord;
            setPrize();
            setStatusTipMessage();

        }

        private void loadNextRecord()
        {
            currentRecord++;
            if (currentRecord > lastRecord)
            {
                currentRecord = lastRecord;
            }
            setPrize();
            setStatusTipMessage();
        }

        private void loadPreviousRecord()
        {
            currentRecord--;
            if (currentRecord < firstRecord)
            {
                currentRecord = firstRecord;
            }
            setPrize();
            setStatusTipMessage();
        }

        private void setPrize()
        {
            if (prizeList.Count > 0)
            {
                prizeToDisplay = prizeList[currentRecord];
                setSlectedPrize();
            }
        }

        private void setSlectedPrize()
        {
            if (prizeToDisplay != null)
            {
                placeNumberTxt.Text = prizeToDisplay.PlaceNumber.ToString();
                prizeAmountTxt.Text = prizeToDisplay.PrizeAmount.ToString();
                placeNameTxt.Text = prizeToDisplay.PlaceName;
                prizePercentageTxt.Text = prizeToDisplay.PrizePercentage.ToString();
            }
        }

        private void getPopulatedPrize()
        {
            prizeToDisplay.PlaceNumber = Convert.ToInt32(placeNumberTxt.Text);
            prizeToDisplay.PrizeAmount = Convert.ToDecimal(prizeAmountTxt.Text);
            prizeToDisplay.PlaceName = placeNameTxt.Text;
            prizeToDisplay.PrizePercentage = Convert.ToDouble(prizePercentageTxt.Text);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (prizeToDisplay != null)
                {
                    SqlFactory.CreateTournamentRepo().DeleltePrize(prizeToDisplay);
                    MessageBox.Show("Record Has been deleted");
                    clearControls();
                    prizeList = SqlFactory.CreateTournamentRepo().GetPrizeAll();
                    loadFirstRecord();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Execute");
            }
        }

        private void clearControls()
        {
            placeNumberTxt.Text = "";
            prizeAmountTxt.Text = "";
            placeNameTxt.Text = "";
            prizePercentageTxt.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                getPopulatedPrize();
                if (prizeToDisplay != null)
                {
                    SqlFactory.CreateTournamentRepo().UpdatePrize(prizeToDisplay);
                    MessageBox.Show("Record Has been Updated");
                    clearControls();
                    prizeList = SqlFactory.CreateTournamentRepo().GetPrizeAll();
                    loadFirstRecord();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed To Execute");
            }
        }

        private void setStatusTipMessage()
        {
            statusStrip.Text = $"Browsing Prizes... entry No. {currentRecord + 1} out of {prizeList.Count}";
        }
    }
}
