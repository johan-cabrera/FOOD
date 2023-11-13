using DomainLayer.Models;
using System;
using System.Globalization;
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
            //Actualizar fecha y hora
            updateDate();

            //Instanciamos la capa de dominio
            InicioModel inicioModel = new InicioModel();

            inicioModel.GetDashboardData();

            //Asignamos los datos a la vista
            lblIngresos.Text = $"$ {inicioModel.TotalRevenue}";
            lblVentas.Text = inicioModel.TotalSales.ToString();
            lblClientes.Text = inicioModel.TotalCustomers.ToString();
            lblMesas.Text = inicioModel.TotalTables.ToString();

            //Asignamos los datos a la grafica de barras
            DataTable barTable = inicioModel.GrossRevenueList;

            int index = 0;
            foreach (DataRow row in barTable.Rows)
            {
                DateTime date = (DateTime)row["Date"];
                double revenue = Convert.ToDouble(row["Revenue"]);

                if (index < barLabels.Length) 
                {
                    barLabels[index] = date.ToString("dd MMM"); 
                }

                if(revenue > 0) barData.Add(revenue);
                else barData.Add(0);

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateDate();
        }

        private void updateDate()
        {
            CultureInfo culture = new CultureInfo("en-US");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt", culture);
            lblFecha.Text = DateTime.Now.ToString("dddd dd 'de' MMMM 'del' yyyy");
        }
    }
}
