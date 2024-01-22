using System;
using System.Data;
using System.Data.SqlClient;

namespace CarRental.Components
{
    class Car : Vehicle
    {
        private int noOfPassengers;

        public Car() { }

        public Car(string numberPlate, string brand, string model, string price, int noOfPassengers)
        {
            this.numberPlate = numberPlate;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.noOfPassengers = noOfPassengers;
        }

        private int NoOfPassengers
        {
            get { return noOfPassengers; }
            set { noOfPassengers = value; }
        }
        public override void Dump()
        {
            SqlCommand cmd = DBConnection.SqlCmd("EXEC Insert_Cars '" + brand + "', '" + model + "', '" + price + "', '" + numberPlate + "', " + noOfPassengers + ";");
            cmd.ExecuteNonQuery();
        }

        public override void Update()
        {
            SqlCommand cmd = DBConnection.SqlCmd("EXEC Update_Car '" + brand + "', '" + model + "', '" + price + "', '" + numberPlate + "', " + noOfPassengers + ";");
            cmd.ExecuteNonQuery();
        }

        public override DataTable Display()
        {
            string query = "EXEC Get_Cars;";
            SqlDataReader reader = DBConnection.SqlReader(query);
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public static DataTable AvailCars()
        {
            string query = "EXEC Get_BrandModelCar;";
            var reader = DBConnection.SqlReader(query);
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }
    }
}
