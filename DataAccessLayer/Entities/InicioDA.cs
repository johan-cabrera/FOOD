using DataAccessLayer.Connection;
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

    public class InicioDA : ConnectionSql
    {
        //Atributos
        public double TotalRevenue { get; private set; }
        public int TotalSales { get; private set; }
        public int TotalCustomers { get; private set; }
        public int TotalTables { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }

        public InicioDA() { }

        //Metodo para obtener los datos del dashboard
        private void getDashboardValues()
        {
            using(SqlConnection conn = getConnection())
            {
                conn.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;
                    try
                    {
                        command.CommandText = "SELECT SUM(Total) FROM Cuentas";
                        TotalRevenue = Convert.ToDouble(command.ExecuteScalar());

                        command.CommandText = "SELECT COUNT(CuentaID) FROM Cuentas";
                        TotalSales = Convert.ToInt32(command.ExecuteScalar());

                        command.CommandText = "SELECT SUM(CantidadClientes) FROM Ordenes";
                        TotalCustomers = Convert.ToInt32(command.ExecuteScalar());

                        command.CommandText = "SELECT COUNT(MesaID) FROM Mesas WHERE Estado = 'Disponible'";
                        TotalTables = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        //Metodo para obtener los datos y los labels del bar chart
        private void GetGrossRevenueList()
        {
            GrossRevenueList = new List<RevenueByDate>();
            using (SqlConnection conn = getConnection())
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;

                    command.CommandText = @"SELECT FechaCierre, SUM(Total)
                                            FROM Cuentas
                                            WHERE FechaCierre BETWEEN '2023-10-14' AND '2023-10-20'
                                            GROUP BY FechaCierre";
                    
                    SqlDataReader reader = command.ExecuteReader();
                    
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

        //Metodo para actualizar todos los datos del dashboard
        public void LoadData()
        {
            getDashboardValues();
            GetGrossRevenueList();
        }

    }
}
