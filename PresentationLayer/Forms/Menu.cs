using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainLayer.Models;

namespace FOOD
{
    public partial class Menu : Form
    {
        MenuModel menuModel = new MenuModel();
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAgregarPlatillo_Click(object sender, EventArgs e)
        {
            MenuCU createMenu = new MenuCU();
            createMenu.lblTitulo.Text = "Agregar platillo";
            createMenu.FormClosed += updateDgv;
            createMenu.ShowDialog();
        }

        //Metodo para mostrar el menu en el DGV
        private void showMenu()
        {
            dgvMenu.Rows.Clear();
            DataTable dt = menuModel.showMenu();

            foreach (DataRow row in dt.Rows) 
            {
                string state = row["Estado"].ToString();
                Image pointImage;

                if (state == "Activo") pointImage = Properties.Resources.greenpoint;
                else pointImage = Properties.Resources.greypoint;

                dgvMenu.Rows.Add(row["PlatilloID"], row["NombrePlatillo"], $"$ {row["Precio"]}", pointImage, state);
            }
        }

        //Metodo para actualizar el DGV cuando se cierre la ventana de crear/actualizar menu
        private void updateDgv(object sender, FormClosedEventArgs e)
        {
            showMenu();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            showMenu();
            cbFiltro.SelectedIndex = 0;
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvMenu.Columns[e.ColumnIndex].Name;
            string dishID = dgvMenu.Rows[e.RowIndex].Cells["dishID"].Value.ToString();

            //Editar platillo con el ID seleccionado
            if(colName == "editar")
            {
                MenuCU updateMenu = new MenuCU();

                //Se guardan y muestran los datos del registro del menu que se quiere actualizar
                DataTable dt = menuModel.getMenu(dishID, "");
                DataRow row = dt.Rows[0];

                updateMenu.lblTitulo.Text = "Editar platillo";
                updateMenu.lblPlatilloID.Text = dishID.PadLeft(6, '0');
                updateMenu.lblPlatilloID.Visible = true;

                updateMenu.txtNombre.Text = row["NombrePlatillo"].ToString();
                updateMenu.txtDescripcion.Text = row["DescripcionPlatillo"].ToString();
                updateMenu.txtPrecio.Text = row["Precio"].ToString();

                switch (row["Estado"])
                {
                    case "Activo":
                        updateMenu.tsActive.Checked = true;
                        break;
                    case "Inactivo":
                        updateMenu.tsActive.Checked = false;
                        break;
                }

                updateMenu.FormClosed += updateDgv;
                updateMenu.ShowDialog();
            }
        }

        private void txtFiltrar_TextChange(object sender, EventArgs e)
        {
            string filter = txtFiltrar.Text;
            dgvMenu.SuspendLayout();

            foreach (DataGridViewRow row in dgvMenu.Rows)
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

            dgvMenu.ResumeLayout();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cbFiltro.Text;

            dgvMenu.SuspendLayout();

            foreach (DataGridViewRow row in dgvMenu.Rows)
            {
                //Restablecer la visibilidad de todas las filas
                row.Visible = true;

                if (filter != "Todos")
                {
                    //verificar si la celda Estado contiene el filtro
                    bool filterExist = false;

                    if (row.Cells["Estado"].Value.ToString() == filter)
                    {
                        filterExist = true;
                    }

                    if (!filterExist)
                    {
                        row.Visible = false;
                    }
                }
            }

            dgvMenu.ResumeLayout();
        }
    }
}
