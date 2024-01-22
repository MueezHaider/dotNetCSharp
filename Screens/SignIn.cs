using CarRental.Components;
using System;
using System.Windows.Forms;

namespace CarRental.Screens
{
    public partial class SignIn : Form
    {

        public SignIn()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox())
                Application.Exit();
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (Utilz.Validate_Username(usernameTxt.Text))
                usernameValTxt.Text = "";
            else
                usernameValTxt.Text = "Invalid Username";
            
        }

        private void MinimizeLabelTopRight_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitLabelTopRight_Click(object sender, EventArgs e)
        {
            if (Utilz.questionBox())
                Application.Exit();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Utilz.Validate_Username(usernameTxt.Text))
            {
                if (Admin.login(usernameTxt.Text, passwordTxt.Text))
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
            else
                {
                    passowordValTxt.Text = "Password must be greater then 4 letters";
                    usernameValTxt.Text = "Inavlid Username";
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

        
    }
}
