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
    public partial class Mesas : Form
    {
        public Mesas()
        {
            InitializeComponent();
            dgvMesas.Rows.Add("Mesa 1", 4, Properties.Resources.greenpoint, "Disponible");
            dgvMesas.Rows.Add("Mesa 2", 6, Properties.Resources.redpoint, "Ocupada");
            dgvMesas.Rows.Add("Mesa 3", 2, Properties.Resources.redpoint, "Ocupada");
            dgvMesas.Rows.Add("Mesa 4", 8, Properties.Resources.greenpoint, "Disponible");
            dgvMesas.Rows.Add("Mesa 5", 5, Properties.Resources.redpoint, "Ocupada");
        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            MesasCU createTable = new MesasCU();
            createTable.lblTitulo.Text = "Agregar mesa";
            createTable.FormClosed += updateDgv;
            createTable.ShowDialog();
        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar mesa
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
        }
    }
}
