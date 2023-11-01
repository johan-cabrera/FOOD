using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOOD
{
    public partial class OrdenesCU : Form
    {
        MesasModel mesasModel = new MesasModel();
        MenuModel menuModel = new MenuModel();
        DetalleOrdenModel detalleOrdenModel = new DetalleOrdenModel();
        OrdenesModel ordenesModel = new OrdenesModel();


        public OrdenesCU()
        {
            InitializeComponent();
        }

        //Importar metodos que permiten mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string action = lblTitulo.Text;
            string orderID, tableID, state, quantity;
            bool actionSuccess;

            orderID = lblOrdenID.Text;
            tableID = cbMesas.Text;
            state = cbEstado.Text;
            quantity = txtClientes.Text;


            if(action == "Crear Orden")
            {
                orderID = ordenesModel.inserOrder(tableID, state, quantity).ToString();
                MessageBox.Show("Orden Creada");
                lblTitulo.Text = "ORDEN:";
                lblOrdenID.Text = orderID;
                lblOrdenID.Visible = true;
                
            }
            else if(action == "ORDEN:")
            {
                actionSuccess = ordenesModel.updateOrders(orderID, tableID, state, quantity);

                if (actionSuccess)
                {
                    MessageBox.Show("Orden Actualizada");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar orden");
                }
            }

            
        }

        private void OrdenesCU_Load(object sender, EventArgs e)
        {
            loadTables();
            loadDishes();
            showOrderDetails();
            clearTxt();
        }

        //Metodo para llenar los combobox de mesas
        private void loadTables()
        {
            List<string> tables = ordenesModel.getTablesInOrders();
            DataTable allTables = mesasModel.showTables();

            foreach (DataRow row in allTables.Rows)
            {
                if ((!tables.Contains(row["MesaID"]) && row["Estado"].ToString() != "Inactiva"))
                {
                    cbMesas.Items.Add(row["MesaID"]);
                }                
            }
            for (int i = 0; i < cbMesas.Items.Count; i++)
            {
                if (cbMesas.Items[i].ToString() == lblMesaID.Text)
                {
                    cbMesas.SelectedIndex = i;
                    break;
                }
            }
        }

        //Metodo para llenar el auto complete de los platillos
        private void loadDishes()
        {
            AutoCompleteStringCollection dishes = new AutoCompleteStringCollection();
            DataTable dt = menuModel.showMenu();

            foreach (DataRow row in dt.Rows)
            {
                if (row["Estado"].ToString() == "Activo")
                {
                    dishes.Add(row["NombrePlatillo"].ToString());
                }                
            }

            txtPlatillo.AutoCompleteCustomSource = dishes;
        }

        private void panelDetalleOrden_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelOrden_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodo para mostrar los detalles de las ordenes en el DGV
        private void showOrderDetails()
        {
            string currentID = lblOrdenID.Text;
            dgvDetalleOrden.Rows.Clear();

            DataTable dt = detalleOrdenModel.showOrderDetails(currentID);

            foreach (DataRow row in dt.Rows)
            {
                dgvDetalleOrden.Rows.Add(row["DetalleOrdenID"],row["NombrePlatillo"], row["Cantidad"], row["Comentarios"]);
            }
        }

        private void btnAgregarDetalleOrden_Click(object sender, EventArgs e)
        {
            string orderID, dishName, quantity, comment;
            bool actionsuccess;

            if(txtPlatillo.Enabled == true)
            {
                orderID = lblOrdenID.Text;
                dishName = txtPlatillo.Text;
                quantity = txtCantidad.Text;
                comment = txtComentarios.Text;

                actionsuccess = detalleOrdenModel.insertOrderDetail(orderID, dishName, quantity, comment);

                if (actionsuccess)
                {
                    MessageBox.Show("El Detalle fue agregado");
                    showOrderDetails();
                    clearTxt();
                }
                else
                {
                    MessageBox.Show("Error al agregar el detalle");
                }
            }
            else
            {
                txtPlatillo.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtComentarios.Text = string.Empty;

                txtPlatillo.Enabled = true;
                txtCantidad.Enabled = true;
                txtComentarios.Enabled = true;
            }
            


        }

        //Metodo para limpiar los textbox
        private void clearTxt()
        {
            txtPlatillo.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtComentarios.Text = string.Empty;
        }

        private void dgvDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || cbEstado.Text == "Cerrada") return;

            string colName = dgvDetalleOrden.Columns[e.ColumnIndex].Name;
            string dishID = dgvDetalleOrden.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string dishName = dgvDetalleOrden.Rows[e.RowIndex].Cells["dish"].Value.ToString();
            string quantity = dgvDetalleOrden.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            string comment = dgvDetalleOrden.Rows[e.RowIndex].Cells["comment"].Value.ToString();


            //Seleccionar valores de la fila seleccionada
            if (colName == "ver")
            {
                txtPlatillo.Text = dishName;
                txtCantidad.Text = quantity;
                txtComentarios.Text = comment;

                txtPlatillo.Enabled = false;
                txtCantidad.Enabled = false;
                txtComentarios.Enabled = false;
            }
            else if(colName == "eliminar")
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    detalleOrdenModel.deleteOrderDetail(dishID);
                    showOrderDetails();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
