using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using System.Windows.Forms;

namespace FOOD
{
    public partial class Mesas : Form
    {
        MesasModel mesasModel = new MesasModel();
        public Mesas()
        {
            InitializeComponent();
        }
        private void Mesas_Load(object sender, EventArgs e)
        {
            showTables();
        }
        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            MesasCU createTable = new MesasCU();
            createTable.lblTitulo.Text = "Agregar mesa";
            createTable.FormClosed += updateDgv;
            createTable.ShowDialog();
        }

        //Metodo para mostrar las tablas en el DGV
        private void showTables()
        {
            dgvMesas.Rows.Clear();
            DataTable dt = mesasModel.showTables();


            foreach (DataRow row in dt.Rows)
            {
                string estado = row["Estado"].ToString();
                Image pointImage = row["Estado"].ToString() == "Ocupada" ? Properties.Resources.redpoint : Properties.Resources.greenpoint;

                dgvMesas.Rows.Add(row["MesaID"], row["Capacidad"], pointImage, estado);
            }
        }

        private void dgvMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvMesas.Columns[e.ColumnIndex].Name;
            string tableID = dgvMesas.Rows[e.RowIndex].Cells["tableID"].Value.ToString();

            //Editar mesa con el ID seleccionado
            if(colName == "editar")
            {
                MesasCU updateTable = new MesasCU();

                //Se guardan y muestran los datos de la tabla que se quiere actualizar
                DataTable dt = mesasModel.getTables(tableID);
                DataRow row = dt.Rows[0];

                updateTable.lblTitulo.Text = "Editar mesa";
                updateTable.lblTableID.Text = tableID;
                updateTable.lblTableID.Visible = true;

                int tableNumber = int.Parse(row["MesaID"].ToString().Substring(1));

                updateTable.txtNumeroMesa.Text = tableNumber.ToString();
                updateTable.txtCapacidad.Text = row["Capacidad"].ToString();
                switch (row["Estado"])
                {
                    case "Disponible":
                        updateTable.cbEstado.SelectedIndex = 0;
                        break;
                    case "Ocupada":
                        updateTable.cbEstado.SelectedIndex = 1;
                        break;
                }

                updateTable.FormClosed += updateDgv;
                updateTable.ShowDialog();
            }
            //Eliminar mesa con el ID seleccionnado
            else if(colName == "eliminar")
            {
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar la mesa con ID {tableID}?", "Eliminar mesa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    mesasModel.deleteTable(tableID);
                    showTables();
                }
            }
        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar mesa
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
            showTables();
        }
    }
}
