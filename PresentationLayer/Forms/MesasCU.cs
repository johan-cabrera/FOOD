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
    public partial class MesasCU : Form
    {
        MesasModel mesas = new MesasModel();
        public MesasCU()
        {
            InitializeComponent();
            cbEstado.SelectedIndex = 0;
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

        //Evento para mover el formulario
        private void panelMesas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Evento para agregar/Editar una mesa
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string action = lblTitulo.Text;
            string capacity, state, currentId;
            int tableNumber;
            bool validate, actionSuccess;

            currentId = lblTableID.Text;
            validate = int.TryParse(txtNumeroMesa.Text, out tableNumber);
            capacity = txtCapacidad.Text;
            state = cbEstado.Text;

            if (validate && tableNumber > 0)
            {
                if(action == "Agregar mesa")
                {
                    actionSuccess = mesas.insertTable(tableNumber, capacity, state);
                    if (actionSuccess)
                    {
                        MessageBox.Show("La mesa fue agregada");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, la mesa ya existe");
                    }
                }

                else if(action == "Editar mesa")
                {
                    actionSuccess = mesas.updateTable(currentId, tableNumber, capacity, state);
                    if (actionSuccess)
                    {
                        MessageBox.Show("La mesa fue actualizada");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, la mesa ya existe");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("El Numero de mesa debe ser un entero positivo");
            }

        }
    }
}
