namespace FOOD
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panelOpciones = new Bunifu.UI.WinForms.BunifuPanel();
            this.panelSalir = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnCerrarApp = new FontAwesome.Sharp.IconButton();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.pbFotoPerfil = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnOpciones = new FontAwesome.Sharp.IconButton();
            this.lblRolUsuario = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblNombreUsuario = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnCuentas = new FontAwesome.Sharp.IconButton();
            this.btnOrdenes = new FontAwesome.Sharp.IconButton();
            this.btnMesas = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            this.panelSalir.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOpciones.BackgroundImage")));
            this.panelOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOpciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.panelOpciones.BorderRadius = 0;
            this.panelOpciones.BorderThickness = 1;
            this.panelOpciones.Controls.Add(this.panelSalir);
            this.panelOpciones.Controls.Add(this.bunifuPanel3);
            this.panelOpciones.Controls.Add(this.pictureBox1);
            this.panelOpciones.Controls.Add(this.btnMenu);
            this.panelOpciones.Controls.Add(this.btnCuentas);
            this.panelOpciones.Controls.Add(this.btnOrdenes);
            this.panelOpciones.Controls.Add(this.btnMesas);
            this.panelOpciones.Controls.Add(this.btnUsuarios);
            this.panelOpciones.Controls.Add(this.btnInicio);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.ShowBorders = true;
            this.panelOpciones.Size = new System.Drawing.Size(340, 739);
            this.panelOpciones.TabIndex = 1;
            // 
            // panelSalir
            // 
            this.panelSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSalir.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSalir.BackgroundImage")));
            this.panelSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.panelSalir.BorderRadius = 6;
            this.panelSalir.BorderThickness = 1;
            this.panelSalir.Controls.Add(this.btnCerrarSesion);
            this.panelSalir.Controls.Add(this.btnCerrarApp);
            this.panelSalir.Location = new System.Drawing.Point(127, 509);
            this.panelSalir.Name = "panelSalir";
            this.panelSalir.ShowBorders = true;
            this.panelSalir.Size = new System.Drawing.Size(207, 100);
            this.panelSalir.TabIndex = 0;
            this.panelSalir.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.Tomato;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrarSesion.IconSize = 30;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 50);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10);
            this.btnCerrarSesion.Size = new System.Drawing.Size(207, 50);
            this.btnCerrarSesion.TabIndex = 13;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCerrarApp
            // 
            this.btnCerrarApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarApp.FlatAppearance.BorderSize = 0;
            this.btnCerrarApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrarApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCerrarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarApp.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.btnCerrarApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnCerrarApp.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnCerrarApp.IconColor = System.Drawing.Color.Tomato;
            this.btnCerrarApp.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrarApp.IconSize = 30;
            this.btnCerrarApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarApp.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarApp.Name = "btnCerrarApp";
            this.btnCerrarApp.Padding = new System.Windows.Forms.Padding(10);
            this.btnCerrarApp.Size = new System.Drawing.Size(207, 50);
            this.btnCerrarApp.TabIndex = 12;
            this.btnCerrarApp.Text = "Salir al escritorio";
            this.btnCerrarApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarApp.UseVisualStyleBackColor = false;
            this.btnCerrarApp.Click += new System.EventHandler(this.btnCerrarApp_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(212)))), ((int)(((byte)(219)))));
            this.bunifuPanel3.BorderRadius = 0;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.pbFotoPerfil);
            this.bunifuPanel3.Controls.Add(this.btnOpciones);
            this.bunifuPanel3.Controls.Add(this.lblRolUsuario);
            this.bunifuPanel3.Controls.Add(this.lblNombreUsuario);
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 615);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(340, 124);
            this.bunifuPanel3.TabIndex = 2;
            // 
            // pbFotoPerfil
            // 
            this.pbFotoPerfil.AllowFocused = false;
            this.pbFotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFotoPerfil.AutoSizeHeight = true;
            this.pbFotoPerfil.BorderRadius = 33;
            this.pbFotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbFotoPerfil.Image")));
            this.pbFotoPerfil.IsCircle = true;
            this.pbFotoPerfil.Location = new System.Drawing.Point(29, 29);
            this.pbFotoPerfil.Name = "pbFotoPerfil";
            this.pbFotoPerfil.Size = new System.Drawing.Size(66, 66);
            this.pbFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoPerfil.TabIndex = 14;
            this.pbFotoPerfil.TabStop = false;
            this.pbFotoPerfil.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnOpciones
            // 
            this.btnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.btnOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnOpciones.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            this.btnOpciones.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnOpciones.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnOpciones.IconSize = 27;
            this.btnOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpciones.Location = new System.Drawing.Point(283, 52);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(35, 28);
            this.btnOpciones.TabIndex = 13;
            this.btnOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpciones.UseVisualStyleBackColor = false;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AllowParentOverrides = false;
            this.lblRolUsuario.AutoEllipsis = false;
            this.lblRolUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRolUsuario.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblRolUsuario.Font = new System.Drawing.Font("Poppins Light", 11.25F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.lblRolUsuario.Location = new System.Drawing.Point(109, 64);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRolUsuario.Size = new System.Drawing.Size(103, 26);
            this.lblRolUsuario.TabIndex = 4;
            this.lblRolUsuario.Text = "Rol de usuario";
            this.lblRolUsuario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblRolUsuario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AllowParentOverrides = false;
            this.lblNombreUsuario.AutoEllipsis = false;
            this.lblNombreUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNombreUsuario.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(109, 42);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreUsuario.Size = new System.Drawing.Size(166, 28);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de ususario";
            this.lblNombreUsuario.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombreUsuario.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMenu.IconSize = 38;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 469);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(336, 59);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menú";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.BackColor = System.Drawing.Color.Transparent;
            this.btnCuentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCuentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.btnCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnCuentas.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnCuentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnCuentas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCuentas.IconSize = 38;
            this.btnCuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuentas.Location = new System.Drawing.Point(3, 404);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCuentas.Size = new System.Drawing.Size(336, 59);
            this.btnCuentas.TabIndex = 10;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentas.UseVisualStyleBackColor = false;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.btnOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnOrdenes.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnOrdenes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnOrdenes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnOrdenes.IconSize = 38;
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.Location = new System.Drawing.Point(3, 339);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnOrdenes.Size = new System.Drawing.Size(336, 59);
            this.btnOrdenes.TabIndex = 9;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnMesas
            // 
            this.btnMesas.BackColor = System.Drawing.Color.Transparent;
            this.btnMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.btnMesas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnMesas.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.btnMesas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnMesas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMesas.IconSize = 38;
            this.btnMesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMesas.Location = new System.Drawing.Point(3, 274);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMesas.Size = new System.Drawing.Size(336, 59);
            this.btnMesas.TabIndex = 8;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesas.UseVisualStyleBackColor = false;
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUsuarios.IconSize = 38;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 209);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(336, 59);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Poppins Medium", 14F);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 38;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(3, 144);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(336, 59);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseMnemonic = false;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelOpciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 739);
            this.panel1.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(340, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(791, 739);
            this.panelContenedor.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 739);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-1, -1);
            this.Name = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelOpciones.ResumeLayout(false);
            this.panelSalir.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelOpciones;
        private Bunifu.UI.WinForms.BunifuLabel lblNombreUsuario;
        private Bunifu.UI.WinForms.BunifuLabel lblRolUsuario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnMesas;
        private FontAwesome.Sharp.IconButton btnCuentas;
        private FontAwesome.Sharp.IconButton btnOrdenes;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnOpciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuPictureBox pbFotoPerfil;
        private Bunifu.UI.WinForms.BunifuPanel panelSalir;
        private FontAwesome.Sharp.IconButton btnCerrarApp;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
    }
}