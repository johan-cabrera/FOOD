using DataAccessLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataAccessLayer.Entities
{
    public class OrdenesDA : ConnectionSql
    {
        DataTable ordenes = new DataTable();

        //Metodo para obtener los datos de la tabla ordenes
        public DataTable showOrders()
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ordenes ORDER BY OrdenID DESC";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        //Metodo que inserta un registro a las ordenes
        public long insertOrder(string TableID, string state, int customers)
        {
            long orderId;
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Ordenes (MesaID, Estado, CantidadClientes) VALUES (@tableID, @state, @customers) RETURNING OrdenID;";


                    command.Parameters.AddWithValue("@tableID", TableID);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@customers", customers);

                    orderId = Convert.ToInt64(command.ExecuteScalar());
                }
            }

            return orderId;
        }

        //Metodo que obtiene el valor de un registro de las ordenes en especifico
        public DataTable getOrder(long orderID)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ordenes WHERE OrdenID = @id";

                    command.Parameters.AddWithValue("@id", orderID);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        //Metodo que obtiene las mesas que tienen ordenes activas
        public List<string> getTablesInOrders()
        {
            List<string> tableList = new List<string>();

            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT DISTINCT MesaID FROM Ordenes WHERE Estado IN ('En Proceso', 'Lista', 'Servida');";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string mesaID = reader["MesaID"].ToString();
                        tableList.Add(mesaID);
                    }
                }
            }

            return tableList;
        }

        public void updateOrder(long orderID, string tableID, string state, int quantity)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Ordenes SET MesaID = @tableId, Estado = @state, CantidadClientes = @quantity WHERE OrdenID = @orderId";

                    command.Parameters.AddWithValue("@orderId", orderID);
                    command.Parameters.AddWithValue("@tableId", tableID);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@quantity", quantity);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
