namespace FOOD
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvMenu = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dishID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregarPlatillo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtFiltrar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cbFiltro = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.Font = new System.Drawing.Font("Poppins Medium", 21.75F);
            this.bunifuLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.bunifuLabel10.Location = new System.Drawing.Point(30, 46);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(254, 51);
            this.bunifuLabel10.TabIndex = 23;
            this.bunifuLabel10.Text = "Gestión de menú";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowCustomTheming = true;
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeColumns = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.ColumnHeadersHeight = 55;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishID,
            this.name,
            this.price,
            this.EstadoImg,
            this.Estado,
            this.editar});
            this.dgvMenu.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenu.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvMenu.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvMenu.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvMenu.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvMenu.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.dgvMenu.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMenu.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.CurrentTheme.Name = null;
            this.dgvMenu.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMenu.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvMenu.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMenu.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.GridColor = System.Drawing.Color.White;
            this.dgvMenu.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMenu.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvMenu.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMenu.Location = new System.Drawing.Point(40, 268);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowTemplate.Height = 60;
            this.dgvMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(1018, 382);
            this.dgvMenu.TabIndex = 24;
            this.dgvMenu.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // dishID
            // 
            this.dishID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dishID.FillWeight = 130.779F;
            this.dishID.Frozen = true;
            this.dishID.HeaderText = "ID";
            this.dishID.Name = "dishID";
            this.dishID.ReadOnly = true;
            this.dishID.Width = 150;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.FillWeight = 123.0994F;
            this.name.Frozen = true;
            this.name.HeaderText = "Platillo";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 200;
            // 
            // EstadoImg
            // 
            this.EstadoImg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EstadoImg.HeaderText = "";
            this.EstadoImg.Name = "EstadoImg";
            this.EstadoImg.ReadOnly = true;
            this.EstadoImg.Width = 50;
            // 
            // Estado
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.FillWeight = 67.70091F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.editar.DefaultCellStyle = dataGridViewCellStyle4;
            this.editar.FillWeight = 60.9137F;
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.MinimumWidth = 30;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 30;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn1.FillWeight = 60.9137F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAgregarPlatillo
            // 
            this.btnAgregarPlatillo.AllowAnimations = true;
            this.btnAgregarPlatillo.AllowMouseEffects = true;
            this.btnAgregarPlatillo.AllowToggling = false;
            this.btnAgregarPlatillo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPlatillo.AnimationSpeed = 200;
            this.btnAgregarPlatillo.AutoGenerateColors = false;
            this.btnAgregarPlatillo.AutoRoundBorders = false;
            this.btnAgregarPlatillo.AutoSizeLeftIcon = true;
            this.btnAgregarPlatillo.AutoSizeRightIcon = true;
            this.btnAgregarPlatillo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarPlatillo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarPlatillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPlatillo.BackgroundImage")));
            this.btnAgregarPlatillo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarPlatillo.ButtonText = "Agregar platillo";
            this.btnAgregarPlatillo.ButtonTextMarginLeft = 0;
            this.btnAgregarPlatillo.ColorContrastOnClick = 45;
            this.btnAgregarPlatillo.ColorContrastOnHover = 45;
            this.btnAgregarPlatillo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregarPlatillo.CustomizableEdges = borderEdges1;
            this.btnAgregarPlatillo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarPlatillo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarPlatillo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarPlatillo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarPlatillo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarPlatillo.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.btnAgregarPlatillo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPlatillo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPlatillo.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPlatillo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarPlatillo.IconMarginLeft = 11;
            this.btnAgregarPlatillo.IconPadding = 8;
            this.btnAgregarPlatillo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPlatillo.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPlatillo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarPlatillo.IconSize = 1;
            this.btnAgregarPlatillo.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarPlatillo.IdleBorderRadius = 6;
            this.btnAgregarPlatillo.IdleBorderThickness = 1;
            this.btnAgregarPlatillo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarPlatillo.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPlatillo.IdleIconLeftImage")));
            this.btnAgregarPlatillo.IdleIconRightImage = null;
            this.btnAgregarPlatillo.IndicateFocus = false;
            this.btnAgregarPlatillo.Location = new System.Drawing.Point(881, 197);
            this.btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            this.btnAgregarPlatillo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarPlatillo.OnDisabledState.BorderRadius = 6;
            this.btnAgregarPlatillo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarPlatillo.OnDisabledState.BorderThickness = 1;
            this.btnAgregarPlatillo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarPlatillo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarPlatillo.OnDisabledState.IconLeftImage = null;
            this.btnAgregarPlatillo.OnDisabledState.IconRightImage = null;
            this.btnAgregarPlatillo.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarPlatillo.onHoverState.BorderRadius = 6;
            this.btnAgregarPlatillo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarPlatillo.onHoverState.BorderThickness = 1;
            this.btnAgregarPlatillo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarPlatillo.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPlatillo.onHoverState.IconLeftImage = null;
            this.btnAgregarPlatillo.onHoverState.IconRightImage = null;
            this.btnAgregarPlatillo.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarPlatillo.OnIdleState.BorderRadius = 6;
            this.btnAgregarPlatillo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarPlatillo.OnIdleState.BorderThickness = 1;
            this.btnAgregarPlatillo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarPlatillo.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPlatillo.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPlatillo.OnIdleState.IconLeftImage")));
            this.btnAgregarPlatillo.OnIdleState.IconRightImage = null;
            this.btnAgregarPlatillo.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarPlatillo.OnPressedState.BorderRadius = 6;
            this.btnAgregarPlatillo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarPlatillo.OnPressedState.BorderThickness = 1;
            this.btnAgregarPlatillo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarPlatillo.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPlatillo.OnPressedState.IconLeftImage = null;
            this.btnAgregarPlatillo.OnPressedState.IconRightImage = null;
            this.btnAgregarPlatillo.Size = new System.Drawing.Size(177, 36);
            this.btnAgregarPlatillo.TabIndex = 25;
            this.btnAgregarPlatillo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarPlatillo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarPlatillo.TextMarginLeft = 0;
            this.btnAgregarPlatillo.TextPadding = new System.Windows.Forms.Padding(0, 1, 8, 0);
            this.btnAgregarPlatillo.UseDefaultRadiusAndThickness = true;
            this.btnAgregarPlatillo.Click += new System.EventHandler(this.btnAgregarPlatillo_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(50, 206);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 27;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.AcceptsReturn = false;
            this.txtFiltrar.AcceptsTab = false;
            this.txtFiltrar.AnimationSpeed = 200;
            this.txtFiltrar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFiltrar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFiltrar.BackColor = System.Drawing.Color.White;
            this.txtFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFiltrar.BackgroundImage")));
            this.txtFiltrar.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFiltrar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFiltrar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFiltrar.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtFiltrar.BorderRadius = 6;
            this.txtFiltrar.BorderThickness = 1;
            this.txtFiltrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFiltrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.DefaultFont = new System.Drawing.Font("Poppins", 11F);
            this.txtFiltrar.DefaultText = "";
            this.txtFiltrar.FillColor = System.Drawing.Color.White;
            this.txtFiltrar.HideSelection = true;
            this.txtFiltrar.IconLeft = null;
            this.txtFiltrar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.IconPadding = 10;
            this.txtFiltrar.IconRight = null;
            this.txtFiltrar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(40, 197);
            this.txtFiltrar.MaximumSize = new System.Drawing.Size(325, 36);
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.MinimumSize = new System.Drawing.Size(325, 36);
            this.txtFiltrar.Modified = false;
            this.txtFiltrar.Multiline = false;
            this.txtFiltrar.Name = "txtFiltrar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltrar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFiltrar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltrar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltrar.OnIdleState = stateProperties4;
            this.txtFiltrar.Padding = new System.Windows.Forms.Padding(3);
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtFiltrar.PlaceholderText = "Buscar . . . ";
            this.txtFiltrar.ReadOnly = false;
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.ShortcutsEnabled = true;
            this.txtFiltrar.Size = new System.Drawing.Size(325, 36);
            this.txtFiltrar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFiltrar.TabIndex = 26;
            this.txtFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltrar.TextMarginBottom = 0;
            this.txtFiltrar.TextMarginLeft = 25;
            this.txtFiltrar.TextMarginTop = 0;
            this.txtFiltrar.TextPlaceholder = "Buscar . . . ";
            this.txtFiltrar.UseSystemPasswordChar = false;
            this.txtFiltrar.WordWrap = true;
            this.txtFiltrar.TextChange += new System.EventHandler(this.txtFiltrar_TextChange);
            // 
            // cbFiltro
            // 
            this.cbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.cbFiltro.BackgroundColor = System.Drawing.Color.White;
            this.cbFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbFiltro.BorderRadius = 6;
            this.cbFiltro.Color = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltro.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbFiltro.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFiltro.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbFiltro.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbFiltro.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbFiltro.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbFiltro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFiltro.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFiltro.FillDropDown = true;
            this.cbFiltro.FillIndicator = false;
            this.cbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFiltro.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Icon = null;
            this.cbFiltro.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFiltro.IndicatorColor = System.Drawing.Color.Gray;
            this.cbFiltro.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbFiltro.ItemBackColor = System.Drawing.Color.White;
            this.cbFiltro.ItemBorderColor = System.Drawing.Color.White;
            this.cbFiltro.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFiltro.ItemHeight = 30;
            this.cbFiltro.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFiltro.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Activo",
            "Inactivo"});
            this.cbFiltro.ItemTopMargin = 6;
            this.cbFiltro.Location = new System.Drawing.Point(416, 197);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(166, 36);
            this.cbFiltro.TabIndex = 43;
            this.cbFiltro.Text = null;
            this.cbFiltro.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbFiltro.TextLeftMargin = 5;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(416, 165);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(52, 26);
            this.bunifuLabel3.TabIndex = 42;
            this.bunifuLabel3.Text = "Estado";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 699);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.btnAgregarPlatillo);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.bunifuLabel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarPlatillo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewImageColumn EstadoImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFiltrar;
        public Bunifu.UI.WinForms.BunifuDropdown cbFiltro;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}