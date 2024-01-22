using System.Data;
using System.Data.SqlClient;

namespace CarRental.Components
{
    class Truck: Vehicle
    {
        private int loadCapacity;

        public Truck(string numberPlate, string brand, string model, string price, int loadCapacity)
        {
            this.numberPlate = numberPlate;
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.loadCapacity = loadCapacity;
        }

        public Truck()
        {

        }

        private int LoadCapacity { get { return loadCapacity; } set { loadCapacity = value; } }

        public override void Dump()
        {
            SqlCommand cmd = DBConnection.SqlCmd("EXEC Insert_Trucks '" + brand + "', '" + model + "', '" + price + "', '" + numberPlate + "', " + loadCapacity + ";");
            cmd.ExecuteNonQuery();
        }
        public override void Update()
        {
            SqlCommand cmd = DBConnection.SqlCmd("EXEC Update_Truck '" + brand + "', '" + model + "', '" + price + "', '" + numberPlate + "', " + loadCapacity + ";");
            cmd.ExecuteNonQuery();
        }

        public override DataTable Display()
        {

            string query = "EXEC Get_Trucks;";
            var reader = DBConnection.SqlReader(query);
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

        public static DataTable AvailTrucks()
        {
            string query = "EXEC Get_BrandModelTruck;";
            var reader = DBConnection.SqlReader(query);
            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;
        }

      
    }
}
