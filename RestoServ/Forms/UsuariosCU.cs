using Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOOD
{
    public partial class UsuariosCU : Form
    {
        UsuariosModel usuarios = new UsuariosModel();
        public UsuariosCU()
        {
            InitializeComponent();
        }

        //Importar metodos que permiten mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Evento para mover el formulario
        private void panelUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Evento para cerrar el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para agregar/Actualizar usuario
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string action = lblTitulo.Text;
            string userId, name, lastname, email, phone, rol, pass, confirmpass, birthdate;
            Image image;
            byte[] bytesImage;

            image = pbPerfil.Image;

            using (MemoryStream memoryStream = new MemoryStream())
            { 
                image.Save(memoryStream, ImageFormat.Jpeg);
                bytesImage = memoryStream.ToArray();
            }

            userId = lblUserID.Text;
            name = txtNombres.Text;
            lastname = txtApellidos.Text;
            email = txtCorreo.Text;
            phone = txtTelefono.Text;
            rol = cbRoles.Text;
            pass = txtContraseña.Text;
            confirmpass = txtConfirmarContraseña.Text;
            birthdate = dpFechaNacimiento.Text;

            if(confirmpass == pass)
            {
                if(action == "Crear usuario")
                {
                    usuarios.insertUser(name, lastname, email, phone, rol, pass, birthdate, bytesImage);
                    
                }
                else if(action == "Editar usuario")
                {
                    usuarios.updateUser(userId, name, lastname, email, phone, rol, pass, birthdate, bytesImage);
                }
                this.Close();
            }
            else
            {
                ShowError("¡Ups! Parece que las contraseñas no coinciden. Intenta nuevamente.");
            }  
        }

        private void btnSeleccionarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "archivos de imágenes(*.png; *.jpg;)| *.png; *.jpg;";

            if (image.ShowDialog() == DialogResult.OK)
            {
                pbPerfil.Image = Image.FromFile(image.FileName);
            }
        }

        private void ShowError(string message)
        {
            lblError.Visible = true;
            lblError.Text = "     " + message;
        }

        private void txtContraseña_TextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtContraseña.Text)) txtContraseña.UseSystemPasswordChar = false;
            else txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtConfirmarContraseña_TextChange(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConfirmarContraseña.Text)) txtConfirmarContraseña.UseSystemPasswordChar = false;
            else txtConfirmarContraseña.UseSystemPasswordChar = true;
        }
    }
}

