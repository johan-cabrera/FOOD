﻿using DomainLayer.Models;
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
    public partial class Ordenes : Form
    {
        OrdenesModel ordenesModel = new OrdenesModel();
        public Ordenes()
        {
            InitializeComponent();
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {

            OrdenesCU createOrder = new OrdenesCU();
            createOrder.lblTitulo.Text = "Crear Orden";
            createOrder.txtClientes.Text = "0";
            createOrder.cbEstado.SelectedIndex = 0;
            createOrder.FormClosed += updateDgv;
            createOrder.ShowDialog();
        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar menu
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
            showOrders();
            addFilter();
        }

        //Metodo para mostrar las ordenes en el DGV
        private void showOrders()
        {
            dgvOrdenes.Rows.Clear();
            DataTable dt = ordenesModel.showOrders();

            foreach (DataRow row in dt.Rows) 
            { 
                string state = row["Estado"].ToString();
                Image pointImage;

                if (state == "En Proceso") pointImage = Properties.Resources.orangepoint;
                else if (state == "Lista") pointImage = Properties.Resources.yellowpoint;
                else if (state == "Servida") pointImage = Properties.Resources.greenpoint;
                else if (state == "Cerrada") pointImage = Properties.Resources.redpoint;
                else pointImage = Properties.Resources.greypoint;

                dgvOrdenes.Rows.Add(row["OrdenID"], row["MesaID"], pointImage, row["Estado"], row["CantidadClientes"]);
            }
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            showOrders();
            cbFiltro.SelectedIndex = 0;
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvOrdenes.Columns[e.ColumnIndex].Name;
            string orderID = dgvOrdenes.Rows[e.RowIndex].Cells["orderID"].Value.ToString();

            if(colName == "editar")
            {
                OrdenesCU updateOrder = new OrdenesCU();
                updateOrder.lblTitulo.Text = "ORDEN:";
                

                //Se guardan y se muestran los datos del registro de la orden que se quiere actualizar
                DataTable dt = ordenesModel.getOrder(orderID);
                DataRow row = dt.Rows[0];

                if(row["Estado"].ToString() == "Cerrada")
                {
                    updateOrder.btnAgregarDetalleOrden.Enabled = false;
                    updateOrder.txtPlatillo.Enabled = false;
                    updateOrder.txtCantidad.Enabled = false;
                    updateOrder.txtComentarios.Enabled = false;

                    updateOrder.cbMesas.Enabled = false;
                    updateOrder.cbEstado.Enabled = false;
                    updateOrder.cbEstado.Text = "Cerrada";
                    updateOrder.txtClientes.Enabled = false;
                }
                updateOrder.lblOrdenID.Text = orderID.PadLeft(6, '0');
                updateOrder.lblOrdenID.Visible = true;

                updateOrder.cbMesas.Items.Add(row["MesaID"]);

                switch (row["Estado"])
                {
                    case "En Proceso":
                        updateOrder.cbEstado.SelectedIndex = 0;
                        break;
                    case "Lista":
                        updateOrder.cbEstado.SelectedIndex = 1;
                        break;
                    case "Servida":
                        updateOrder.cbEstado.SelectedIndex = 2;
                        break;
                    case "Cancelada":
                        updateOrder.cbEstado.SelectedIndex = 3;
                        break;
                }
                
                updateOrder.lblMesaID.Text = row["MesaID"].ToString();
                updateOrder.txtClientes.Text = row["CantidadClientes"].ToString();

                updateOrder.FormClosed += updateDgv;
                updateOrder.ShowDialog();
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            addFilter();
        }


        private void txtFiltro_TextChange(object sender, EventArgs e)
        {
            string filter = txtFiltro.Text;
            dgvOrdenes.SuspendLayout();

            foreach (DataGridViewRow row in dgvOrdenes.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (!string.IsNullOrEmpty(filter))
                {
                    //Verificar si alguna celda contiene el filtro
                    bool filterExist = false;

                    if (row.Cells["orderID"].Value.ToString() == filter)
                    {
                        filterExist = true;
                    }

                    //Si no exite ninguna coincidencia con el filtro, la fila se oculta
                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvOrdenes.ResumeLayout();
        }

        private void addFilter()
        {
            string filter = cbFiltro.Text;
            dgvOrdenes.SuspendLayout();

            foreach (DataGridViewRow row in dgvOrdenes.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (filter != "Todos")
                {
                    //verificar si la celda Estado contiene el filtro
                    bool filterExist = false;
                    string cellValue = row.Cells["Estado"].Value.ToString();
                    if (cellValue == filter)
                    {
                        filterExist = true;
                    }
                    else if (filter == "Activas" && (cellValue == "En Proceso" || cellValue == "Lista" || cellValue == "Servida"))
                    {
                        filterExist = true;
                    }

                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvOrdenes.ResumeLayout();
        }
    }
}
