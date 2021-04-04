using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace P4Lab1
{
    class Zmien
    {
        public static void zmienianie(SqlConnection connection)
        {


            var zmien = $"UPDATE Employees SET LastName = @Last WHERE EmployeeID=@ID";
            var zmien2 = $"UPDATE Employees SET FirstName = @First WHERE EmployeeID=@ID";
            var komenda = new SqlCommand(zmien, connection);
            komenda.Parameters.Add(new SqlParameter("@ID",10));
            komenda.Parameters.Add(new SqlParameter("@Last", "Nowak"));
            komenda.Parameters.Add(new SqlParameter("@First", "Tomasz"));
            komenda.ExecuteNonQuery();
        }
    }

}
