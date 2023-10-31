using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOOD
{
    public partial class Inicio : Form
    {
        List<double> data = new List<double>();
        string[] labels = new string[7];
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Instanciamos la capa de dominio
            InicioModel inicioModel = new InicioModel();

            inicioModel.GetDashboardData();

            //Asignamos los datos a la vista
            lblIngresos.Text = $"$ {inicioModel.TotalRevenue}";
            lblVentas.Text = inicioModel.TotalSales.ToString();
            lblClientes.Text = inicioModel.TotalCustomers.ToString();
            lblMesas.Text = inicioModel.TotalTables.ToString();

            DateTime Currentdate = DateTime.Now;
            lblFechaActual.Text = Currentdate.ToString("dddd d 'de' MMMM 'de' yyyy").ToUpper();

            //Asignamos los datos a la grafica de barras
            DataTable dt = inicioModel.GrossRevenueList;

            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                DateTime date = (DateTime)row["Date"];
                if (index < labels.Length) 
                {
                    labels[index] = date.ToString("dd MMM"); 
                }

                data.Add(Convert.ToDouble(row["Revenue"]));

                index++;
            }

            barChartGanacias.Data = data;
            chartGanancias.Labels = labels;
        }

    }
}
