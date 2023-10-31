namespace FOOD
{
    partial class Mesas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesas));
            this.dgvMesas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.tableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAgregarMesa = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbFiltro = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowCustomTheming = true;
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.AllowUserToDeleteRows = false;
            this.dgvMesas.AllowUserToResizeColumns = false;
            this.dgvMesas.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins Medium", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMesas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMesas.ColumnHeadersHeight = 55;
            this.dgvMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableID,
            this.Capacidad,
            this.EstadoImg,
            this.Estado,
            this.editar});
            this.dgvMesas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMesas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvMesas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvMesas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvMesas.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvMesas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.dgvMesas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMesas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.CurrentTheme.Name = null;
            this.dgvMesas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMesas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvMesas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvMesas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMesas.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMesas.EnableHeadersVisualStyles = false;
            this.dgvMesas.GridColor = System.Drawing.Color.White;
            this.dgvMesas.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvMesas.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvMesas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvMesas.Location = new System.Drawing.Point(40, 268);
            this.dgvMesas.MultiSelect = false;
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.ReadOnly = true;
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.RowTemplate.Height = 60;
            this.dgvMesas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesas.Size = new System.Drawing.Size(1018, 382);
            this.dgvMesas.TabIndex = 21;
            this.dgvMesas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvMesas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesas_CellContentClick);
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
            this.bunifuLabel10.Size = new System.Drawing.Size(266, 51);
            this.bunifuLabel10.TabIndex = 22;
            this.bunifuLabel10.Text = "Gestión de mesas";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tableID
            // 
            this.tableID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tableID.FillWeight = 130.779F;
            this.tableID.Frozen = true;
            this.tableID.HeaderText = "Mesa";
            this.tableID.Name = "tableID";
            this.tableID.ReadOnly = true;
            this.tableID.Width = 150;
            // 
            // Capacidad
            // 
            this.Capacidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Capacidad.FillWeight = 123.0994F;
            this.Capacidad.Frozen = true;
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            this.Capacidad.Width = 200;
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
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle9;
            this.Estado.FillWeight = 67.70091F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewImageColumn1.FillWeight = 60.9137F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // btnAgregarMesa
            // 
            this.btnAgregarMesa.AllowAnimations = true;
            this.btnAgregarMesa.AllowMouseEffects = true;
            this.btnAgregarMesa.AllowToggling = false;
            this.btnAgregarMesa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarMesa.AnimationSpeed = 200;
            this.btnAgregarMesa.AutoGenerateColors = false;
            this.btnAgregarMesa.AutoRoundBorders = false;
            this.btnAgregarMesa.AutoSizeLeftIcon = true;
            this.btnAgregarMesa.AutoSizeRightIcon = true;
            this.btnAgregarMesa.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMesa.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarMesa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMesa.BackgroundImage")));
            this.btnAgregarMesa.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMesa.ButtonText = "Agregar mesa";
            this.btnAgregarMesa.ButtonTextMarginLeft = 0;
            this.btnAgregarMesa.ColorContrastOnClick = 45;
            this.btnAgregarMesa.ColorContrastOnHover = 45;
            this.btnAgregarMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAgregarMesa.CustomizableEdges = borderEdges2;
            this.btnAgregarMesa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarMesa.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarMesa.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarMesa.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarMesa.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarMesa.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.btnAgregarMesa.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMesa.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMesa.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMesa.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarMesa.IconMarginLeft = 11;
            this.btnAgregarMesa.IconPadding = 8;
            this.btnAgregarMesa.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMesa.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMesa.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarMesa.IconSize = 1;
            this.btnAgregarMesa.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarMesa.IdleBorderRadius = 6;
            this.btnAgregarMesa.IdleBorderThickness = 1;
            this.btnAgregarMesa.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarMesa.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMesa.IdleIconLeftImage")));
            this.btnAgregarMesa.IdleIconRightImage = null;
            this.btnAgregarMesa.IndicateFocus = false;
            this.btnAgregarMesa.Location = new System.Drawing.Point(891, 197);
            this.btnAgregarMesa.Name = "btnAgregarMesa";
            this.btnAgregarMesa.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarMesa.OnDisabledState.BorderRadius = 6;
            this.btnAgregarMesa.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMesa.OnDisabledState.BorderThickness = 1;
            this.btnAgregarMesa.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarMesa.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarMesa.OnDisabledState.IconLeftImage = null;
            this.btnAgregarMesa.OnDisabledState.IconRightImage = null;
            this.btnAgregarMesa.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarMesa.onHoverState.BorderRadius = 6;
            this.btnAgregarMesa.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMesa.onHoverState.BorderThickness = 1;
            this.btnAgregarMesa.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarMesa.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMesa.onHoverState.IconLeftImage = null;
            this.btnAgregarMesa.onHoverState.IconRightImage = null;
            this.btnAgregarMesa.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarMesa.OnIdleState.BorderRadius = 6;
            this.btnAgregarMesa.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMesa.OnIdleState.BorderThickness = 1;
            this.btnAgregarMesa.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarMesa.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMesa.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarMesa.OnIdleState.IconLeftImage")));
            this.btnAgregarMesa.OnIdleState.IconRightImage = null;
            this.btnAgregarMesa.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarMesa.OnPressedState.BorderRadius = 6;
            this.btnAgregarMesa.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarMesa.OnPressedState.BorderThickness = 1;
            this.btnAgregarMesa.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarMesa.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMesa.OnPressedState.IconLeftImage = null;
            this.btnAgregarMesa.OnPressedState.IconRightImage = null;
            this.btnAgregarMesa.Size = new System.Drawing.Size(167, 36);
            this.btnAgregarMesa.TabIndex = 23;
            this.btnAgregarMesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMesa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarMesa.TextMarginLeft = 0;
            this.btnAgregarMesa.TextPadding = new System.Windows.Forms.Padding(0, 1, 8, 0);
            this.btnAgregarMesa.UseDefaultRadiusAndThickness = true;
            this.btnAgregarMesa.Click += new System.EventHandler(this.btnAgregarMesa_Click);
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.editar.DefaultCellStyle = dataGridViewCellStyle10;
            this.editar.FillWeight = 60.9137F;
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.MinimumWidth = 30;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 30;
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
            this.cbFiltro.ItemHeight = 34;
            this.cbFiltro.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cbFiltro.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Disponible",
            "Ocupada",
            "Inactiva"});
            this.cbFiltro.ItemTopMargin = 6;
            this.cbFiltro.Location = new System.Drawing.Point(40, 193);
            this.cbFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(166, 40);
            this.cbFiltro.TabIndex = 39;
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
            this.bunifuLabel3.Location = new System.Drawing.Point(40, 161);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(52, 26);
            this.bunifuLabel3.TabIndex = 38;
            this.bunifuLabel3.Text = "Estado";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Mesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 699);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.btnAgregarMesa);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.dgvMesas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mesas";
            this.Text = "Mesas";
            this.Load += new System.EventHandler(this.Mesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvMesas;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewImageColumn EstadoImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public Bunifu.UI.WinForms.BunifuDropdown cbFiltro;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
    }
}