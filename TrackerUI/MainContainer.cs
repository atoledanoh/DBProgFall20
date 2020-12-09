﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class MainContainer : Form
    {
        private int childFormNumber = 0;

        public MainContainer()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            var m = (ToolStripMenuItem)sender;

            Form childForm = GetLinkedChildForm(m);


            if (childForm != null)
            {
                foreach (Form f in MdiChildren)
                {

                    if (IsSameFormType(f, childForm))
                    {
                        f.Activate();
                        return;
                    }
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }

        private Form GetLinkedChildForm(ToolStripMenuItem m)
        {
            Form childForm = null;
            switch (m.Tag)
            {
                case "tournamentDashBaordBtn":
                    childForm = new TournamentDashboardForm();
                    break;
                case "personSearchbtn":
                    childForm = new SearchPerson();
                    break;
                case "PersonBrowseForm":
                    childForm = new BrowsePerson();
                    break;
                case "PrizeForm":
                    childForm = new BrowsePrize();
                    break;
                case "abouFormbtn":
                    childForm = new AboutBox1();
                    break;
            }
            return childForm;
        }

        private bool IsSameFormType(Form f, Form childForm)
        {
            return f.GetType() == childForm.GetType();
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
