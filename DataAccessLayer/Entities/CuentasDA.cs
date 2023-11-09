using DataAccessLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class CuentasDA : ConnectionSql
    {
        DataTable bill = new DataTable();
        DataTable tables = new DataTable();
        DataTable ordenes = new DataTable();
        DataTable receipt = new DataTable();

        //Metodo para obtener el sub total de la cuenta
        public double getSubTotal(int id)
        {
            double subtotal;
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand()) 
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT SUM(M.Precio * DO.Cantidad) AS Subtotal FROM DetalleOrden DO INNER JOIN Menu M ON DO.PlatilloID = M.PlatilloID WHERE DO.OrdenID = @id GROUP BY DO.OrdenID";

                    command.Parameters.AddWithValue("@id", id);

                    subtotal = double.Parse(command.ExecuteScalar().ToString());
                }
            }

            return subtotal;
        }

        //Metodo para obtener los datos de la tabla Cuentas
        public DataTable showBill()
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Cuentas ORDER BY CuentaID DESC";

                    SqlDataReader reader = command.ExecuteReader();

                    bill.Clear();
                    bill.Load(reader);
                    return bill;
                }
            }
        }

        //Metodo para insertar un registro a las cuentas
        public void insertBill(int orderID, DateTime date, double subtotal, double tip, double discount, double total)
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "INSERT INTO Cuentas (OrdenID, FechaCierre, SubTotal, Propinas, Descuentos, Total, EstadoPago) VALUES (@orderID, @date, @subtotal, @tip, @discount, @total, 'Pendiente')";

                    command.Parameters.AddWithValue("@orderID", orderID);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@tip", tip);
                    command.Parameters.AddWithValue("@discount", discount);
                    command.Parameters.AddWithValue("@total", total);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo que obtiene el valor de un registro de ordenes por mesaID, que no este cancelado o cerrado
        public DataTable getTablesInOrders()
        {
            using(SqlConnection conn = getConnection()) 
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT DISTINCT MesaID FROM Ordenes WHERE Estado IN ('En Proceso', 'Lista', 'Servida');";

                    SqlDataReader reader = command.ExecuteReader();

                    tables.Clear();
                    tables.Load(reader);
                    return tables;
                }
            }
        }

        //Metodo que obtiene el valor de un registro de las ordenes por MesaID
        public DataTable getOrderByTableID(string tableID)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ordenes WHERE MesaID = @id AND Estado NOT IN ('Cancelada', 'Cerrada')";

                    command.Parameters.AddWithValue("@id", tableID);

                    SqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        //Metodo que obtiene el valor de un registro de cuentas en especifico
        public DataTable getBill(int billID)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Cuentas WHERE CuentaID = @id";

                    command.Parameters.AddWithValue("@id", billID);

                    SqlDataReader reader = command.ExecuteReader();

                    bill.Clear();
                    bill.Load(reader);
                    return bill;
                }
            }
        }

        //Metodo que actualiza el estado de una cuenta
        public void updateBill(int billID, string state)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Cuentas SET EstadoPago = @state WHERE CuentaID = @billId";

                    command.Parameters.AddWithValue("@billId", billID);
                    command.Parameters.AddWithValue("@state", state);


                    command.ExecuteNonQuery();
                }
            }
        }

        //Metodo para retornar detalles del recibo
        public DataTable receiptBill(int orderID)
        {
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT M.NombrePlatillo, DO.Cantidad, (DO.PrecioUnitario * DO.Cantidad) AS Precio FROM DetalleOrden DO INNER JOIN Menu M ON M.PlatilloID = DO.PlatilloID WHERE OrdenID = @orderID";

                    command.Parameters.AddWithValue("@orderId", orderID);


                    SqlDataReader reader = command.ExecuteReader();

                    receipt.Clear();
                    receipt.Load(reader);
                    return receipt;
                }
            }
        }
    }
}
