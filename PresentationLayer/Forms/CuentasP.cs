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
    public partial class CuentasP : Form
    {
        CuentasModel cuentasModel = new CuentasModel();
        public CuentasP()
        {
            InitializeComponent();
        }

        //Importar metodos que permiten mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelPago_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rbTarjeta_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if(rbTarjeta.Checked)
            {
                panelTarjeta.Visible = true;
            }
            else{
                panelTarjeta.Visible = false;
            }
        }

        private void panelTarjeta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNumeroTarjeta_TextChange(object sender, EventArgs e)
        {
            string text = txtNumeroTarjeta.Text.Replace(" ", "");

            string formattedText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0 && i % 4 == 0)
                {
                    formattedText += " ";
                }
                formattedText += text[i];
            }

            // Establecer el texto formateado en el TextBox
            if (txtNumeroTarjeta.Text.Length > 19) 
            {
                txtNumeroTarjeta.Text = formattedText.Substring(0, 19);
                txtNumeroTarjeta.SelectionStart = 19;
            }
            else
            {
                txtNumeroTarjeta.Text = formattedText;
                txtNumeroTarjeta.SelectionStart = txtNumeroTarjeta.Text.Length;
            }            

            lblNumeroTarjeta.Text = txtNumeroTarjeta.Text;
        }

        private void txtVencimiento_TextChange(object sender, EventArgs e)
        {
            string inputText = txtVencimiento.Text;

            // Eliminar caracteres no numéricos (por ejemplo, barras diagonales)
            string cleanText = new string(inputText.Where(char.IsDigit).ToArray());

            if (cleanText.Length > 2)
            {
                // Formatear la fecha agregando una barra diagonal
                string formattedText = cleanText.Insert(2, "/");
                txtVencimiento.Text = formattedText;
                txtVencimiento.SelectionStart = formattedText.Length;
            }

            // Asegurarse de que el usuario solo pueda ingresar hasta 4 dígitos
            if (cleanText.Length > 4)
            {
                txtVencimiento.Text = cleanText.Substring(0, 4);
                txtVencimiento.SelectionStart = 4;
            }

            lblVencimiento.Text = txtVencimiento.Text;
        }

        private void txtNombreTarjeta_TextChange(object sender, EventArgs e)
        {
            lblNombreTarjeta.Text = txtNombreTarjeta.Text;
        }

        private void rbEfectivo_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                panelEfectivo.Visible = true;
            }
            else
            {
                panelEfectivo.Visible = false;
            }
        }

        private void txtPago_TextChange(object sender, EventArgs e)
        {
            double total, pago, cambio;

            total = double.Parse(lblTotal.Text.Substring(1));
            if (string.IsNullOrEmpty(txtPago.Text)) pago = 0;
            else pago = double.Parse(txtPago.Text);


            cambio = pago - total;

            if (cambio > 0)
            {
                lblCambio.Text ="$ " + cambio.ToString("F2");
            }
            else
            {
                lblCambio.Text = "La cantidad ingresada es menor al total"; 
            }
            
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(panelTarjeta.Visible && !string.IsNullOrEmpty(txtNumeroTarjeta.Text)) 
            {
                cuentasModel.updateBill(lblBillID.Text, lblOrdenID.Text, "Cancelado");
                MessageBox.Show("Cuenta cancelada");
                this.Close();
            }
            else if (panelEfectivo.Visible && !string.IsNullOrEmpty(txtPago.Text))
            {
                cuentasModel.updateBill(lblBillID.Text, lblOrdenID.Text, "Cancelado");
                MessageBox.Show("Cuenta cancelada");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un metodo de pago");
            }
        }
    }
}
