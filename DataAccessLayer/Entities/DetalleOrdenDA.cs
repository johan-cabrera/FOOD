using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Connection;
using System.Xml.Linq;

namespace DataAccessLayer.Entities
{
    public class DetalleOrdenDA : ConnectionSql
    {
        DataTable detalleOrden = new DataTable();

        //Metodo para obtener los datos de la tabla DetalleOrden
        public DataTable showOrderDetails(int orderID)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT M.NombrePlatillo, DO.DetalleOrdenID, DO.Cantidad, DO.Comentarios FROM DetalleOrden DO INNER JOIN Menu M ON M.PlatilloID = DO.PlatilloID WHERE OrdenID = @id";

                    command.Parameters.AddWithValue("@id", orderID);
                    SqlDataReader reader = command.ExecuteReader();

                    detalleOrden.Clear();
                    detalleOrden.Load(reader);
                    return detalleOrden;
                }
            }
        }

        //Metodo que inserta un registro al detalle de las ordenes
        public void insertOrderDetail(int orderID, int dishID, int quantity,  double unitPrice, string comment)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
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
        public void deleteOrderDetail(int detailOrderID)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
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
