
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.lblTournamentDashboard = new System.Windows.Forms.Label();
            this.cboLoadExistingTournament = new System.Windows.Forms.ComboBox();
            this.lblLoadExistingTournament = new System.Windows.Forms.Label();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTournamentDashboard
            // 
            this.lblTournamentDashboard.Location = new System.Drawing.Point(125, 53);
            this.lblTournamentDashboard.Name = "lblTournamentDashboard";
            this.lblTournamentDashboard.Size = new System.Drawing.Size(203, 30);
            this.lblTournamentDashboard.TabIndex = 1;
            this.lblTournamentDashboard.Text = "Tournament Dashboard";
            // 
            // cboLoadExistingTournament
            // 
            this.cboLoadExistingTournament.FormattingEnabled = true;
            this.cboLoadExistingTournament.Location = new System.Drawing.Point(49, 164);
            this.cboLoadExistingTournament.Name = "cboLoadExistingTournament";
            this.cboLoadExistingTournament.Size = new System.Drawing.Size(355, 31);
            this.cboLoadExistingTournament.TabIndex = 12;
            // 
            // lblLoadExistingTournament
            // 
            this.lblLoadExistingTournament.AutoSize = true;
            this.lblLoadExistingTournament.Location = new System.Drawing.Point(123, 112);
            this.lblLoadExistingTournament.Name = "lblLoadExistingTournament";
            this.lblLoadExistingTournament.Size = new System.Drawing.Size(207, 23);
            this.lblLoadExistingTournament.TabIndex = 11;
            this.lblLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.Location = new System.Drawing.Point(144, 224);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(164, 48);
            this.btnLoadTournament.TabIndex = 13;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Location = new System.Drawing.Point(133, 301);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(186, 65);
            this.btnCreateTournament.TabIndex = 14;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 419);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.cboLoadExistingTournament);
            this.Controls.Add(this.lblLoadExistingTournament);
            this.Controls.Add(this.lblTournamentDashboard);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournamentDashboard;
        private System.Windows.Forms.ComboBox cboLoadExistingTournament;
        private System.Windows.Forms.Label lblLoadExistingTournament;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}