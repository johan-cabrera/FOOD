using DataAccessLayer.Connection;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public struct RevenueByDate
    {
        public DateTime Date { get; set; }
        public double Total { get; set; }
    }
    public struct TopProducts
    {
        public string dish { get; set; }
        public int quantity { get; set; }
    }
    public class InicioDA : ConnectionSql
    {
        //Atributos
        public double TotalRevenue { get; private set; }
        public int TotalSales { get; private set; }
        public int TotalCustomers { get; private set; }
        public int TotalTables { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public List<TopProducts> TopProductsList { get; private set; }

        public InicioDA() { }

        //Metodo para obtener los datos del dashboard
        private void getDashboardValues()
        {
            using(NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;
                    try
                    {
                        command.CommandText = "SELECT SUM(Total) FROM Cuentas WHERE FechaCierre::DATE = CURRENT_DATE";
                        TotalRevenue = Convert.ToDouble(command.ExecuteScalar());

                        command.CommandText = "SELECT COUNT(CuentaID) FROM Cuentas WHERE FechaCierre::DATE = CURRENT_DATE";
                        TotalSales = Convert.ToInt32(command.ExecuteScalar());

                        command.CommandText = "SELECT SUM(O.CantidadClientes) FROM Ordenes O INNER JOIN Cuentas C ON C.OrdenID = O.OrdenID WHERE FechaCierre::DATE = CURRENT_DATE";
                        TotalCustomers = Convert.ToInt32(command.ExecuteScalar());

                        command.CommandText = "SELECT COUNT(MesaID) FROM Mesas WHERE Estado = 'Disponible'";
                        TotalTables = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
        }

        //Metodo para obtener los datos y los labels del bar chart
        private void GetGrossRevenueList()
        {
            GrossRevenueList = new List<RevenueByDate>();
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;

                    command.CommandText = "SELECT FechaCierre, SUM(Total) FROM Cuentas WHERE FechaCierre BETWEEN CURRENT_DATE - INTERVAL '7 days' AND CURRENT_DATE GROUP BY FechaCierre ORDER BY FechaCierre ASC;";

                    NpgsqlDataReader reader = command.ExecuteReader();
                    
                    RevenueByDate result = new RevenueByDate();

                    while (reader.Read())
                    {
                        result.Date = (DateTime)reader[0];
                        result.Total = Convert.ToDouble(reader[1]);

                        GrossRevenueList.Add(result);
                    }

                    reader.Close();
                }
            }
        }

        //Metodo para obtener los datos del top productos mas vendidos
        private void GetTopProductsList()
        {
            TopProductsList = new List<TopProducts>();
            using (NpgsqlConnection conn = getConnection())
            {
                conn.Open();
                using(NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = conn;

                    command.CommandText = "SELECT M.NombrePlatillo, SUM(OD.Cantidad) AS TotalCantidad FROM DetalleOrden OD INNER JOIN Menu M ON M.PlatilloID = OD.PlatilloID INNER JOIN Cuentas C ON C.OrdenID = OD.OrdenID WHERE CAST(C.FechaCierre AS DATE) = CURRENT_DATE GROUP BY M.NombrePlatillo ORDER BY TotalCantidad DESC LIMIT 5;";

                    NpgsqlDataReader reader = command.ExecuteReader();

                    TopProducts result = new TopProducts();

                    while (reader.Read())
                    {
                        result.dish = reader[0].ToString();
                        result.quantity = Convert.ToInt32(reader[1]);

                        TopProductsList.Add(result);
                    }

                    reader.Close();
                }
            }
        }

        //Metodo para actualizar todos los datos del dashboard
        public void LoadData()
        {
            getDashboardValues();
            GetGrossRevenueList();
            GetTopProductsList();
        }

    }
}
