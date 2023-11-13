using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Connection
{
    public abstract class ConnectionSql
    {
        private readonly string connectionString;

        public ConnectionSql()
        {
            server = "";
            db = "";
            user = "";
            pass = "";

            connectionString = "Data Source=Localhost;Initial Catalog=FOOD;Integrated Security=True";
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
