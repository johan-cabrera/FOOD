using DataAccessLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class OrdenesDA : ConnectionSql
    {
        DataTable ordenes = new DataTable();

        //Metodo para obtener los datos de la tabla ordenes
        public DataTable showOrders()
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ordenes ORDER BY OrdenID DESC";

                    SqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        //Metodo que inserta un registro a las ordenes
        public int insertOrder(string TableID, string state, int customers)
        {
            int orderId;
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Ordenes (MesaID, Estado, CantidadClientes) VALUES (@tableID, @state, @customers); SELECT SCOPE_IDENTITY();";

                    command.Parameters.AddWithValue("@tableID", TableID);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@customers", customers);

                    orderId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return orderId;
        }

        //Metodo que obtiene el valor de un registro de las ordenes en especifico
        public DataTable getOrder(int orderID)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ordenes WHERE OrdenID = @id";

                    command.Parameters.AddWithValue("@id", orderID);

                    SqlDataReader reader = command.ExecuteReader();

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

            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT DISTINCT MesaID FROM Ordenes WHERE Estado IN ('En Proceso', 'Lista', 'Servida');";

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string mesaID = reader["MesaID"].ToString();
                        tableList.Add(mesaID);
                    }
                }
            }

            return tableList;
        }

        public void updateOrder(int orderID, string tableID, string state, int quantity)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand()) 
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
