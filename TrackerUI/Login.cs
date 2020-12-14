using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CM = System.Configuration.ConfigurationManager;

namespace TrackerUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(CM.ConnectionStrings["Tournaments"].ConnectionString))
            {
                string query =
                    "Select * from LoginRecords Where UserName = '" + txtUsername.Text.Trim() +
                    "' and Password = '" + txtUsername.Text.Trim() + "'";
                SqlDataAdapter sqlDataAdapter =
                    new SqlDataAdapter(query, CM.ConnectionStrings["Tournaments"].ConnectionString.ToString());
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username/Password incorrect, please try again.");
                }

            }
        }
    }
}
