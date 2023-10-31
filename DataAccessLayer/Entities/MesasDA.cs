using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Connection;

namespace DataAccessLayer.Entities
{
    public class MesasDA : ConnectionSql
    {
        DataTable tables = new DataTable();

        //Metodo para obtener los datos de la tabla mesas
        public DataTable showTables()
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Mesas";

                    SqlDataReader reader = command.ExecuteReader();

                    tables.Clear();
                    tables.Load(reader);
                    return tables;
                }
            }
        }

        //Metodo que inseta una nueva tabla
        public void insertTable(string tableID, string capacity, string state)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Mesas VALUES (@id, @capacity, @state)";

                    command.Parameters.AddWithValue("@id", tableID);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@state", state);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que obtiene el valor de una tabla en especifico
        public DataTable GetTable(string tableID)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using( SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Mesas WHERE MesaID = @mesaId";

                    command.Parameters.AddWithValue("@mesaId", tableID);

                    SqlDataReader reader = command.ExecuteReader();

                    tables.Clear();
                    tables.Load(reader);
                    return tables;
                }
            }
        }

        //Metodo que actualiza el valor de una tabla
        public void updateTable(string currentId, string tableID, string capacity, string state)
        {
            using( SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Mesas SET MesaID = @id, Capacidad = @capacity, Estado = @state WHERE MesaID = @currentId";

                    command.Parameters.AddWithValue("@currentId", currentId);
                    command.Parameters.AddWithValue("@id", tableID);
                    command.Parameters.AddWithValue("@capacity", capacity);
                    command.Parameters.AddWithValue("@state", state);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que elimina el valor de una tabla
        public void deleteTable(string tableId)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "DELETE FROM Mesas WHERE MesaID = @id";

                    command.Parameters.AddWithValue("@id", tableId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
