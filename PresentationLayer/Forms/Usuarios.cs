using Bunifu.UI.WinForms;
using CommonUtility.Cache;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOOD
{
    public partial class Usuarios : Form
    {
        UsuariosModel usuarios = new UsuariosModel();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            scrollbar1.BindTo(dgvUsuarios, false);
            showUsers();
        }

        //Metodo para mostrar los usuarios en el DGV
        private void showUsers()
        {
            
            dgvUsuarios.Rows.Clear();
            DataTable dt = usuarios.showUsers();

            foreach (DataRow row in dt.Rows)
            {  
                dgvUsuarios.Rows.Add(row["UsuarioID"], $"{row["Nombres"]} {row["Apellidos"]}" , row["Rol"], row["Telefono"], row["Correo"]);
            }
        }

        //Evento para actualizar/eliminar un usuario
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            string colName = dgvUsuarios.Columns[e.ColumnIndex].Name;
            string userID = dgvUsuarios.Rows[e.RowIndex].Cells["UserID"].Value.ToString();

            //Editar usuario con el ID seleccionado
            if(colName == "editar")
            {
                UsuariosCU updateUser = new UsuariosCU();

                //Se guardan y muestran los datos del usuario que se quiere editar
                DataTable dt = usuarios.getUsers(userID);
                DataRow row = dt.Rows[0];

                updateUser.lblTitulo.Text = "Editar usuario";
                updateUser.lblUserID.Text = userID;
                updateUser.lblUserID.Visible = true;

                MemoryStream memoryStream = new MemoryStream((Byte[])row["Imagen"]);
                Image image = Image.FromStream(memoryStream);
                updateUser.pbPerfil.Image = image;

                updateUser.txtNombres.Text = row["Nombres"].ToString();
                updateUser.txtApellidos.Text = row["Apellidos"].ToString();

                switch (row["Rol"].ToString())
                {
                    case "Administrador":
                        updateUser.cbRoles.SelectedIndex = 0;
                        break;

                    case "Mesero":
                        updateUser.cbRoles.SelectedIndex = 1;
                        break;
                }

                updateUser.dpFechaNacimiento.Value = Convert.ToDateTime(row["FechaNacimiento"]);
                updateUser.txtTelefono.Text = row["Telefono"].ToString();
                updateUser.txtCorreo.Text = row["Correo"].ToString();
                updateUser.txtContraseña.Text = row["Contraseña"].ToString();
                updateUser.txtConfirmarContraseña.Text = row["Contraseña"].ToString();

                updateUser.FormClosed += updateDgv;
                updateUser.ShowDialog(); 

                memoryStream.Dispose();
            }
            //Se elimina el usuario con el ID seleccionado
            else if(colName == "eliminar")
            {
                DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el usuario con ID {userID}?", "Eliminar usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if(result == DialogResult.OK)
                {
                    usuarios.deleteUser(userID);
                    showUsers();
                }                
            }
        }

        //Evento para abrir agregar un nuevo usuario
        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosCU createUser = new UsuariosCU();
            createUser.lblTitulo.Text = "Crear usuario";
            createUser.FormClosed += updateDgv;
            createUser.ShowDialog();
            
        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar usuario
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
            showUsers();
        }

        //Evento para filtrar los usuarios del DGV
        private void txtFiltrar_TextChange(object sender, EventArgs e)
        {
            string filter = txtFiltrar.Text;
            dgvUsuarios.SuspendLayout();

            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (!string.IsNullOrEmpty(filter))
                {
                    //Verificar si alguna celda contiene el filtro
                    bool filterExist = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            filterExist = true;
                            break;
                        }
                    }

                    //Si no exite ninguna coincidencia con el filtro, la fila se oculta
                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvUsuarios.ResumeLayout();
        }
    }

}
