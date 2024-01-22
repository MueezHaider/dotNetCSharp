using System.Data.SqlClient;
using System.Data;
using CarRental.Components.SuperInterfaces;

namespace CarRental.Components
{
    class Rental : DBIO
    {
        /*fields */
        private int id;
        private string rentalDate;
        private string returnDate;
        private Customer customer;
        private Vehicle vehicle;

        public Rental() { }

        public Rental(int id, string rentalDate, string returnDate)
        {
            this.id = id;
            this.rentalDate = rentalDate;
            this.returnDate = returnDate;
        }

        /*Properties*/
        public Customer Customer_ { get { return customer; } set { customer = value; } }
        public Vehicle Vehicle_ { get { return vehicle; } set { vehicle = value; } }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string RentalDate
        {
            get { return rentalDate; }
            set { rentalDate = value; }
        }

        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        /*coding inherited fuctions*/
        public void Dump()
        {
            SqlCommand cmd = DBConnection.SqlCmd(
                "EXEC Insert_FullRentalsData "
                + id + ", '"
                + rentalDate + "', '"
                + returnDate + "', "
                + customer.Id + ", '"
                + customer.Name + "', '"
                + vehicle.NumberPlate + "', "
                + customer.Pay.ID + ", 1, '"
                + customer.Pay.CardNumber + "', '"
                + customer.Pay.Amount + "', 0;  "
                );
            cmd.ExecuteNonQuery();
        }
        public void Update()
        {
            SqlCommand cmd = DBConnection.SqlCmd(
               "EXEC Update_FullRentalsData "
               + id + ", '"
               + rentalDate + "', '"
               + returnDate + "', "
               + customer.Id + ", '"
               + customer.Name + "', '"
               + vehicle.NumberPlate + "', "
               + customer.Pay.ID + ", 1, '"
               + customer.Pay.CardNumber + "', '"
               + customer.Pay.Amount + "', 0;  "
               );
            cmd.ExecuteNonQuery();
        }

        public DataTable Display()
        {
            string query = "EXEC Get_FullRentalData;";
            SqlDataReader reader = DBConnection.SqlReader(query);

            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public static string NewRentalId()
        {
            string query = "EXEC GetNewRentalID;";
            SqlDataReader reader = DBConnection.SqlReader(query);

            reader.Read();
            return reader["ID"].ToString();
        }
    }
}
