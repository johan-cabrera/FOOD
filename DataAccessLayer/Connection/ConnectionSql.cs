using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Connection
{
    public abstract class ConnectionSql
    {
        private string server, db, user, pass;
        private readonly string connectionString;

        public ConnectionSql()
        {
            server = "DESKTOP-BO18SDI";
            db = "FOOD";
            user = "sa";
            pass = "12345";

            connectionString = "Server=" + server + ";uid=" + user + ";pwd=" + pass + ";database=" + db;
        }

        protected SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
