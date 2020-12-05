
namespace TrackerUI
{
    partial class CreateTeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblCeateTeam = new System.Windows.Forms.Label();
            this.btnAddTeamMember = new System.Windows.Forms.Button();
            this.cboSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.grpAddNewMember = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lstTeamMembers = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.grpAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTeamName.Location = new System.Drawing.Point(54, 103);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(355, 31);
            this.txtTeamName.TabIndex = 5;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(50, 77);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(99, 23);
            this.lblTeamName.TabIndex = 4;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblCeateTeam
            // 
            this.lblCeateTeam.AutoSize = true;
            this.lblCeateTeam.Location = new System.Drawing.Point(50, 38);
            this.lblCeateTeam.Name = "lblCeateTeam";
            this.lblCeateTeam.Size = new System.Drawing.Size(104, 23);
            this.lblCeateTeam.TabIndex = 3;
            this.lblCeateTeam.Text = "Create Team";
            // 
            // btnAddTeamMember
            // 
            this.btnAddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeamMember.Location = new System.Drawing.Point(162, 217);
            this.btnAddTeamMember.Name = "btnAddTeamMember";
            this.btnAddTeamMember.Size = new System.Drawing.Size(140, 48);
            this.btnAddTeamMember.TabIndex = 12;
            this.btnAddTeamMember.Text = "Add Member";
            this.btnAddTeamMember.UseVisualStyleBackColor = true;
            this.btnAddTeamMember.Click += new System.EventHandler(this.btnAddTeamMember_Click);
            // 
            // cboSelectTeamMember
            // 
            this.cboSelectTeamMember.FormattingEnabled = true;
            this.cboSelectTeamMember.Location = new System.Drawing.Point(53, 163);
            this.cboSelectTeamMember.Name = "cboSelectTeamMember";
            this.cboSelectTeamMember.Size = new System.Drawing.Size(355, 31);
            this.cboSelectTeamMember.TabIndex = 10;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Location = new System.Drawing.Point(49, 137);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(169, 23);
            this.lblSelectTeamMember.TabIndex = 9;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // grpAddNewMember
            // 
            this.grpAddNewMember.Controls.Add(this.btnCreateMember);
            this.grpAddNewMember.Controls.Add(this.txtPhoneNumber);
            this.grpAddNewMember.Controls.Add(this.lblPhoneNumber);
            this.grpAddNewMember.Controls.Add(this.txtEmail);
            this.grpAddNewMember.Controls.Add(this.lblEmail);
            this.grpAddNewMember.Controls.Add(this.txtLastName);
            this.grpAddNewMember.Controls.Add(this.lblLastName);
            this.grpAddNewMember.Controls.Add(this.txtFirstName);
            this.grpAddNewMember.Controls.Add(this.lblFirstName);
            this.grpAddNewMember.Location = new System.Drawing.Point(54, 285);
            this.grpAddNewMember.Name = "grpAddNewMember";
            this.grpAddNewMember.Size = new System.Drawing.Size(354, 331);
            this.grpAddNewMember.TabIndex = 13;
            this.grpAddNewMember.TabStop = false;
            this.grpAddNewMember.Text = "Add New Member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Location = new System.Drawing.Point(108, 246);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(140, 48);
            this.btnCreateMember.TabIndex = 14;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(135, 180);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(195, 31);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 183);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(122, 23);
            this.lblPhoneNumber.TabIndex = 15;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 31);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(135, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(195, 31);
            this.txtLastName.TabIndex = 12;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 23);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(135, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(195, 31);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 23);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // lstTeamMembers
            // 
            this.lstTeamMembers.FormattingEnabled = true;
            this.lstTeamMembers.ItemHeight = 23;
            this.lstTeamMembers.Location = new System.Drawing.Point(456, 163);
            this.lstTeamMembers.Name = "lstTeamMembers";
            this.lstTeamMembers.Size = new System.Drawing.Size(327, 349);
            this.lstTeamMembers.TabIndex = 14;
            // 
            // btnRemoveSelectedMember
            // 
            this.btnRemoveSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedMember.Location = new System.Drawing.Point(629, 103);
            this.btnRemoveSelectedMember.Name = "btnRemoveSelectedMember";
            this.btnRemoveSelectedMember.Size = new System.Drawing.Size(154, 44);
            this.btnRemoveSelectedMember.TabIndex = 15;
            this.btnRemoveSelectedMember.Text = "Remove Selected";
            this.btnRemoveSelectedMember.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedMember.Click += new System.EventHandler(this.btnRemoveSelectedMember_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Location = new System.Drawing.Point(557, 551);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(140, 48);
            this.btnCreateTeam.TabIndex = 16;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnRemoveSelectedMember);
            this.Controls.Add(this.lstTeamMembers);
            this.Controls.Add(this.grpAddNewMember);
            this.Controls.Add(this.btnAddTeamMember);
            this.Controls.Add(this.cboSelectTeamMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblCeateTeam);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.grpAddNewMember.ResumeLayout(false);
            this.grpAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblCeateTeam;
        private System.Windows.Forms.Button btnAddTeamMember;
        private System.Windows.Forms.ComboBox cboSelectTeamMember;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.GroupBox grpAddNewMember;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ListBox lstTeamMembers;
        private System.Windows.Forms.Button btnRemoveSelectedMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}