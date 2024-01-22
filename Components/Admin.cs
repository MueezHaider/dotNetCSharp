using System;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace CarRental.Components
{
    class Admin
    {
        private static string username;
        private static string name;
        private static string address;
        private static string email;
        private static string cell;

        public static string Username { get { return username; } set { username = value; } }
        public static string Name { get { return name; } set { name = value; } }
        public static string Address { get { return address; } set { address = value; } }
        public static string Email { get { return email; } set { email = value; } }
        public static string Cell { get { return cell; } set { cell = value; } }

        public static void Update(string _username, string passwd)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader("EXEC Update_AdminDate '"+ _username 
                    + "', '"+ HashPassword(passwd)
                    + "', '"+name+"', '"+ email + "', '"+address+"', '"+cell+"';");

                reader.Read();
                username = _username;
                name = reader["name_"].ToString();
                cell = reader["cell"].ToString();
                address = reader["address_"].ToString();
                email = reader["email"].ToString();
            }
            catch (Exception e)
            {
                Utilz.msgBox("Username or Password is Invalid" + e.ToString(), "Error");
            }

        }


        public static bool login(string _username, string passwd)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader(
                   @"EXEC HandleLogin '"
                    + _username + "', '" +
                    HashPassword(passwd) + "';"
                );
                reader.Read();
                username = _username;
                name = reader["name_"].ToString();
                cell = reader["cell"].ToString();
                address = reader["address_"].ToString();
                email = reader["email"].ToString();

                return true;
            }
            catch
            {
                Utilz.msgBox("Username or Password is Invalid", "Error");
            }

            return false;

        }

        public static void SignUP(string passwd)
        {
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader(
                   @"EXEC HandleSignUp '" + username
                   + "', '" + HashPassword(passwd) + "', '"
                   + name + "', '" + email
                   + "', '" + address + "', '"
                   + cell + "';"
                );

                Utilz.msgBox("You case is sent to Admin", "Sign Up");

            }
            catch
            {
                Utilz.msgBox("Error Occured", "Error");
            }
        }

        public static bool Check_Avail_Username(string _username, ref Label warnLabel)
        {
            warnLabel.Text = "Loading...";          
            try
            {
                DBConnection.Connect();

                SqlDataReader reader = DBConnection.SqlReader("EXEC Check_Username '"+ _username + "';");
                reader.Read();
                if (reader["US"].ToString() == "0") 
                return true;

            }
            catch
            {
                Utilz.msgBox("Error Occured", "Error");
            }
            return false;
        }

        private static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] pass_byte = Encoding.ASCII.GetBytes(password);
            byte[] enc_pass = sha1.ComputeHash(pass_byte);

            return Convert.ToBase64String(enc_pass);
        }

    }
}
