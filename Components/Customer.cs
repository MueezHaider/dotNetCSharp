using CarRental.Components.SuperInterfaces;
using System.Data;
using System.Data.SqlClient;

namespace CarRental.Components
{
    class Customer : DBIO
    {
        /*fields */
        private int id;
        private string name;
        private string age;
        private string address;
        private string cell;
        private int isVIP;
        private Payment payment;

        /*Constructor*/
        public Customer() { }

        public Customer(string id, string name, string age, string address, string cell, bool vip)
        {
            this.id = int.Parse(id);
            this.name = name;
            this.age = age;
            this.address = address;
            this.cell = cell;
            IsVIP = vip;
        }

        /*Properties*/
        public Payment Pay { get { return payment; } set { payment = value; } }

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public string Address { get { return address; } set { address = value; } }

        public bool IsVIP
        {
            get
            {
                if (isVIP == 1) return true;
                else return false;
            }
            set
            {
                if (value) isVIP = 1;
                else isVIP = 0;
            }
        }


        public string Cell { get { return cell; } set { cell = value; } }

        public string Age { get { return age; } set { age = value; } }



        /*coding inherited fuctions*/
        public void Dump()
        {
            SqlCommand cmd = DBConnection.SqlCmd("EXEC Insert_Customer " + id + ", " + age + ", " + isVIP + ", '" + cell + "', '" + name + "', '" + address + "';");
            cmd.ExecuteNonQuery();
        }

        public void Update()
        {
            SqlCommand cmd = DBConnection.SqlCmd("EXEC Update_Customer " + id + ", " + age + ", " + isVIP + ", '" + cell + "', '" + name + "', '" + address + "';");
            cmd.ExecuteNonQuery();

        }

        public DataTable Display()
        {
            string query = "EXEC Get_Customers;";
            SqlDataReader reader = DBConnection.SqlReader(query);
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public static string NewCustId()
        {
            string query = "EXEC GetNewCusId;";
            SqlDataReader reader = DBConnection.SqlReader(query);

            reader.Read();
            return reader["ID"].ToString();
        }

        public static string[] CheckCustomer(string id)
        {
            string[] r = new string[2] {"", ""};

            try
            {
                string query = "EXEC Check_Customer_ID " + id + ";";
                SqlDataReader reader = DBConnection.SqlReader(query);

                

                reader.Read();

                r[0] = reader["count_"].ToString();

                query = "EXEC Check_CustomerName " + id + ";";

                SqlDataReader reader1 = DBConnection.SqlReader(query);



                reader1.Read();

                r[1] = reader1["customerName"].ToString();

                return r;
            }
            catch
            {

            }
            
            return r;
        }

    }
}
