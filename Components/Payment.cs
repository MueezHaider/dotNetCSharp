using System.Data.SqlClient;


namespace CarRental.Components
{
    class Payment
    {
        /*Fields*/
        private int id;
        private string cardNumber;
        private double amount;

        public Payment() { }

        public Payment(int id, string cardNumber, double amount)
        {
            this.id = id;
            this.cardNumber = cardNumber;
            this.amount = amount;
        }

        /*Properties*/
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }


       
        public static string NewPaymentId()
        {
            string query = "EXEC GetNewPaymentID;";
            SqlDataReader reader = DBConnection.SqlReader(query);

            reader.Read();
            return reader["ID"].ToString();
        }
    }
}
