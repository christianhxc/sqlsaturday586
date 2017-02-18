using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Build connection string
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "<YourStrong!Passw0rd>";      // update me
            builder.InitialCatalog = "master";

            // Connect to SQL
            Console.Write("Connecting to SQL Server ... ");
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                Console.WriteLine("Done.");
            }
        }
        catch (SqlException e)
        {
            Console.WriteLine(e.ToString());
        }

        Console.WriteLine("All done. Press any key to finish...");
        Console.ReadKey(true);
    }
}