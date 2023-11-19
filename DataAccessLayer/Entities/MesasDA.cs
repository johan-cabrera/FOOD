using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Connection;
using Npgsql;

namespace DataAccessLayer.Entities
{
    public class MesasDA : ConnectionSql
    {
        DataTable tables = new DataTable();

        //Metodo para obtener los datos de la tabla mesas
        public DataTable showTables()
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Mesas";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    tables.Clear();
                    tables.Load(reader);
                    return tables;
                }
            }
        }

        //Metodo que inseta una nueva mesa
        public void insertTable(string tableID, string capacity, string state)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
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

        //Metodo que obtiene el valor de una mesa en especifico
        public DataTable getTable(string tableID)
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Mesas WHERE MesaID = @mesaId";

                    command.Parameters.AddWithValue("@mesaId", tableID);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    tables.Clear();
                    tables.Load(reader);
                    return tables;
                }
            }
        }

        //Metodo que actualiza el valor de una mesa
        public void updateTable(string currentId, string tableID, string capacity, string state)
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
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
    }
}
