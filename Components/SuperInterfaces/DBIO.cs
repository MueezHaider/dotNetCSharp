using System.Data;

namespace CarRental.Components.SuperInterfaces
{
    interface DBIO
    {
        void Dump();
        void Update();
        DataTable Display();
    }

}

