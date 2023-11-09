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
    public partial class CuentasCU : Form
    {
        CuentasModel cuentasModel = new CuentasModel();
        public CuentasCU()
        {
            InitializeComponent();
        }

        //Importar metodos que permiten mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelCuenta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CuentasCU_Load(object sender, EventArgs e)
        {
            loadTables();
        }

        //Metodo para llenar el combobox de mesas
        private void loadTables()
        {
            DataTable tables = cuentasModel.getTablesInOrders();
            foreach (DataRow row in tables.Rows)
            {         
                 cbMesas.Items.Add(row["MesaID"]);
            }
        }

        private void cbMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string orderID;
            double subtotal, propina, total;
            const double PROPINA = 0.10;

            DataTable order = cuentasModel.getOrderByTableID(cbMesas.Text);

            if (order.Rows.Count > 0) 
            {
                DataRow row = order.Rows[0];

                
                
                orderID = row["OrdenID"].ToString();
                subtotal = cuentasModel.getSubTotal(orderID);
                propina = subtotal * PROPINA;
                total = subtotal + propina;

                txtDescuento.Enabled = true;
                lblOrdenID.Text = orderID.PadLeft(6, '0');
                lblSubtotal.Text = subtotal.ToString("F2");
                lblPropina.Text = propina.ToString("F2");
                lblTotal.Text = total.ToString("F2");

            } 
            else
            {
                MessageBox.Show($"No existen Ordenes activas para la mesa {cbMesas.Text}");

                clear();
            }

            
        }

        private void clear()
        {
            lblOrdenID.Text = "------";
            lblSubtotal.Text = "-- --";
            lblPropina.Text = "-- --";
            lblTotal.Text = "-- --";
            txtDescuento.Text = string.Empty;
            txtDescuento.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string action = lblTitulo.Text;
            string orderID, subTotal, tip, discount, total;
            DateTime date = DateTime.Now;

            orderID = lblOrdenID.Text;
            subTotal = lblSubtotal.Text;
            tip = lblPropina.Text;
            discount = txtDescuento.Text;
            total = lblTotal.Text;

            if (string.IsNullOrEmpty(txtDescuento.Text)) discount = "0";

            if(action == "Crear Cuenta")
            {
                cuentasModel.insertBill(orderID, date, subTotal, tip, discount, total);
                MessageBox.Show("Cuenta creada");
                this.Close();
            }

        }

        //Metodo para aplicar descuento
        private void txtDescuento_TextChange(object sender, EventArgs e)
        {
            double discount, subtotal, tip, total;

            subtotal = double.Parse(lblSubtotal.Text);
            tip = double.Parse(lblPropina.Text);

            if (!string.IsNullOrEmpty(txtDescuento.Text))
            {
                discount = double.Parse(txtDescuento.Text);

                total = (subtotal + tip) - discount;
                lblTotal.Text = total.ToString("F2");
            }
            else
            {
                discount = 0;

                total = (subtotal + tip) - discount;
                lblTotal.Text = total.ToString("F2");
            }
        }
    }
}
