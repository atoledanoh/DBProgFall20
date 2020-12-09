
namespace TrackerUI
{
    partial class MainContainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContainer));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.browseToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // iTToolStripMenuItem
            // 
            this.iTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assignmentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.iTToolStripMenuItem.Name = "iTToolStripMenuItem";
            this.iTToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.iTToolStripMenuItem.Text = "Tournament Manager";
            // 
            // assignmentsToolStripMenuItem
            // 
            this.assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            this.assignmentsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.assignmentsToolStripMenuItem.Tag = "tournamentDashBaordBtn";
            this.assignmentsToolStripMenuItem.Text = "Dashboard";
            this.assignmentsToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aboutToolStripMenuItem.Tag = "abouFormbtn";
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.personToolStripMenuItem.Tag = "personSearchbtn";
            this.personToolStripMenuItem.Text = "Person";
            this.personToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem1,
            this.prizeToolStripMenuItem});
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.browseToolStripMenuItem.Text = "Browse";
            // 
            // personToolStripMenuItem1
            // 
            this.personToolStripMenuItem1.Name = "personToolStripMenuItem1";
            this.personToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.personToolStripMenuItem1.Tag = "PersonBrowseForm";
            this.personToolStripMenuItem1.Text = "Person";
            this.personToolStripMenuItem1.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // prizeToolStripMenuItem
            // 
            this.prizeToolStripMenuItem.Name = "prizeToolStripMenuItem";
            this.prizeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.prizeToolStripMenuItem.Tag = "PrizeForm";
            this.prizeToolStripMenuItem.Text = "Prize";
            this.prizeToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 659);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainContainer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem iTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}



