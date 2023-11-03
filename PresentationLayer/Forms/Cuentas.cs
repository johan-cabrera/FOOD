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
    public partial class Cuentas : Form
    {
        CuentasModel cuentasModel = new CuentasModel();
        OrdenesModel ordenesModel = new OrdenesModel();
        public Cuentas()
        {
            InitializeComponent();
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            CuentasCU createBill = new CuentasCU();

            createBill.lblTitulo.Text = "Crear Cuenta";
            createBill.FormClosed += updateDgv;
            createBill.ShowDialog();

        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar menu
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
            showBills();
            addFilter();
        }

        //Metodo que muestra las cuentas en el DGV
        private void showBills()
        {
            dgvCuentas.Rows.Clear();
            DataTable dt = cuentasModel.showBill();

            foreach (DataRow row in dt.Rows)
            {
                string state = row["EstadoPago"].ToString();
                Image pointImage;
                DateTime fechaCierre = (DateTime)row["FechaCierre"];

                if (state == "Pendiente") pointImage = Properties.Resources.yellowpoint;
                else if (state == "Cancelado") pointImage = Properties.Resources.greenpoint;
                else pointImage = Properties.Resources.greypoint;

                dgvCuentas.Rows.Add(row["CuentaID"], row["OrdenID"], pointImage, state,$"$ {row["Total"]}", fechaCierre.ToString("dd-MM-yyyy"));
            }
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            showBills();
            cbFiltro.SelectedIndex = 0;
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            string colName = dgvCuentas.Columns[e.ColumnIndex].Name;
            string billID = dgvCuentas.Rows[e.RowIndex].Cells["billID"].Value.ToString();
            string amount = dgvCuentas.Rows[e.RowIndex].Cells["total"].Value.ToString();
            string state = dgvCuentas.Rows[e.RowIndex].Cells["Estado"].Value.ToString();

            if (colName == "ver")
            {
                CuentasCU viewBill = new CuentasCU();

                viewBill.lblTitulo.Text = "Ver Cuenta";
                viewBill.lblBillID.Text = billID.PadLeft(6, '0');
                viewBill.lblBillID.Visible = true;

                DataTable bill = cuentasModel.getBill(billID);
                DataRow row = bill.Rows[0];

                DataTable order = ordenesModel.getOrder(row["OrdenID"].ToString());
                string table = order.Rows[0]["MesaID"].ToString();

                viewBill.cbMesas.Text = table;
                viewBill.cbMesas.Enabled = false;


                viewBill.lblOrdenID.Text = row["OrdenID"].ToString().PadLeft(6, '0');
                viewBill.lblSubtotal.Text = row["SubTotal"].ToString();
                viewBill.lblPropina.Text = row["Propinas"].ToString();

                viewBill.txtDescuento.Text = row["Descuentos"].ToString();
                viewBill.txtDescuento.Enabled = false;

                viewBill.lblTotal.Text = row["Total"].ToString();

                viewBill.btnAceptar.Enabled = false;

                viewBill.ShowDialog();
            }

            else if(colName == "pagar")
            {
                if(state == "Cancelado")
                {
                    MessageBox.Show("La cuenta ya fue cancelada");
                    return;
                }
                CuentasP payBill = new CuentasP();
                payBill.lblBillID.Text = billID.PadLeft(6, '0');
                payBill.lblBillID.Visible = true;
                payBill.lblTotal.Text = $"{amount}";
                payBill.FormClosed += updateDgv;
                payBill.ShowDialog();
            }
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            addFilter();
        }

        private void addFilter()
        {
            string filter = cbFiltro.Text;
            dgvCuentas.SuspendLayout();

            foreach (DataGridViewRow row in dgvCuentas.Rows)
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
                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvCuentas.ResumeLayout();
        }

        private void txtFiltro_TextChange(object sender, EventArgs e)
        {
            string filter = txtFiltro.Text;
            dgvCuentas.SuspendLayout();

            foreach (DataGridViewRow row in dgvCuentas.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (!string.IsNullOrEmpty(filter))
                {
                    //Verificar si alguna celda contiene el filtro
                    bool filterExist = false;

                    if (row.Cells["billID"].Value.ToString() == filter)
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

            dgvCuentas.ResumeLayout();
        }
    }
}
