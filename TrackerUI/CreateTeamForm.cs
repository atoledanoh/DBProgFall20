﻿using System;
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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetAllPerson();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        /// <summary>
        /// function for testing purposes
        /// </summary>
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "juana", LastName = "barrio" });
            availableTeamMembers.Add(new PersonModel { FirstName = "maria", LastName = "ramos" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "petra", LastName = "flores" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "pedro", LastName = "perez" });
        }

        private void WireUpLists()
        {
            //todo - find a better refresh
            cboSelectTeamMember.DataSource = null;
            cboSelectTeamMember.DataSource = availableTeamMembers;
            cboSelectTeamMember.DisplayMember = "FullName";

            lstTeamMembers.DataSource = null;
            lstTeamMembers.DataSource = selectedTeamMembers;
            lstTeamMembers.DisplayMember = "FullName";
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.EmailAdress = txtEmail.Text;
                p.PhoneNumber = txtPhoneNumber.Text;

                p = GlobalConfig.Connection.CreatePerson(p);
                
                selectedTeamMembers.Add(p);
                
                WireUpLists();

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
            }
            else
            {
                MessageBox.Show("all fields are required");
            }
        }

        private bool ValidateForm()
        {
            //todo - review validation
            if (txtFirstName.Text.Length == 0)
            {
                return false;
            }

            if (txtLastName.Text.Length == 0)
            {
                return false;
            }

            if (txtEmail.Text.Length == 0)
            {
                return false;
            }

            if (txtPhoneNumber.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void btnAddTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)cboSelectTeamMember.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void btnRemoveSelectedMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)lstTeamMembers.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }
    }
}
