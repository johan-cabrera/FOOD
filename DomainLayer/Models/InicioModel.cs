using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class InicioModel
    {
        //Atributos
        private InicioDA inicio;
        public double TotalRevenue { get; set; }
        public int TotalSales { get; set; }
        public int TotalCustomers { get; set; }
        public int TotalTables { get; set; }
        public DataTable GrossRevenueList { get; set; }

        //Constructor
        public InicioModel() 
        {
            inicio = new InicioDA();
            GrossRevenueList = new DataTable();
            GrossRevenueList.Columns.Add("Date", typeof(DateTime));
            GrossRevenueList.Columns.Add("Revenue", typeof (double));
        }

        //Actualizar los valores del modelo
        public void GetDashboardData()
        {
            inicio.LoadData();
            TotalRevenue = inicio.TotalRevenue;
            TotalSales = inicio.TotalSales;
            TotalCustomers = inicio.TotalCustomers;
            TotalTables = inicio.TotalTables;

            foreach (RevenueByDate row in inicio.GrossRevenueList)
            {
                GrossRevenueList.Rows.Add(row.Date, row.Total);
            }
        }
    }
}
