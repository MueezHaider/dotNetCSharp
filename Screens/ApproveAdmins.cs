using CarRental.Components;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarRental.Screens
{
    public partial class ApproveAdmins : Form
    {
        private SqlDataReader reader;
        private string username;

        public ApproveAdmins()
        {
            InitializeComponent();
        }

        private void Load_data()
        {
            string query = "EXEC  Get_UnAppAdmin;";
            reader = DBConnection.SqlReader(query);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            displayUnApprovedAdmins.DataSource = dataTable;
        }

        private void ApproveAdmins_Load(object sender, EventArgs e)
        {
            Load_data();
            approveBtn.Enabled = false;
        }

        private void displayUnApprovedAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            username = displayUnApprovedAdmins.Rows[e.RowIndex].Cells[0].Value.ToString();
            approveBtn.Enabled = true;
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (username.Length != 0)
            {
                SqlCommand cmd = DBConnection.SqlCmd("EXEC Approve_Admin "+username+";");
                cmd.ExecuteNonQuery();
                Load_data();
            } else
            {
                approveBtn.Enabled = false;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox("Are you sure?", "Logout"))
            {
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }

        private void minimizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitIconBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox())
                Application.Exit();
        }
    }
}
