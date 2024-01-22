using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarRental.Components
{
    static class Utilz
    {
        public static bool questionBox(string message = "Do You Want To Exit", string title = "Car Rental System")
        {
            DialogResult res = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            return (res == DialogResult.Yes);
        }

        public static void msgBox(string message, string title)
        {
            MessageBox.Show(
                message,
                title
                );
        }

        public static string makeDate(string datetimeText)
        {
            DateTime dt = DateTime.Parse(datetimeText);

            /*Concating whole date*/
            return (dt.Year + "-" + dt.Month + "-" + dt.Day);
        }

        public static bool Validate_Email(string email)
        {
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(email))
                return true;

            return false;
        }
        
        public static bool Validate_Username(string username)
        {
            string strRegex = @"^[a-zA-Z][a-zA-Z0-9]{3,9}$";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(username))
                return true;

            return false;
        }

        public static bool Validate_Cell(string phoneNumber)
        {
            {
                string strRegex = @"(^[0-9]{11}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

                Regex re = new Regex(strRegex);

                if (re.IsMatch(phoneNumber))
                    return true;

                return false;
            }
        }


        public static bool Validate_Card(string cardNumber)
        {
            {
                string strRegex = @"^4[0-9]{12}(?:[0-9]{3})?$";

                Regex re = new Regex(strRegex);

                if (re.IsMatch(cardNumber))
                    return true;

                return false;
            }
        }

        public static bool Validate_Name(string name)
        {
            string strRegex = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(name))
                return true;

            return false;
        }

        public static bool Validate_Age(string age)
        {
            {
                string strRegex = @"^[0-9][0-9]+$";

                Regex re = new Regex(strRegex);

                if (re.IsMatch(age))
                    return true;

                return false;
            }
        }
    }
}
