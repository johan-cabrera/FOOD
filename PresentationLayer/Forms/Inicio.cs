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
        List<double> barData = new List<double>();
        string[] barLabels = new string[7];

        List<double> donnutData = new List<double>();
        string[] donnutLabels = new string[5];


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
            DataTable barTable = inicioModel.GrossRevenueList;

            int index = 0;
            foreach (DataRow row in barTable.Rows)
            {
                DateTime date = (DateTime)row["Date"];
                if (index < barLabels.Length) 
                {
                    barLabels[index] = date.ToString("dd MMM"); 
                }

                barData.Add(Convert.ToDouble(row["Revenue"]));

                index++;
            }

            barChartGanacias.Data = barData;
            chartGanancias.Labels = barLabels;

            //Asignar datos a la grafica de dona
            DataTable donnutTable = inicioModel.TopProductList;

            index = 0;
            foreach (DataRow row in donnutTable.Rows)
            {
                if(index < donnutLabels.Length)
                {
                    donnutLabels[index] = row["Dish"].ToString();
                }

                donnutData.Add(Convert.ToDouble(row["Quantity"]));

                index++;
            }

            donnutChartPopulares.Data = donnutData;
            chartPopulares.Labels = donnutLabels;

        }

    }
}
