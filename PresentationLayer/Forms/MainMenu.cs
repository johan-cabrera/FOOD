using Bunifu.UI.WinForms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonUtility.Cache;
using System.IO;

namespace FOOD
{
    public partial class MainMenu : Form
    {
        private IconButton currentBtn;
        private BunifuPanel rightBorderBtn;
        private Form currentForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            //Cargar nombre
            string[] names = AttributesUser.Name.Split(' ');
            string[] lastnames = AttributesUser.LastName.Split(' ');
            string fullName = $"{names[0]} {lastnames[0]}";

            lblNombreUsuario.Text = fullName;

            //Cargar rol
            string rol = AttributesUser.Rol;
            lblRolUsuario.Text = rol;

            //Cargar imagen
            using(MemoryStream memoryStream = new MemoryStream(AttributesUser.Image))
            {
                Image image = Image.FromStream(memoryStream);
                pbFotoPerfil.Image = image;
            }
        }

        //Dar formato visual al momento de seleccionar una opcion
        private void activateBtn(object sender)
        {
            deactivateBtn();
            if(sender != null) 
            {
                Color color = Color.FromArgb(15, 23, 42);

                //Boton
                currentBtn = (IconButton)sender;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                //Borde derecho
                rightBorderBtn.BackColor = color;
                rightBorderBtn.Location = new Point(334, currentBtn.Location.Y);
                rightBorderBtn.Visible = true;
                rightBorderBtn.BringToFront();
            }
        }

        private void deactivateBtn()
        {
            if (currentBtn != null)
            {
                Color color = Color.FromArgb(156, 161, 171);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

            }
        }

        //Abrir los formularios hijos
        private void openChildForm(Form childForm)
        {
            if (currentForm != null) currentForm.Close();

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Dar formato por defecto
            this.WindowState = FormWindowState.Maximized;

            rightBorderBtn = new BunifuPanel();
            rightBorderBtn.BorderRadius = 20;
            rightBorderBtn.Size = new Size(5, 59);
            panelOpciones.Controls.Add(rightBorderBtn);

            activateBtn(btnInicio);
            openChildForm(new Inicio());
            loadData();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Inicio());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if(AttributesUser.Rol == "Mesero")
            {
                MessageBox.Show("Solo administradores pueden acceder a la gestion de usuarios.");
                return;
            }
            activateBtn(sender);
            openChildForm(new Usuarios());
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Mesas());
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Ordenes());
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Cuentas());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
            openChildForm(new Menu());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            activateBtn(sender);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            if(panelSalir.Visible == true) panelSalir.Visible = false;
            else panelSalir.Visible = true;
        }
    }
}
