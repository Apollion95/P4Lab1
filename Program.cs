using System;
using System.Data.SqlClient;

namespace P4Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=DESKTOP-BR95J8J\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;MultipleActiveResultSets=True";
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            Wyswietl.Wyswietlanie(connection);
            Console.ReadKey();
            Dodaj.dodawanie(connection);
            Console.ReadKey();
            Wyswietl.Wyswietlanie(connection);
            Console.ReadKey();
            Zmien.zmienianie(connection);
            Console.ReadKey();
            Wyswietl.Wyswietlanie(connection);
            Console.ReadKey();
            Usun.usuwanie(connection);
            Console.ReadKey();
            Wyswietl.Wyswietlanie(connection);
            Console.ReadKey();
            connection.Close();
        }
    }
}