namespace CarRental.Screens
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarRentalSystemLabel = new System.Windows.Forms.Label();
            this.LodingScreenProgressImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.confirmPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cellTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.signBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SignUpBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.exitIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.warningPass = new System.Windows.Forms.Label();
            this.warningPass2 = new System.Windows.Forms.Label();
            this.allFieldsWarn = new System.Windows.Forms.Label();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cellValText = new System.Windows.Forms.Label();
            this.emailValText = new System.Windows.Forms.Label();
            this.usernameValText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIconBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIconBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.CarRentalSystemLabel);
            this.panel1.Controls.Add(this.LodingScreenProgressImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 655);
            this.panel1.TabIndex = 1;
            // 
            // CarRentalSystemLabel
            // 
            this.CarRentalSystemLabel.AutoSize = true;
            this.CarRentalSystemLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarRentalSystemLabel.Location = new System.Drawing.Point(53, 382);
            this.CarRentalSystemLabel.Name = "CarRentalSystemLabel";
            this.CarRentalSystemLabel.Size = new System.Drawing.Size(224, 31);
            this.CarRentalSystemLabel.TabIndex = 3;
            this.CarRentalSystemLabel.Text = "Car Rental System";
            // 
            // LodingScreenProgressImage
            // 
            this.LodingScreenProgressImage.BackColor = System.Drawing.Color.Transparent;
            this.LodingScreenProgressImage.FillColor = System.Drawing.Color.Transparent;
            this.LodingScreenProgressImage.Image = ((System.Drawing.Image)(resources.GetObject("LodingScreenProgressImage.Image")));
            this.LodingScreenProgressImage.ImageRotate = 0F;
            this.LodingScreenProgressImage.Location = new System.Drawing.Point(32, 171);
            this.LodingScreenProgressImage.Name = "LodingScreenProgressImage";
            this.LodingScreenProgressImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.LodingScreenProgressImage.Size = new System.Drawing.Size(258, 200);
            this.LodingScreenProgressImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LodingScreenProgressImage.TabIndex = 1;
            this.LodingScreenProgressImage.TabStop = false;
            this.LodingScreenProgressImage.UseTransparentBackground = true;
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.usernameTxt.BorderRadius = 10;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTxt.ForeColor = System.Drawing.Color.Black;
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.usernameTxt.Location = new System.Drawing.Point(395, 171);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(446, 48);
            this.usernameTxt.TabIndex = 10;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordTxt.BorderRadius = 10;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTxt.ForeColor = System.Drawing.Color.Black;
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.passwordTxt.Location = new System.Drawing.Point(395, 463);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(446, 48);
            this.passwordTxt.TabIndex = 9;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(389, 52);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(114, 31);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "SIGN UP";
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmPassTxt.BorderRadius = 10;
            this.confirmPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPassTxt.DefaultText = "";
            this.confirmPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPassTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.confirmPassTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmPassTxt.ForeColor = System.Drawing.Color.Black;
            this.confirmPassTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.confirmPassTxt.Location = new System.Drawing.Point(878, 463);
            this.confirmPassTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PasswordChar = '●';
            this.confirmPassTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.confirmPassTxt.PlaceholderText = "Confirm Password";
            this.confirmPassTxt.SelectedText = "";
            this.confirmPassTxt.Size = new System.Drawing.Size(446, 48);
            this.confirmPassTxt.TabIndex = 12;
            this.confirmPassTxt.UseSystemPasswordChar = true;
            this.confirmPassTxt.TextChanged += new System.EventHandler(this.confirmPassTxt_TextChanged);
            // 
            // nameTxt
            // 
            this.nameTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.nameTxt.BorderRadius = 10;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.nameTxt.Location = new System.Drawing.Point(878, 171);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.nameTxt.PlaceholderText = "Name";
            this.nameTxt.SelectedText = "";
            this.nameTxt.Size = new System.Drawing.Size(446, 48);
            this.nameTxt.TabIndex = 13;
            // 
            // addressTxt
            // 
            this.addressTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.addressTxt.BorderRadius = 10;
            this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTxt.DefaultText = "";
            this.addressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addressTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.addressTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTxt.ForeColor = System.Drawing.Color.Black;
            this.addressTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.addressTxt.Location = new System.Drawing.Point(396, 273);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.PasswordChar = '\0';
            this.addressTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.addressTxt.PlaceholderText = "Address";
            this.addressTxt.SelectedText = "";
            this.addressTxt.Size = new System.Drawing.Size(929, 48);
            this.addressTxt.TabIndex = 14;
            // 
            // cellTxt
            // 
            this.cellTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.cellTxt.BorderRadius = 10;
            this.cellTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cellTxt.DefaultText = "";
            this.cellTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cellTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cellTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cellTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cellTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.cellTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cellTxt.ForeColor = System.Drawing.Color.Black;
            this.cellTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.cellTxt.Location = new System.Drawing.Point(395, 365);
            this.cellTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cellTxt.Name = "cellTxt";
            this.cellTxt.PasswordChar = '\0';
            this.cellTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.cellTxt.PlaceholderText = "Cell";
            this.cellTxt.SelectedText = "";
            this.cellTxt.Size = new System.Drawing.Size(446, 48);
            this.cellTxt.TabIndex = 15;
            this.cellTxt.TextChanged += new System.EventHandler(this.cellTxt_TextChanged);
            // 
            // signBtn
            // 
            this.signBtn.BackColor = System.Drawing.Color.Transparent;
            this.signBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.signBtn.BorderRadius = 17;
            this.signBtn.BorderThickness = 1;
            this.signBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.signBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBtn.ForeColor = System.Drawing.Color.Black;
            this.signBtn.Location = new System.Drawing.Point(768, 558);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(180, 45);
            this.signBtn.TabIndex = 16;
            this.signBtn.Text = "Sign Up";
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AutoSize = true;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Red;
            this.SignUpBtn.Location = new System.Drawing.Point(636, 56);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(50, 20);
            this.SignUpBtn.TabIndex = 18;
            this.SignUpBtn.Text = "Login";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(520, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Have Account";
            // 
            // minimizeIconBtn
            // 
            this.minimizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeIconBtn.Image")));
            this.minimizeIconBtn.ImageRotate = 0F;
            this.minimizeIconBtn.Location = new System.Drawing.Point(1296, 3);
            this.minimizeIconBtn.Name = "minimizeIconBtn";
            this.minimizeIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeIconBtn.Size = new System.Drawing.Size(35, 34);
            this.minimizeIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeIconBtn.TabIndex = 36;
            this.minimizeIconBtn.TabStop = false;
            this.minimizeIconBtn.UseTransparentBackground = true;
            this.minimizeIconBtn.Click += new System.EventHandler(this.minimizeIconBtn_Click);
            // 
            // exitIconBtn
            // 
            this.exitIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitIconBtn.Image")));
            this.exitIconBtn.ImageRotate = 0F;
            this.exitIconBtn.Location = new System.Drawing.Point(1334, 0);
            this.exitIconBtn.Name = "exitIconBtn";
            this.exitIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitIconBtn.Size = new System.Drawing.Size(38, 39);
            this.exitIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitIconBtn.TabIndex = 35;
            this.exitIconBtn.TabStop = false;
            this.exitIconBtn.UseTransparentBackground = true;
            this.exitIconBtn.Click += new System.EventHandler(this.exitIconBtn_Click);
            // 
            // warningPass
            // 
            this.warningPass.AutoSize = true;
            this.warningPass.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningPass.ForeColor = System.Drawing.Color.Red;
            this.warningPass.Location = new System.Drawing.Point(1141, 518);
            this.warningPass.Name = "warningPass";
            this.warningPass.Size = new System.Drawing.Size(0, 20);
            this.warningPass.TabIndex = 37;
            // 
            // warningPass2
            // 
            this.warningPass2.AutoSize = true;
            this.warningPass2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningPass2.ForeColor = System.Drawing.Color.Red;
            this.warningPass2.Location = new System.Drawing.Point(1020, 518);
            this.warningPass2.Name = "warningPass2";
            this.warningPass2.Size = new System.Drawing.Size(0, 20);
            this.warningPass2.TabIndex = 38;
            // 
            // allFieldsWarn
            // 
            this.allFieldsWarn.AutoSize = true;
            this.allFieldsWarn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allFieldsWarn.ForeColor = System.Drawing.Color.Red;
            this.allFieldsWarn.Location = new System.Drawing.Point(1159, 558);
            this.allFieldsWarn.Name = "allFieldsWarn";
            this.allFieldsWarn.Size = new System.Drawing.Size(166, 20);
            this.allFieldsWarn.TabIndex = 39;
            this.allFieldsWarn.Text = "Fill all Fields Correctly";
            // 
            // emailTxt
            // 
            this.emailTxt.BorderColor = System.Drawing.Color.DarkGray;
            this.emailTxt.BorderRadius = 10;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTxt.ForeColor = System.Drawing.Color.Black;
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.emailTxt.Location = new System.Drawing.Point(878, 365);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailTxt.PlaceholderText = "Email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.Size = new System.Drawing.Size(446, 48);
            this.emailTxt.TabIndex = 40;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // cellValText
            // 
            this.cellValText.AutoSize = true;
            this.cellValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellValText.ForeColor = System.Drawing.Color.Red;
            this.cellValText.Location = new System.Drawing.Point(754, 417);
            this.cellValText.Name = "cellValText";
            this.cellValText.Size = new System.Drawing.Size(87, 20);
            this.cellValText.TabIndex = 42;
            this.cellValText.Text = "Invalid Cell";
            // 
            // emailValText
            // 
            this.emailValText.AutoSize = true;
            this.emailValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValText.ForeColor = System.Drawing.Color.Red;
            this.emailValText.Location = new System.Drawing.Point(1227, 417);
            this.emailValText.Name = "emailValText";
            this.emailValText.Size = new System.Drawing.Size(98, 20);
            this.emailValText.TabIndex = 43;
            this.emailValText.Text = "Invalid Email";
            // 
            // usernameValText
            // 
            this.usernameValText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValText.ForeColor = System.Drawing.Color.Red;
            this.usernameValText.Location = new System.Drawing.Point(608, 223);
            this.usernameValText.Name = "usernameValText";
            this.usernameValText.Size = new System.Drawing.Size(233, 20);
            this.usernameValText.TabIndex = 78;
            this.usernameValText.Text = "Invalid Username";
            this.usernameValText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 655);
            this.Controls.Add(this.usernameValText);
            this.Controls.Add(this.emailValText);
            this.Controls.Add(this.cellValText);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.allFieldsWarn);
            this.Controls.Add(this.warningPass2);
            this.Controls.Add(this.warningPass);
            this.Controls.Add(this.minimizeIconBtn);
            this.Controls.Add(this.exitIconBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.cellTxt);
            this.Controls.Add(this.confirmPassTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LodingScreenProgressImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeIconBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitIconBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CarRentalSystemLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox LodingScreenProgressImage;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private System.Windows.Forms.Label LoginLabel;
        private Guna.UI2.WinForms.Guna2TextBox confirmPassTxt;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private Guna.UI2.WinForms.Guna2TextBox addressTxt;
        private Guna.UI2.WinForms.Guna2TextBox cellTxt;
        private Guna.UI2.WinForms.Guna2Button signBtn;
        private System.Windows.Forms.Label SignUpBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox minimizeIconBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox exitIconBtn;
        private System.Windows.Forms.Label warningPass;
        private System.Windows.Forms.Label warningPass2;
        private System.Windows.Forms.Label allFieldsWarn;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private System.Windows.Forms.Label cellValText;
        private System.Windows.Forms.Label emailValText;
        private System.Windows.Forms.Label usernameValText;
    }
}