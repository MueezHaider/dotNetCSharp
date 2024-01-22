using System.Data;
using CarRental.Components.SuperInterfaces;

namespace CarRental.Components
{
    abstract class Vehicle: DBIO
    {
        /*fields */
        protected string numberPlate;
        protected string brand;
        protected string model;
        protected string price;


        /*Properties*/
        public string NumberPlate  {  get { return numberPlate; }  set { numberPlate = value; } }

        public string Brand  {  get { return brand; }  set { brand = value; } }

        public string Model { get { return model; } set { model = value; } }

        public string Price { get { return price; } set { price = value; } }

        /*coding inherited fuctions*/
        public abstract void Dump();

        public abstract void Update();

        public abstract DataTable Display();
    }
}
