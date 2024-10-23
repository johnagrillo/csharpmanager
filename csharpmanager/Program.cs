using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.SqlTypes;


namespace csharpmanager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string databasePath = @"C:"; // Use .mdb for older formats
            string databasePath = "C:/Users/john/sandbox/mdb/fssl/2023.mdb";

            //string connectionString = $@"Driver={{Microsoft Access Driver (*.mdb, *.accdb)}};Dbq={databasePath};Uid=;Pwd=5hY-tek";
            string connectionString = $@"Driver={{Driver do Microsoft Access (*.mdb)}};Dbq={databasePath};Uid=;Pwd=5hY-tek";
            Console.WriteLine(connectionString);

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    string query = "SELECT * FROM Athlete"; // Replace with your table name
                    OdbcCommand command = new OdbcCommand(query, connection);
                    OdbcDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Assuming your table has a column named 'ColumnName'
                        Console.WriteLine(reader["ColumnName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }

}
