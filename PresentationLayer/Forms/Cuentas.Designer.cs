namespace FOOD
{
    partial class Cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.cbFiltro = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvCuentas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.pagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.descartar = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregarCuenta = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtFiltro = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pdRecibo = new System.Drawing.Printing.PrintDocument();
            this.ppdRecibo = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            "Pendiente",
            "Cancelado"});
            this.cbFiltro.ItemTopMargin = 6;
            this.cbFiltro.Location = new System.Drawing.Point(259, 197);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(166, 36);
            this.cbFiltro.TabIndex = 50;
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
            this.bunifuLabel3.Location = new System.Drawing.Point(259, 165);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(52, 26);
            this.bunifuLabel3.TabIndex = 49;
            this.bunifuLabel3.Text = "Estado";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowCustomTheming = true;
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.AllowUserToResizeColumns = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvCuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.ColumnHeadersHeight = 55;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billID,
            this.order,
            this.EstadoImg,
            this.Estado,
            this.total,
            this.Date,
            this.ver,
            this.pagar,
            this.imprimir,
            this.descartar});
            this.dgvCuentas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCuentas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvCuentas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvCuentas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvCuentas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvCuentas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvCuentas.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvCuentas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Empty;
            this.dgvCuentas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.dgvCuentas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCuentas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvCuentas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvCuentas.CurrentTheme.Name = null;
            this.dgvCuentas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCuentas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvCuentas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvCuentas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvCuentas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCuentas.EnableHeadersVisualStyles = false;
            this.dgvCuentas.GridColor = System.Drawing.Color.White;
            this.dgvCuentas.HeaderBackColor = System.Drawing.Color.Empty;
            this.dgvCuentas.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvCuentas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCuentas.Location = new System.Drawing.Point(40, 268);
            this.dgvCuentas.MultiSelect = false;
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersVisible = false;
            this.dgvCuentas.RowTemplate.Height = 60;
            this.dgvCuentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.Size = new System.Drawing.Size(1018, 382);
            this.dgvCuentas.TabIndex = 45;
            this.dgvCuentas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvCuentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_CellContentClick);
            // 
            // billID
            // 
            this.billID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.billID.FillWeight = 130.779F;
            this.billID.Frozen = true;
            this.billID.HeaderText = "ID";
            this.billID.Name = "billID";
            this.billID.ReadOnly = true;
            this.billID.Width = 200;
            // 
            // order
            // 
            this.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.order.FillWeight = 123.0994F;
            this.order.Frozen = true;
            this.order.HeaderText = "Orden";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.Width = 150;
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
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.FillWeight = 67.70091F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.Width = 150;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ver
            // 
            this.ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.ver.DefaultCellStyle = dataGridViewCellStyle4;
            this.ver.FillWeight = 60.9137F;
            this.ver.HeaderText = "";
            this.ver.Image = ((System.Drawing.Image)(resources.GetObject("ver.Image")));
            this.ver.MinimumWidth = 30;
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ver.Width = 30;
            // 
            // pagar
            // 
            this.pagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.pagar.DefaultCellStyle = dataGridViewCellStyle5;
            this.pagar.HeaderText = "";
            this.pagar.Image = ((System.Drawing.Image)(resources.GetObject("pagar.Image")));
            this.pagar.MinimumWidth = 30;
            this.pagar.Name = "pagar";
            this.pagar.ReadOnly = true;
            this.pagar.Width = 30;
            // 
            // imprimir
            // 
            this.imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.imprimir.DefaultCellStyle = dataGridViewCellStyle6;
            this.imprimir.HeaderText = "";
            this.imprimir.Image = ((System.Drawing.Image)(resources.GetObject("imprimir.Image")));
            this.imprimir.MinimumWidth = 30;
            this.imprimir.Name = "imprimir";
            this.imprimir.ReadOnly = true;
            this.imprimir.Width = 30;
            // 
            // descartar
            // 
            this.descartar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.descartar.DefaultCellStyle = dataGridViewCellStyle7;
            this.descartar.HeaderText = "";
            this.descartar.Image = ((System.Drawing.Image)(resources.GetObject("descartar.Image")));
            this.descartar.MinimumWidth = 30;
            this.descartar.Name = "descartar";
            this.descartar.ReadOnly = true;
            this.descartar.Width = 30;
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
            this.bunifuLabel10.Size = new System.Drawing.Size(292, 51);
            this.bunifuLabel10.TabIndex = 44;
            this.bunifuLabel10.Text = "Gestión de Cuentas";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn1.FillWeight = 60.9137F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.AllowAnimations = true;
            this.btnAgregarCuenta.AllowMouseEffects = true;
            this.btnAgregarCuenta.AllowToggling = false;
            this.btnAgregarCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCuenta.AnimationSpeed = 200;
            this.btnAgregarCuenta.AutoGenerateColors = false;
            this.btnAgregarCuenta.AutoRoundBorders = false;
            this.btnAgregarCuenta.AutoSizeLeftIcon = true;
            this.btnAgregarCuenta.AutoSizeRightIcon = true;
            this.btnAgregarCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCuenta.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCuenta.BackgroundImage")));
            this.btnAgregarCuenta.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarCuenta.ButtonText = "Agregar Cuenta";
            this.btnAgregarCuenta.ButtonTextMarginLeft = 0;
            this.btnAgregarCuenta.ColorContrastOnClick = 45;
            this.btnAgregarCuenta.ColorContrastOnHover = 45;
            this.btnAgregarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregarCuenta.CustomizableEdges = borderEdges1;
            this.btnAgregarCuenta.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarCuenta.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarCuenta.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarCuenta.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarCuenta.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarCuenta.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.btnAgregarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCuenta.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCuenta.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarCuenta.IconMarginLeft = 11;
            this.btnAgregarCuenta.IconPadding = 8;
            this.btnAgregarCuenta.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCuenta.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCuenta.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarCuenta.IconSize = 1;
            this.btnAgregarCuenta.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarCuenta.IdleBorderRadius = 6;
            this.btnAgregarCuenta.IdleBorderThickness = 1;
            this.btnAgregarCuenta.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarCuenta.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCuenta.IdleIconLeftImage")));
            this.btnAgregarCuenta.IdleIconRightImage = null;
            this.btnAgregarCuenta.IndicateFocus = false;
            this.btnAgregarCuenta.Location = new System.Drawing.Point(881, 197);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarCuenta.OnDisabledState.BorderRadius = 6;
            this.btnAgregarCuenta.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarCuenta.OnDisabledState.BorderThickness = 1;
            this.btnAgregarCuenta.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarCuenta.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarCuenta.OnDisabledState.IconLeftImage = null;
            this.btnAgregarCuenta.OnDisabledState.IconRightImage = null;
            this.btnAgregarCuenta.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarCuenta.onHoverState.BorderRadius = 6;
            this.btnAgregarCuenta.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarCuenta.onHoverState.BorderThickness = 1;
            this.btnAgregarCuenta.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarCuenta.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.onHoverState.IconLeftImage = null;
            this.btnAgregarCuenta.onHoverState.IconRightImage = null;
            this.btnAgregarCuenta.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarCuenta.OnIdleState.BorderRadius = 6;
            this.btnAgregarCuenta.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarCuenta.OnIdleState.BorderThickness = 1;
            this.btnAgregarCuenta.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarCuenta.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCuenta.OnIdleState.IconLeftImage")));
            this.btnAgregarCuenta.OnIdleState.IconRightImage = null;
            this.btnAgregarCuenta.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarCuenta.OnPressedState.BorderRadius = 6;
            this.btnAgregarCuenta.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarCuenta.OnPressedState.BorderThickness = 1;
            this.btnAgregarCuenta.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarCuenta.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCuenta.OnPressedState.IconLeftImage = null;
            this.btnAgregarCuenta.OnPressedState.IconRightImage = null;
            this.btnAgregarCuenta.Size = new System.Drawing.Size(177, 36);
            this.btnAgregarCuenta.TabIndex = 46;
            this.btnAgregarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCuenta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarCuenta.TextMarginLeft = 0;
            this.btnAgregarCuenta.TextPadding = new System.Windows.Forms.Padding(0, 1, 8, 0);
            this.btnAgregarCuenta.UseDefaultRadiusAndThickness = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
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
            this.iconPictureBox1.TabIndex = 52;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.AcceptsReturn = false;
            this.txtFiltro.AcceptsTab = false;
            this.txtFiltro.AnimationSpeed = 200;
            this.txtFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFiltro.BackgroundImage")));
            this.txtFiltro.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFiltro.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFiltro.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtFiltro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtFiltro.BorderRadius = 6;
            this.txtFiltro.BorderThickness = 1;
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.DefaultFont = new System.Drawing.Font("Poppins", 11F);
            this.txtFiltro.DefaultText = "";
            this.txtFiltro.FillColor = System.Drawing.Color.White;
            this.txtFiltro.HideSelection = true;
            this.txtFiltro.IconLeft = null;
            this.txtFiltro.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.IconPadding = 10;
            this.txtFiltro.IconRight = null;
            this.txtFiltro.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(40, 197);
            this.txtFiltro.MaximumSize = new System.Drawing.Size(325, 36);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFiltro.Modified = false;
            this.txtFiltro.Multiline = false;
            this.txtFiltro.Name = "txtFiltro";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltro.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFiltro.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltro.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFiltro.OnIdleState = stateProperties4;
            this.txtFiltro.Padding = new System.Windows.Forms.Padding(3);
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtFiltro.PlaceholderText = "Buscar ID . . . ";
            this.txtFiltro.ReadOnly = false;
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(165, 36);
            this.txtFiltro.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFiltro.TabIndex = 51;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltro.TextMarginBottom = 0;
            this.txtFiltro.TextMarginLeft = 25;
            this.txtFiltro.TextMarginTop = 0;
            this.txtFiltro.TextPlaceholder = "Buscar ID . . . ";
            this.txtFiltro.UseSystemPasswordChar = false;
            this.txtFiltro.WordWrap = true;
            this.txtFiltro.TextChange += new System.EventHandler(this.txtFiltro_TextChange);
            // 
            // pdRecibo
            // 
            this.pdRecibo.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdRecibo_PrintPage);
            // 
            // ppdRecibo
            // 
            this.ppdRecibo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdRecibo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdRecibo.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdRecibo.Enabled = true;
            this.ppdRecibo.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdRecibo.Icon")));
            this.ppdRecibo.Name = "ppdRecibo";
            this.ppdRecibo.Visible = false;
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 699);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.bunifuLabel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuDropdown cbFiltro;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarCuenta;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvCuentas;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtFiltro;
        private System.Drawing.Printing.PrintDocument pdRecibo;
        private System.Windows.Forms.PrintPreviewDialog ppdRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
        private System.Windows.Forms.DataGridViewImageColumn EstadoImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewImageColumn ver;
        private System.Windows.Forms.DataGridViewImageColumn pagar;
        private System.Windows.Forms.DataGridViewImageColumn imprimir;
        private System.Windows.Forms.DataGridViewImageColumn descartar;
    }
}