using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ccharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.connectionString["defaultConnection"].connectionString;
            var query = @"select*
                           from product table 
                           where IdProduct
                           from producto table
                           where description
                           from prices
                           where description
                           from product table
                           where unit
                           from price detail
                           where salevalue";
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da =new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);
                }

            }
            Console.Read();

        }
    }
}
