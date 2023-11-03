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
                    command.CommandText = "SELECT * FROM Ordenes";

                    SqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        //Metodo que inserta un registro a las ordenes
        public int insertOrder()
        {
            int orderId;
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Ordenes (MesaID, Estado, CantidadClientes) VALUES ('M00001', 'En Proceso', 0)";

                    command.ExecuteNonQuery();

                    command.CommandText = "SELECT SCOPE_IDENTITY()";
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
