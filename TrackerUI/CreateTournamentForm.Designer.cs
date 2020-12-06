
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.lnkCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lstTournamentTeams = new System.Windows.Forms.ListBox();
            this.lblTournamentTeams = new System.Windows.Forms.Label();
            this.btnRemoveSelectedPlayer = new System.Windows.Forms.Button();
            this.btnRemoveSelectedPrize = new System.Windows.Forms.Button();
            this.lblTournamentPrizes = new System.Windows.Forms.Label();
            this.lstPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.Location = new System.Drawing.Point(44, 31);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(175, 26);
            this.lblCreateTournament.TabIndex = 0;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Location = new System.Drawing.Point(44, 93);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(171, 26);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTournamentName.Location = new System.Drawing.Point(49, 142);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(279, 33);
            this.txtTournamentName.TabIndex = 2;
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntryFee.Location = new System.Drawing.Point(174, 211);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(154, 33);
            this.txtEntryFee.TabIndex = 4;
            this.txtEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Location = new System.Drawing.Point(44, 214);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(92, 26);
            this.lblEntryFee.TabIndex = 3;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(49, 308);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(279, 34);
            this.cboSelectTeam.TabIndex = 6;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(44, 266);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(113, 26);
            this.lblSelectTeam.TabIndex = 5;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // lnkCreateNewTeam
            // 
            this.lnkCreateNewTeam.AutoSize = true;
            this.lnkCreateNewTeam.Location = new System.Drawing.Point(217, 266);
            this.lnkCreateNewTeam.Name = "lnkCreateNewTeam";
            this.lnkCreateNewTeam.Size = new System.Drawing.Size(111, 26);
            this.lnkCreateNewTeam.TabIndex = 7;
            this.lnkCreateNewTeam.TabStop = true;
            this.lnkCreateNewTeam.Text = "Create New";
            this.lnkCreateNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCreateNewTeam_LinkClicked);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Location = new System.Drawing.Point(132, 363);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(135, 60);
            this.btnAddTeam.TabIndex = 8;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Location = new System.Drawing.Point(132, 446);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(135, 60);
            this.btnCreatePrize.TabIndex = 9;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // lstTournamentTeams
            // 
            this.lstTournamentTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTournamentTeams.FormattingEnabled = true;
            this.lstTournamentTeams.ItemHeight = 26;
            this.lstTournamentTeams.Location = new System.Drawing.Point(416, 93);
            this.lstTournamentTeams.Name = "lstTournamentTeams";
            this.lstTournamentTeams.Size = new System.Drawing.Size(330, 158);
            this.lstTournamentTeams.TabIndex = 10;
            // 
            // lblTournamentTeams
            // 
            this.lblTournamentTeams.AutoSize = true;
            this.lblTournamentTeams.Location = new System.Drawing.Point(411, 44);
            this.lblTournamentTeams.Name = "lblTournamentTeams";
            this.lblTournamentTeams.Size = new System.Drawing.Size(65, 26);
            this.lblTournamentTeams.TabIndex = 11;
            this.lblTournamentTeams.Text = "Teams";
            // 
            // btnRemoveSelectedPlayer
            // 
            this.btnRemoveSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedPlayer.Location = new System.Drawing.Point(785, 142);
            this.btnRemoveSelectedPlayer.Name = "btnRemoveSelectedPlayer";
            this.btnRemoveSelectedPlayer.Size = new System.Drawing.Size(135, 62);
            this.btnRemoveSelectedPlayer.TabIndex = 12;
            this.btnRemoveSelectedPlayer.Text = "Remove Selected";
            this.btnRemoveSelectedPlayer.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPlayer.Click += new System.EventHandler(this.btnRemoveSelectedPlayer_Click);
            // 
            // btnRemoveSelectedPrize
            // 
            this.btnRemoveSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelectedPrize.Location = new System.Drawing.Point(785, 396);
            this.btnRemoveSelectedPrize.Name = "btnRemoveSelectedPrize";
            this.btnRemoveSelectedPrize.Size = new System.Drawing.Size(135, 62);
            this.btnRemoveSelectedPrize.TabIndex = 15;
            this.btnRemoveSelectedPrize.Text = "Remove Selected";
            this.btnRemoveSelectedPrize.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedPrize.Click += new System.EventHandler(this.btnRemoveSelectedPrize_Click);
            // 
            // lblTournamentPrizes
            // 
            this.lblTournamentPrizes.AutoSize = true;
            this.lblTournamentPrizes.Location = new System.Drawing.Point(411, 299);
            this.lblTournamentPrizes.Name = "lblTournamentPrizes";
            this.lblTournamentPrizes.Size = new System.Drawing.Size(61, 26);
            this.lblTournamentPrizes.TabIndex = 14;
            this.lblTournamentPrizes.Text = "Prizes";
            // 
            // lstPrizes
            // 
            this.lstPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPrizes.FormattingEnabled = true;
            this.lstPrizes.ItemHeight = 26;
            this.lstPrizes.Location = new System.Drawing.Point(416, 348);
            this.lstPrizes.Name = "lstPrizes";
            this.lstPrizes.Size = new System.Drawing.Size(330, 158);
            this.lstPrizes.TabIndex = 13;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Location = new System.Drawing.Point(361, 544);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(186, 60);
            this.btnCreateTournament.TabIndex = 16;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 627);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnRemoveSelectedPrize);
            this.Controls.Add(this.lblTournamentPrizes);
            this.Controls.Add(this.lstPrizes);
            this.Controls.Add(this.btnRemoveSelectedPlayer);
            this.Controls.Add(this.lblTournamentTeams);
            this.Controls.Add(this.lstTournamentTeams);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lnkCreateNewTeam);
            this.Controls.Add(this.cboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblCreateTournament);
            this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTournament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel lnkCreateNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox lstTournamentTeams;
        private System.Windows.Forms.Label lblTournamentTeams;
        private System.Windows.Forms.Button btnRemoveSelectedPlayer;
        private System.Windows.Forms.Button btnRemoveSelectedPrize;
        private System.Windows.Forms.Label lblTournamentPrizes;
        private System.Windows.Forms.ListBox lstPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}