using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace P4Lab1
{
    class Usun
    {
        public static void usuwanie(SqlConnection connection)
        {
            var usun = $"DELETE FROM Employees WHERE EmployeeID=@ID";
            var komenda = new SqlCommand(usun, connection);
            komenda.Parameters.Add(new SqlParameter("@ID",12));
            komenda.ExecuteNonQuery();
        }
    }
}
