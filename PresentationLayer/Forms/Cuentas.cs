using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace FOOD
{
    public partial class Cuentas : Form
    {
        CuentasModel cuentasModel = new CuentasModel();
        OrdenesModel ordenesModel = new OrdenesModel();
        DataTable receipt;
        DataTable bill;
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
            string orderID = dgvCuentas.Rows[e.RowIndex].Cells["order"].Value.ToString();
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
                if(state == "Cancelado" || state == "Descartada")
                {
                    MessageBox.Show("Solo se pueden cancelar cuentas pendientes");
                    return;
                }
                CuentasP payBill = new CuentasP();
                payBill.lblBillID.Text = billID.PadLeft(6, '0');
                payBill.lblBillID.Visible = true;
                payBill.lblTotal.Text = $"{amount}";
                payBill.lblOrdenID.Text = orderID;
                payBill.FormClosed += updateDgv;
                payBill.ShowDialog();
            }

            else if(colName == "imprimir")
            {


                receipt = cuentasModel.receiptBill(orderID);
                bill = cuentasModel.getBill(billID);

                

                pdRecibo.Print();
                ppdRecibo.Document = pdRecibo;
                ppdRecibo.ShowDialog();
            }

            else if(colName == "descartar")
            {
                DialogResult result = MessageBox.Show($"¿Esta seguro de que desea descartar la cuenta {billID}?", "Descartar cuenta", MessageBoxButtons.OKCancel);
                if(result == DialogResult.OK)
                {
                    cuentasModel.updateBill(billID, orderID, "Descartada");
                    showBills();
                }
                
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

        private void pdRecibo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataRow billRow = bill.Rows[0];

            string billID = billRow[0].ToString().PadLeft(6, '0');
            string date = Convert.ToDateTime(billRow[2]).ToString("dd/MM/yyyy");
            string subtotal = $"${billRow[3]}".PadLeft(6);
            string tip = $"${billRow[4]}".PadLeft(6);
            string discount = $"${billRow[5]}".PadLeft(6);
            string total = $"${billRow[6]}".PadLeft(6);

            string receiptString;

            receiptString =   "  Food Orders Optimizer Dispatcher\n";
            receiptString +=  "        18 79, HIGH HOUSE RD\n";
            receiptString +=  "        NEW HILL, NC, 27513\n";
            receiptString +=  "         (503) 6192 - 1660\n\n";
            receiptString += $"ORDEN: {billID}".PadRight(26) + $"{date}";

            Font font = new Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point);

            e.Graphics.DrawString(receiptString, font, Brushes.Black, 10, 50);

            int x = 10;
            int y = 160;
            foreach (DataRow row in receipt.Rows)
            {
                string cantidad = row[1].ToString().Substring(0, Math.Min(row[1].ToString().Length, 5)).PadRight(2);
                string producto = row[0].ToString().Substring(0, Math.Min(row[0].ToString().Length, 20)).ToUpper();
                string precio = $"${row[2]}".PadLeft(6);

                string filaRecibo = $"{cantidad}{producto}\n";

                e.Graphics.DrawString(filaRecibo, font, Brushes.Black, x, y);
                e.Graphics.DrawString(precio, font, Brushes.Black, x + 260, y);

                y += 20;
            }

            e.Graphics.DrawString("SUBTOTAL:", font, Brushes.Black, x, y += 20);
            e.Graphics.DrawString(subtotal, font, Brushes.Black, x + 260, y);

            e.Graphics.DrawString("PROPINA:", font, Brushes.Black, x, y += 20);
            e.Graphics.DrawString(tip, font, Brushes.Black, x + 260, y);

            e.Graphics.DrawString("DESCUENTO:", font, Brushes.Black, x, y += 20);
            e.Graphics.DrawString(discount, font, Brushes.Black, x + 260, y);

            e.Graphics.DrawString("TOTAL:", font, Brushes.Black, x, y += 20);
            e.Graphics.DrawString(total, font, Brushes.Black, x + 260, y);

            pdRecibo.DefaultPageSettings.PaperSize = new PaperSize("Customsize", 350, y += 40);
        }
    }
}
