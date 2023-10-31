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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Importar metodos que permiten mover el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Evento para mover el formulario
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Evento para cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserID.Text;
            string password = txtPassword.Text;

            if (!String.IsNullOrWhiteSpace(user) && !String.IsNullOrEmpty(user))
            {
                if(!String.IsNullOrWhiteSpace(password) && !String.IsNullOrEmpty(password))
                {
                    //Instanciamos la capa de dominio
                    LoginUserModel userModel = new LoginUserModel();

                    bool validateLogin = userModel.Login(user, password);

                    //Validamos el inicio de sesion
                    if (validateLogin)
                    {                        

                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        mainMenu.FormClosed += logOut;

                        this.Hide();

                    }
                    else showError("Usuario o Contraseña incorrectos.");
                }
                else showError("por favor, ingrese su contraseña.");
            }
            else showError("por favor, ingrese su usuario.");           
            
        }

        private void showError(string message)
        {
            lblError.Text = "     " + message;
            lblError.Visible = true;
        }

        private void logOut(object sender, FormClosedEventArgs e)
        {
            txtUserID.Clear();
            txtPassword.Clear();
            lblError.Visible = false;
            this.Show();
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtPassword.Text)) txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }
    }
}
