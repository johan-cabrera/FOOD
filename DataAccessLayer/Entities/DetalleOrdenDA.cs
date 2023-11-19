using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Connection;
using System.Xml.Linq;
using Npgsql;

namespace DataAccessLayer.Entities
{
    public class DetalleOrdenDA : ConnectionSql
    {
        DataTable detalleOrden = new DataTable();

        //Metodo para obtener los datos de la tabla DetalleOrden
        public DataTable showOrderDetails(long orderID)
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT M.NombrePlatillo, OD.DetalleOrdenID, OD.Cantidad, OD.Comentarios FROM DetalleOrden OD INNER JOIN Menu M ON M.PlatilloID = OD.PlatilloID WHERE OrdenID = @id";

                    command.Parameters.AddWithValue("@id", orderID);
                    NpgsqlDataReader reader = command.ExecuteReader();

                    detalleOrden.Clear();
                    detalleOrden.Load(reader);
                    return detalleOrden;
                }
            }
        }

        //Metodo que inserta un registro al detalle de las ordenes
        public void insertOrderDetail(long orderID, long dishID, int quantity,  double unitPrice, string comment)
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO DetalleOrden (OrdenID, PlatilloID, Cantidad, Comentarios, PrecioUnitario) VALUES (@orderID, @dishID, @quantity, @comment, @unitPrice)";

                    command.Parameters.AddWithValue("@orderID", orderID);
                    command.Parameters.AddWithValue("@dishID", dishID);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@comment", comment);
                    command.Parameters.AddWithValue("@unitPrice", unitPrice);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que elimina un registro del detalle de las ordenes
        public void deleteOrderDetail(long detailOrderID)
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "DELETE FROM DetalleOrden WHERE DetalleOrdenID = @id";

                    command.Parameters.AddWithValue("@id", detailOrderID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
