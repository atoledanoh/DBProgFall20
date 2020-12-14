﻿using System;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    txtPlaceName.Text,
                    txtPlaceNumber.Text,
                    txtPrizeAmount.Text,
                    txtPrizePercentage.Text);

                IDataConnection tournamentRepo = SqlFactory.CreateTournamentRepo();
                tournamentRepo.CreatePrize(model);


                //GlobalConfig.Connection.CreatePrize(model);
                callingForm.PrizeComplete(model);
                Close();

                //txtPlaceName.Text = "";
                //txtPlaceNumber.Text = "";
                //txtPrizeAmount.Text = "0";
                //txtPrizePercentage.Text = "0";

                //TODO - comment this out
                MessageBox.Show("everything is awesome");
            }
            else
            {
                //TODO - comment this out
                MessageBox.Show("invalid information");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(txtPlaceNumber.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (txtPlaceName.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool prizeAmountValid = decimal.TryParse(txtPrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(txtPrizePercentage.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
