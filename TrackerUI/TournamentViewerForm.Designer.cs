
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.lblTounament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cboRound = new System.Windows.Forms.ComboBox();
            this.chkUnplayed = new System.Windows.Forms.CheckBox();
            this.lstMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.lblVersus = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTounament
            // 
            this.lblTounament.AutoSize = true;
            this.lblTounament.Location = new System.Drawing.Point(51, 54);
            this.lblTounament.Name = "lblTounament";
            this.lblTounament.Size = new System.Drawing.Size(108, 23);
            this.lblTounament.TabIndex = 0;
            this.lblTounament.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Location = new System.Drawing.Point(201, 54);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(67, 23);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(51, 111);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(65, 23);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round:";
            // 
            // cboRound
            // 
            this.cboRound.FormattingEnabled = true;
            this.cboRound.Location = new System.Drawing.Point(205, 103);
            this.cboRound.Name = "cboRound";
            this.cboRound.Size = new System.Drawing.Size(121, 31);
            this.cboRound.TabIndex = 3;
            this.cboRound.SelectedIndexChanged += new System.EventHandler(this.cboRound_SelectedIndexChanged);
            // 
            // chkUnplayed
            // 
            this.chkUnplayed.AutoSize = true;
            this.chkUnplayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUnplayed.Location = new System.Drawing.Point(205, 185);
            this.chkUnplayed.Name = "chkUnplayed";
            this.chkUnplayed.Size = new System.Drawing.Size(139, 27);
            this.chkUnplayed.TabIndex = 4;
            this.chkUnplayed.Text = "Unplayed Only";
            this.chkUnplayed.UseVisualStyleBackColor = true;
            this.chkUnplayed.CheckedChanged += new System.EventHandler(this.chkUnplayed_CheckedChanged);
            // 
            // lstMatchup
            // 
            this.lstMatchup.FormattingEnabled = true;
            this.lstMatchup.ItemHeight = 23;
            this.lstMatchup.Location = new System.Drawing.Point(55, 239);
            this.lstMatchup.Name = "lstMatchup";
            this.lstMatchup.Size = new System.Drawing.Size(271, 211);
            this.lstMatchup.TabIndex = 5;
            this.lstMatchup.SelectedIndexChanged += new System.EventHandler(this.lstMatchup_SelectedIndexChanged);
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Location = new System.Drawing.Point(435, 106);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(100, 23);
            this.lblTeamOne.TabIndex = 6;
            this.lblTeamOne.Text = "<team one>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Location = new System.Drawing.Point(435, 154);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(53, 23);
            this.lblTeamOneScore.TabIndex = 7;
            this.lblTeamOneScore.Text = "Score";
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(535, 151);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(100, 31);
            this.txtTeamOneScore.TabIndex = 8;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(535, 286);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(100, 31);
            this.txtTeamTwoScore.TabIndex = 11;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Location = new System.Drawing.Point(435, 289);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(53, 23);
            this.lblTeamTwoScore.TabIndex = 10;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.Location = new System.Drawing.Point(435, 241);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(101, 23);
            this.lblTeamTwo.TabIndex = 9;
            this.lblTeamTwo.Text = "<team two>";
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Location = new System.Drawing.Point(486, 205);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(50, 23);
            this.lblVersus.TabIndex = 12;
            this.lblVersus.Text = "- VS -";
            // 
            // btnScore
            // 
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Location = new System.Drawing.Point(439, 365);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(135, 50);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 506);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.lstMatchup);
            this.Controls.Add(this.chkUnplayed);
            this.Controls.Add(this.cboRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblTounament);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TournamentViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tournament Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTounament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cboRound;
        private System.Windows.Forms.CheckBox chkUnplayed;
        private System.Windows.Forms.ListBox lstMatchup;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.Button btnScore;
    }
}

