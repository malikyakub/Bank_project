using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank
{
    internal class Connections
    {
        public static SqlConnection connect()
        {
            string connectionString = "Server=DESKTOP-80I2R36\\SQLEXPRESS;Initial Catalog=samples;Integrated Security=SSPI;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
