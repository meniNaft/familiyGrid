using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TimeClock.DAL
{
    static internal class DbContext
    {
        static IConfiguration? builder;
        static string? connString;
        static private bool isFirstLoad = true;
        static void InitConnString()
        {
          isFirstLoad = false;
          builder = new ConfigurationBuilder()
          .AddJsonFile("secrets.json", optional: true)
          .Build();
          connString = builder["ConnectionString"];
        }
        static  public DataTable MakeQuery(string query, List<SqlParameter>? sqlParams = null) {
            if(isFirstLoad)
            { 
                InitConnString();
            }
            DataTable outPut = new();
            using (SqlConnection conn = new(connString)) {
                try
                {
                    conn.Open();
                    using SqlCommand cmd = new(query, conn);
                    if (sqlParams != null) {
                        cmd.Parameters.AddRange([.. sqlParams]);
                    }
                    using SqlDataAdapter adapter = new(cmd);
                    adapter.Fill(outPut);
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return outPut;
        }
    }
}
