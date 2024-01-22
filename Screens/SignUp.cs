using CarRental.Components;
using CarRental.Components.SuperInterfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental.Screens
{
    public partial class SignUp : Form, IResetFrormsState
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public void Reset_All_Fields()
        {
            emailValText.Text = "";
            usernameValText.Text = "";
            cellValText.Text = "";
            warningPass.Text = "";
            warningPass2.Text = "";
            usernameTxt.Text = "";
            passwordTxt.Text = "";
            confirmPassTxt.Text = "";
            addressTxt.Text = "";
            nameTxt.Text = "";
            cellTxt.Text = "";
            allFieldsWarn.Text = "";
        }

        private bool HandlePassLen()
        {
            bool r = false;
            if (passwordTxt.Text.Length >= 4 && confirmPassTxt.Text.Length >= 4)
            {
                warningPass2.Text = "";
                r = true;
            }
            else
            {
                warningPass2.Text = "Password must be greater then 4 Letters";
                r = false;
            }
           
            if (passwordTxt.Text == confirmPassTxt.Text)
            {
                warningPass.Text = "";
                r = true;
            }
            else
            {
                warningPass.Text = "Password must be same";
                r = false;
            }

            return r;
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
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

        private void signBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.Validate_Cell(cellTxt.Text) && 
                Utilz.Validate_Email(emailTxt.Text) && 
                Utilz.Validate_Username(usernameTxt.Text) &&
                Admin.Check_Avail_Username(usernameTxt.Text, ref usernameValText) &&
                HandlePassLen()
            )
            {
                Admin.Username = usernameTxt.Text;
                Admin.Name = nameTxt.Text;
                Admin.Address = addressTxt.Text;
                Admin.Cell = cellTxt.Text;
                Admin.Email = emailTxt.Text;
                Admin.SignUP(passwordTxt.Text);

                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();

                Reset_All_Fields();

            } else allFieldsWarn.Text = "Fill all Fields correctly";
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            HandlePassLen();
        }

        private void confirmPassTxt_TextChanged(object sender, EventArgs e)
        {
            HandlePassLen();
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Username(usernameTxt.Text)) usernameValText.Text = "";
             else usernameValText.Text = "Invalid Username";
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Email(emailTxt.Text)) emailValText.Text = "";
            else emailValText.Text = "Invalid Email";
        }

        private void cellTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Cell(cellTxt.Text)) cellValText.Text = "";
            else cellValText.Text = "Invalid Cell";
        }

        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            if (Admin.Check_Avail_Username(usernameTxt.Text, ref usernameValText))
            {
                usernameValText.Text = "Username is Available";
                usernameValText.ForeColor = Color.Green;
            }
            else
            {
                usernameValText.Text = "Username is not available";
                usernameValText.ForeColor = Color.Red;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Reset_All_Fields();
        }
    }
}
