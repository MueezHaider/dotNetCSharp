using CarRental.Components;
using CarRental.Components.SuperInterfaces;
using System;
using System.Windows.Forms;

namespace CarRental.Screens
{
    public partial class Customers : Form, IResetFrormsState
    {
        public Customers()
        {
            InitializeComponent();
        }

        private bool Val_Fields()
        {
            if (
                    idTxt.Text != "" &&
                    nameTxt.Text != "" &&
                    ageTxt.Text != "" &&
                    addressTxt.Text != "" &&
                    Utilz.Validate_Cell(cellTxt.Text) &&
                    Utilz.Validate_Name(nameTxt.Text) &&
                    Utilz.Validate_Age(ageTxt.Text)
                ) return true;
            return false;
        }

        public void Reset_All_Fields()
        {
            nameTxt.Text = "";
            ageTxt.Text = "";
            addressTxt.Text = "";
            cellTxt.Text = "";
            VIPCheckBox.Checked = false;

            idTxt.Text = Customer.NewCustId();
        }

        private void Load_Cus()
        {
            Customer customer = new Customer();
            displayCustomerGridView.DataSource = customer.Display();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Val_Fields())
            {
                Customer customer = new Customer(
                    idTxt.Text,
                    nameTxt.Text,
                    ageTxt.Text,
                    addressTxt.Text,
                    cellTxt.Text,
                    VIPCheckBox.Checked
                );

                customer.Dump();
                Load_Cus();
                Utilz.msgBox("Customer Added", "Customer");
                Reset_All_Fields();
            } else warningText.Text = "Fill all fields";
            
        }


        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
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

        private void exitIconBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox())
                Application.Exit();
        }

        private void minimizeIconBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            Load_Cus();
            Reset_All_Fields();
            updateBtn.Enabled = false;
            idTxt.Enabled = false;
        }

        private void adminProfileBtn_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void displayCustomerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AddBtn.Enabled = false;
            updateBtn.Enabled = true;

            idTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ageTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            addressTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            cellTxt.Text = displayCustomerGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (displayCustomerGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Trim() == "1")
                VIPCheckBox.Checked = true;
            else
                VIPCheckBox.Checked = false;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (Val_Fields())
            {
                Customer customer = new Customer(
                    id: idTxt.Text,
                    name:nameTxt.Text,
                    age: ageTxt.Text,
                    address: addressTxt.Text,
                    cell: cellTxt.Text,
                    vip: VIPCheckBox.Checked
                );

                customer.Update();
                Load_Cus();
                MessageBox.Show("Data Updated");
                Utilz.msgBox("Customer Updated", "Customer");
            }
            else warningText.Text = "Fill all fields";
        }

        private void cellTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Cell(cellTxt.Text)) cellValText.Text = ""
;            else  cellValText.Text = "Invalid Cell"; 
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Name(nameTxt.Text)) nameValText.Text = ""; 
            else nameValText.Text = "Invalid Name"; 
        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Age(ageTxt.Text)) ageWarnText.Text = "";
            else ageWarnText.Text = "Invalid Age"; 
        }

        private void reloadText_Click(object sender, EventArgs e)
        {
            Reset_All_Fields();

            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
        }

        private void reloadIconBtn_Click(object sender, EventArgs e)
        {
            Reset_All_Fields();

            ageWarnText.Text = "";
            cellValText.Text = "";
            nameValText.Text = "";
            cellValText.Text = "";

            AddBtn.Enabled = true;
            updateBtn.Enabled = false;
        }
    }
}

