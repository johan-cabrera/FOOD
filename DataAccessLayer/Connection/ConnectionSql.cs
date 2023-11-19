using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataAccessLayer.Connection
{
    public abstract class ConnectionSql
    {
        private readonly string connectionString;

        public ConnectionSql()
        {
            connectionString = "Host=db-food-6233.g8z.cockroachlabs.cloud;Port=26257;Database=food;Username=food;Password=gSLGWJO-1JApvNLuhb09HQ;SslMode=Require;TrustServerCertificate=true";
        }

        protected NpgsqlConnection getConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
