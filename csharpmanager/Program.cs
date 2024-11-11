using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.SqlTypes;
using db.tm;
using System.Xml.Linq;

namespace csharpmanager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string databasePath = "C:\\Users\\john\\sandbox\\mdb\\fssl\\2023.mdb";

            string connectionString = $@"Driver={{Microsoft Access Driver (*.mdb, *.accdb)}};Dbq={databasePath};Uid=;Pwd=5hY-tek";
            Console.WriteLine(connectionString);

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");

                    var ath = db.tm.Athlete.Get(connection);
                    //foreach (var athlete in ath.Values)
                    //{

                    //    Console.WriteLine($"Athlete ID: {athlete.Athlete}, Name: {athlete.First} {athlete.Last}, Team1: {athlete.Team1}");
                   // }

                    var results = Result.Get(connection);
                    foreach (var result in results)
                    {
                        Console.WriteLine($"Result : {result.Athlete}, {result.Distance}");
                    }





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
