using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public static class SqlDbService
    {
        public static string ExecuteAction(string f, string l)
        {
            var tempRes = "";
            using (var connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=Database;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=600;Encrypt=False;TrustServerCertificate=False"))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = new SqlCommand("[dbo].[GetFinalRes] @firstName = '" + f + "', @lastName= '" + l + "'", connection).ExecuteReader();
                    while (reader.Read())
                    {
                        tempRes += reader[0].ToString() + " ";
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return tempRes;
        }
    }
}
