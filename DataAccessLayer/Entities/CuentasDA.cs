using DataAccessLayer.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataAccessLayer.Entities
{
    public class CuentasDA : ConnectionSql
    {
        DataTable bill = new DataTable();
        DataTable tables = new DataTable();
        DataTable ordenes = new DataTable();
        DataTable receipt = new DataTable();

        // Método para obtener el subtotal de la cuenta
        public double getSubTotal(long id)
        {
            double subtotal = 0;
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT SUM(M.Precio * OD.Cantidad) AS Subtotal FROM DetalleOrden OD INNER JOIN Menu M ON OD.PlatilloID = M.PlatilloID WHERE OD.OrdenID = @id GROUP BY OD.OrdenID";

                    command.Parameters.AddWithValue("@id", id);

                    object result = command.ExecuteScalar();

                    if (result != null  && result != DBNull.Value)
                    {
                        subtotal = Convert.ToDouble(result);
                    }
                    
                }
            }

            return subtotal;
        }

        // Método para obtener los datos de la tabla Cuentas
        public DataTable showBill()
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Cuentas ORDER BY CuentaID DESC";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    bill.Clear();
                    bill.Load(reader);
                    return bill;
                }
            }
        }

        // Método para insertar un registro a las cuentas
        public void insertBill(long orderID, DateTime date, double subtotal, double tip, double discount, double total)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
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

        // Método que obtiene el valor de un registro de ordenes por mesaID, que no este cancelado o cerrado
        public DataTable getTablesInOrders()
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT DISTINCT MesaID FROM Ordenes WHERE Estado IN ('En Proceso', 'Lista', 'Servida');";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    tables.Clear();
                    tables.Load(reader);
                    return tables;
                }
            }
        }

        // Método que obtiene el valor de un registro de las ordenes por MesaID
        public DataTable getOrderByTableID(string tableID)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Ordenes WHERE MesaID = @id AND Estado NOT IN ('Cancelada', 'Cerrada')";

                    command.Parameters.AddWithValue("@id", tableID);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    ordenes.Clear();
                    ordenes.Load(reader);
                    return ordenes;
                }
            }
        }

        // Método que obtiene el valor de un registro de cuentas en especifico
        public DataTable getBill(long billID)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM Cuentas WHERE CuentaID = @id";

                    command.Parameters.AddWithValue("@id", billID);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    bill.Clear();
                    bill.Load(reader);
                    return bill;
                }
            }
        }

        // Método que actualiza el estado de una cuenta
        public void updateBill(long billID, string state)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "UPDATE Cuentas SET EstadoPago = @state WHERE CuentaID = @billId";

                    command.Parameters.AddWithValue("@billId", billID);
                    command.Parameters.AddWithValue("@state", state);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para retornar detalles del recibo
        public DataTable receiptBill(long orderID)
        {
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    command.CommandText = "SELECT M.NombrePlatillo, OD.Cantidad, (OD.PrecioUnitario * OD.Cantidad) AS Precio FROM DetalleOrden OD INNER JOIN Menu M ON M.PlatilloID = OD.PlatilloID WHERE OrdenID = @orderID";

                    command.Parameters.AddWithValue("@orderId", orderID);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    receipt.Clear();
                    receipt.Load(reader);
                    return receipt;
                }
            }
        }
    }
}
