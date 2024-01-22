namespace CarRental.Screens
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CarRentalSystemLabel = new System.Windows.Forms.Label();
            this.LodingScreenProgressImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameValTxt = new System.Windows.Forms.Label();
            this.passowordValTxt = new System.Windows.Forms.Label();
            this.SignUpBtn = new System.Windows.Forms.Label();
            this.minimizeIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.exitIconBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
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
            this.panel1.Size = new System.Drawing.Size(330, 599);
            this.panel1.TabIndex = 0;
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
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(473, 102);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(92, 31);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "LOGIN";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.LoginBtn.BorderRadius = 17;
            this.LoginBtn.BorderThickness = 1;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(766, 355);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(180, 45);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
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
            this.passwordTxt.Location = new System.Drawing.Point(479, 265);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(467, 48);
            this.passwordTxt.TabIndex = 7;
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
            this.usernameTxt.Location = new System.Drawing.Point(479, 171);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(467, 48);
            this.usernameTxt.TabIndex = 8;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(580, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "New? sign up here";
            // 
            // usernameValTxt
            // 
            this.usernameValTxt.AutoSize = true;
            this.usernameValTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameValTxt.ForeColor = System.Drawing.Color.Red;
            this.usernameValTxt.Location = new System.Drawing.Point(811, 223);
            this.usernameValTxt.Name = "usernameValTxt";
            this.usernameValTxt.Size = new System.Drawing.Size(0, 20);
            this.usernameValTxt.TabIndex = 12;
            this.usernameValTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passowordValTxt
            // 
            this.passowordValTxt.AutoSize = true;
            this.passowordValTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passowordValTxt.ForeColor = System.Drawing.Color.Red;
            this.passowordValTxt.Location = new System.Drawing.Point(625, 317);
            this.passowordValTxt.Name = "passowordValTxt";
            this.passowordValTxt.Size = new System.Drawing.Size(0, 20);
            this.passowordValTxt.TabIndex = 13;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AutoSize = true;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.Red;
            this.SignUpBtn.Location = new System.Drawing.Point(721, 107);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(62, 20);
            this.SignUpBtn.TabIndex = 16;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // minimizeIconBtn
            // 
            this.minimizeIconBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeIconBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeIconBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeIconBtn.Image")));
            this.minimizeIconBtn.ImageRotate = 0F;
            this.minimizeIconBtn.Location = new System.Drawing.Point(1002, 5);
            this.minimizeIconBtn.Name = "minimizeIconBtn";
            this.minimizeIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeIconBtn.Size = new System.Drawing.Size(35, 34);
            this.minimizeIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeIconBtn.TabIndex = 34;
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
            this.exitIconBtn.Location = new System.Drawing.Point(1040, 5);
            this.exitIconBtn.Name = "exitIconBtn";
            this.exitIconBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitIconBtn.Size = new System.Drawing.Size(35, 34);
            this.exitIconBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitIconBtn.TabIndex = 33;
            this.exitIconBtn.TabStop = false;
            this.exitIconBtn.UseTransparentBackground = true;
            this.exitIconBtn.Click += new System.EventHandler(this.exitIconBtn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 599);
            this.Controls.Add(this.minimizeIconBtn);
            this.Controls.Add(this.exitIconBtn);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.passowordValTxt);
            this.Controls.Add(this.usernameValTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox LodingScreenProgressImage;
        private System.Windows.Forms.Label CarRentalSystemLabel;
        private System.Windows.Forms.Label LoginLabel;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameValTxt;
        private System.Windows.Forms.Label passowordValTxt;
        private System.Windows.Forms.Label SignUpBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox minimizeIconBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox exitIconBtn;
    }
}