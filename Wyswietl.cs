using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace P4Lab1
{
    class Wyswietl
    {
        public static void Wyswietlanie(SqlConnection connection)
        {
            var wybierz = "SELECT * From Employees";
            var komenda = new SqlCommand(wybierz, connection);
            var reader = komenda.ExecuteReader();
           foreach(DbDataRecord item in reader)
            {
                Console.WriteLine(reader[0]);
                Console.WriteLine(reader[1]);
            }
        }
    }
}
