
using System;
using static System.Console;

// SQLite Spatial
using Microsoft.Data.Sqlite;

namespace SQLiteCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            
            // Create Connection
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./db.db";

            using (var connection = new SqliteConnection(
                connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                // Create Table
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = "CREATE TABLE favorite_beers(name VARCHAR(50));";
                tableCmd.ExecuteNonQuery();
                
                // Insert Some Record
                using (var transaction = connection.BeginTransaction())
                {
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = "INSERT INTO favorite_beers VALUES('Efes')";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO favorite_beers VALUES('Tuborg')";
                    insertCmd.ExecuteNonQuery();
                    insertCmd.CommandText = "INSERT INTO favorite_beers VALUES('Beks')";
                    insertCmd.ExecuteNonQuery();
                    
                    transaction.Commit();
                }
                
                // Read Record
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM favorite_beers";
                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var result = reader.GetString(0);
                        WriteLine(result);
                    }
                }
            }

        }
    }
}