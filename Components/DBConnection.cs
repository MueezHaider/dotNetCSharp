using System;
using System.Data.SqlClient;

namespace CarRental.Components
{
    static class DBConnection
    {
        static private SqlConnection _connection;
        static private SqlCommand _cmd;
        static private string _connectionString; /*saving the connection string into class fields*/


        static DBConnection()
        {
            if (Environment.MachineName == "DELL-7470")
            {
                _connectionString = "Data Source=DELL-7470\\SQLEXPRESS;Initial Catalog=ProjectOOP;Integrated Security=True";

            }
            else if (Environment.MachineName == "ASUS-TUF-F15")
            {
                _connectionString = "Data Source=ASUS-TUF-F15\\SQLEXPRESS;Initial Catalog=ProjectOOP;Integrated Security=True";
            } else
            {
                //Muessss
            }

        }

        /*Two overloads of Connect() function*/
        static public SqlConnection Connect()
        {
            _connection = new SqlConnection(@_connectionString);
            _connection.Open();
            return _connection;
        }

        static public SqlConnection Connect(string connectionString)
        {
            _connection = new SqlConnection(@connectionString);
            _connection.Open();
            return _connection;
        }

        static public SqlCommand SqlCmd(string query)
        {
            Connect();

            _cmd = new SqlCommand(query, _connection);
            return _cmd;
        }

        static public SqlDataReader SqlReader(string query)
        {
            Connect();

            SqlCommand cmd = new SqlCommand(query, _connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
