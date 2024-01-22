using CarRental.Components;
using CarRental.Components.SuperInterfaces;
using System;
using System.Windows.Forms;

namespace CarRental.Screens
{
    public partial class Profile : Form, IResetFrormsState
    {
        private bool validName = false;
        private bool validEmail = false;
        private bool validCell = false ;
        private bool validAddress = false ;
        private bool validPass = false;

        public Profile()
        {
            InitializeComponent();
        }

        public void Reset_All_Fields()
        {
            emailValText.Text = "";
            cellValText.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            confPassTxt.Text = "";
            addressTxt.Text = "";
            nameTxt.Text = "";
            cellTxt.Text = "";
        }

        private void HandleValidPass()
        {
            if (passwordTxt.Text.Length < 4 || confPassTxt.Text.Length < 4)
            {
                passwordValText.Text = "Password must be greater then 4 letters";
                validPass = false;
            }
            else if (passwordTxt.Text != confPassTxt.Text)
            {
                passwordValText.Text = "Password must be same";
                validPass = false;
            }
            else
            {
                passwordValText.Text = "";
                validPass = true;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox("Are you sure?", "Logout"))
            {
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            emailTxt.Text = Admin.Email;
            cellTxt.Text = Admin.Cell;
            nameTxt.Text = Admin.Name;  
            addressTxt.Text = Admin.Address;
            usernameTxt.Text = Admin.Username;
            usernameTxt.Enabled = false;

            emailValText.Text = "";
            nameValText.Text = "";
            cellValText.Text = "";
            addressValText.Text = "";
            passwordValText.Text = "";

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (
                emailTxt.Text != Admin.Email ||
                cellTxt.Text != Admin.Cell ||
                nameTxt.Text != Admin.Name ||
                addressTxt.Text != Admin.Address ||
                (validCell && validEmail && validAddress && validPass && validName)
            )
            {
                /*TODO: */
                Admin.Name = nameTxt.Text;
                Admin.Address = addressTxt.Text;
                Admin.Email = emailTxt.Text;
                Admin.Cell = cellTxt.Text;
                Admin.Update(usernameTxt.Text, passwordTxt.Text);

                Utilz.msgBox("Data Updated!", "Profile");

                Reset_All_Fields();
            } else
            {
                Utilz.msgBox("Fill All Fields!", "Profile");
            }
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == Admin.Name)
            {
                validName = false;
                nameValText.Text = "Name cant be same as Old";
                
            } else if (!Utilz.Validate_Name(nameTxt.Text))
            {
                validName = false;
                nameValText.Text = "Invalid Name";
            }
            else
            {
                nameValText.Text = "";
                validName = true;
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (emailTxt.Text == Admin.Email)
            {
                validEmail = false;
                emailValText.Text = "Email cant be same as Old";
            } else if (!Utilz.Validate_Email(emailTxt.Text))
            {
                emailValText.Text = "Invalid Email";
                validEmail = false;
            }
            else
            {
                emailValText.Text = "";
                validEmail = true;
            }
        }

        private void cellTxt_TextChanged(object sender, EventArgs e)
        {
            if (cellTxt.Text == Admin.Cell)
            {
                validCell = false;
                cellValText.Text = "Cell cant be same as Old";
            } else if(!Utilz.Validate_Cell(cellTxt.Text))
            {
                cellValText.Text = "Invalid Cell";
                validCell = false;
            }
            else
            {
                cellValText.Text = "";
                validCell = true;
            }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == Admin.Address)
            {
                validAddress = false;
                addressValText.Text = "Address cant be same as Old";
            }
            else if (addressTxt.Text.Length < 10)
            {
                validAddress = false;
                addressValText.Text = "Invalid Address";
            }
            else
            {
                validAddress = true;
                addressValText.Text = "";
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            HandleValidPass();
        }

        private void confPassTxt_TextChanged(object sender, EventArgs e)
        {
            HandleValidPass();
        }
    }
}
