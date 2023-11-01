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
    public partial class MenuCU : Form
    {
        MenuModel menuModel = new MenuModel();
        public MenuCU()
        {
            InitializeComponent();
        }

        //Importar metodos que permiten mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para agregar/editar registros del menu
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string action = lblTitulo.Text;
            string name, description, state, price, id;
            bool actionsuccess;

            id = lblPlatilloID.Text;
            name = txtNombre.Text;
            description = txtDescripcion.Text;
            price = txtPrecio.Text;

            if (tsActive.Checked) state = "Activo";
            else state = "Inactivo";

            if(action == "Agregar platillo")
            {
                actionsuccess = menuModel.insertMenu(name, description, state, price);

                if (actionsuccess)
                {
                    MessageBox.Show("El Platillo fue agregado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al ingresar el platillo");
                }
            }
            else if(action == "Editar platillo")
            {
                actionsuccess = menuModel.updateMenu(id, name, description, state, price);
                if (actionsuccess)
                {
                    MessageBox.Show("El platillo fue actualizado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el platillo");
                }
            }

        }
    }
}
