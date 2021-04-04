using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace P4Lab1
{
    class Dodaj
    {
        public static void dodawanie(SqlConnection connection)
        {
            var wstaw = $"INSERT INTO Employees ( LastName, FirstName) VALUES (@Last, @First)";
            var komenda = new SqlCommand(wstaw, connection);
        
            komenda.Parameters.Add(new SqlParameter("Last", "Kowalski"));
            komenda.Parameters.Add(new SqlParameter("First", "Jan"));

            komenda.ExecuteNonQuery();
        }
    }
}
