
using System.Data;
using Npgsql;

namespace Parcial02
{
    public class ConnectionDB
    {
         private static string host = "127.0.0.1",
                    database = "Parcial02",
                    userId = "postgres",
                    password = "123abcde";

         private static string sConection =
             string.Format("Server={0};Port=5432;User Id={1};Password={2};Database={3};", host, userId, password,
                 database);
                    //"sslmode=Require;Trust Server Certificate=true";
        
                public static DataTable ExecuteQuery(string query)
                {
                    NpgsqlConnection conection = new NpgsqlConnection(sConection);
                    DataSet ds = new DataSet();
                    conection.Open();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conection);
                    da.Fill(ds);
                    conection.Close();
                    return ds.Tables[0];
                }
        
                public static void ExecuteNonQuery(string act)
                {
                    NpgsqlConnection connection = new NpgsqlConnection(sConection);
                    connection.Open();
                    NpgsqlCommand com = new NpgsqlCommand(act, connection);
                    com.ExecuteNonQuery();
                    connection.Close();
                }
    }
}