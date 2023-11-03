namespace FOOD
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvUsuarios = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnAgregarUsuario = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtFiltrar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.scrollbar1 = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuLabel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 160);
            this.panel1.TabIndex = 5;
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
            this.bunifuLabel10.Size = new System.Drawing.Size(294, 51);
            this.bunifuLabel10.TabIndex = 2;
            this.bunifuLabel10.Text = "Gestión de usuarios";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowCustomTheming = true;
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins Medium", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 55;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.fullName,
            this.rol,
            this.phone,
            this.email,
            this.editar,
            this.eliminar});
            this.dgvUsuarios.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvUsuarios.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvUsuarios.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.CurrentTheme.GridColor = System.Drawing.Color.White;
            this.dgvUsuarios.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.dgvUsuarios.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.CurrentTheme.Name = null;
            this.dgvUsuarios.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuarios.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F);
            this.dgvUsuarios.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvUsuarios.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.White;
            this.dgvUsuarios.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvUsuarios.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvUsuarios.HeaderForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.Location = new System.Drawing.Point(40, 268);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowTemplate.Height = 60;
            this.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1018, 382);
            this.dgvUsuarios.TabIndex = 18;
            this.dgvUsuarios.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
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
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.AllowAnimations = true;
            this.btnAgregarUsuario.AllowMouseEffects = true;
            this.btnAgregarUsuario.AllowToggling = false;
            this.btnAgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarUsuario.AnimationSpeed = 200;
            this.btnAgregarUsuario.AutoGenerateColors = false;
            this.btnAgregarUsuario.AutoRoundBorders = false;
            this.btnAgregarUsuario.AutoSizeLeftIcon = true;
            this.btnAgregarUsuario.AutoSizeRightIcon = true;
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarUsuario.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.BackgroundImage")));
            this.btnAgregarUsuario.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.ButtonText = "Agregar usuario";
            this.btnAgregarUsuario.ButtonTextMarginLeft = 0;
            this.btnAgregarUsuario.ColorContrastOnClick = 45;
            this.btnAgregarUsuario.ColorContrastOnHover = 45;
            this.btnAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAgregarUsuario.CustomizableEdges = borderEdges1;
            this.btnAgregarUsuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarUsuario.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarUsuario.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarUsuario.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarUsuario.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Poppins Medium", 11F);
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarUsuario.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAgregarUsuario.IconMarginLeft = 11;
            this.btnAgregarUsuario.IconPadding = 8;
            this.btnAgregarUsuario.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUsuario.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuario.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAgregarUsuario.IconSize = 1;
            this.btnAgregarUsuario.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarUsuario.IdleBorderRadius = 6;
            this.btnAgregarUsuario.IdleBorderThickness = 1;
            this.btnAgregarUsuario.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarUsuario.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.IdleIconLeftImage")));
            this.btnAgregarUsuario.IdleIconRightImage = null;
            this.btnAgregarUsuario.IndicateFocus = false;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(879, 197);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAgregarUsuario.OnDisabledState.BorderRadius = 6;
            this.btnAgregarUsuario.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.OnDisabledState.BorderThickness = 1;
            this.btnAgregarUsuario.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAgregarUsuario.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAgregarUsuario.OnDisabledState.IconLeftImage = null;
            this.btnAgregarUsuario.OnDisabledState.IconRightImage = null;
            this.btnAgregarUsuario.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarUsuario.onHoverState.BorderRadius = 6;
            this.btnAgregarUsuario.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.onHoverState.BorderThickness = 1;
            this.btnAgregarUsuario.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(44)))), ((int)(((byte)(69)))));
            this.btnAgregarUsuario.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.onHoverState.IconLeftImage = null;
            this.btnAgregarUsuario.onHoverState.IconRightImage = null;
            this.btnAgregarUsuario.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarUsuario.OnIdleState.BorderRadius = 6;
            this.btnAgregarUsuario.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.OnIdleState.BorderThickness = 1;
            this.btnAgregarUsuario.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarUsuario.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.OnIdleState.IconLeftImage")));
            this.btnAgregarUsuario.OnIdleState.IconRightImage = null;
            this.btnAgregarUsuario.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarUsuario.OnPressedState.BorderRadius = 6;
            this.btnAgregarUsuario.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAgregarUsuario.OnPressedState.BorderThickness = 1;
            this.btnAgregarUsuario.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAgregarUsuario.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsuario.OnPressedState.IconLeftImage = null;
            this.btnAgregarUsuario.OnPressedState.IconRightImage = null;
            this.btnAgregarUsuario.Size = new System.Drawing.Size(179, 36);
            this.btnAgregarUsuario.TabIndex = 16;
            this.btnAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAgregarUsuario.TextMarginLeft = 0;
            this.btnAgregarUsuario.TextPadding = new System.Windows.Forms.Padding(0, 1, 8, 0);
            this.btnAgregarUsuario.UseDefaultRadiusAndThickness = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuarios_Click);
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
            this.txtFiltrar.TabIndex = 12;
            this.txtFiltrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFiltrar.TextMarginBottom = 0;
            this.txtFiltrar.TextMarginLeft = 25;
            this.txtFiltrar.TextMarginTop = 0;
            this.txtFiltrar.TextPlaceholder = "Buscar . . . ";
            this.txtFiltrar.UseSystemPasswordChar = false;
            this.txtFiltrar.WordWrap = true;
            this.txtFiltrar.TextChange += new System.EventHandler(this.txtFiltrar_TextChange);
            // 
            // scrollbar1
            // 
            this.scrollbar1.AllowCursorChanges = true;
            this.scrollbar1.AllowHomeEndKeysDetection = false;
            this.scrollbar1.AllowIncrementalClickMoves = true;
            this.scrollbar1.AllowMouseDownEffects = true;
            this.scrollbar1.AllowMouseHoverEffects = true;
            this.scrollbar1.AllowScrollingAnimations = true;
            this.scrollbar1.AllowScrollKeysDetection = true;
            this.scrollbar1.AllowScrollOptionsMenu = true;
            this.scrollbar1.AllowShrinkingOnFocusLost = false;
            this.scrollbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollbar1.BackgroundColor = System.Drawing.Color.White;
            this.scrollbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scrollbar1.BackgroundImage")));
            this.scrollbar1.BindingContainer = null;
            this.scrollbar1.BorderColor = System.Drawing.Color.White;
            this.scrollbar1.BorderRadius = 6;
            this.scrollbar1.BorderThickness = 1;
            this.scrollbar1.DurationBeforeShrink = 2000;
            this.scrollbar1.LargeChange = 80;
            this.scrollbar1.Location = new System.Drawing.Point(1067, 309);
            this.scrollbar1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.scrollbar1.Maximum = 100;
            this.scrollbar1.Minimum = 0;
            this.scrollbar1.MinimumThumbLength = 18;
            this.scrollbar1.Name = "scrollbar1";
            this.scrollbar1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.scrollbar1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.scrollbar1.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.scrollbar1.ScrollBarBorderColor = System.Drawing.Color.White;
            this.scrollbar1.ScrollBarColor = System.Drawing.Color.White;
            this.scrollbar1.ShrinkSizeLimit = 1;
            this.scrollbar1.Size = new System.Drawing.Size(15, 341);
            this.scrollbar1.SmallChange = 1;
            this.scrollbar1.TabIndex = 19;
            this.scrollbar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.scrollbar1.ThumbLength = 268;
            this.scrollbar1.ThumbMargin = 1;
            this.scrollbar1.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.scrollbar1.Value = 0;
            // 
            // UserID
            // 
            this.UserID.FillWeight = 81.25828F;
            this.UserID.HeaderText = "ID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.FillWeight = 140.3211F;
            this.fullName.HeaderText = "Nombre";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // rol
            // 
            this.rol.FillWeight = 68.72766F;
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.FillWeight = 77.26238F;
            this.phone.HeaderText = "Telefono";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.FillWeight = 156.711F;
            this.email.HeaderText = "Correo";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.editar.FillWeight = 60.9137F;
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.MinimumWidth = 30;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 30;
            // 
            // eliminar
            // 
            this.eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.eliminar.FillWeight = 114.806F;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.MinimumWidth = 30;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Width = 30;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 699);
            this.Controls.Add(this.scrollbar1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuTextBox txtFiltrar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAgregarUsuario;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvUsuarios;
        private Bunifu.UI.WinForms.BunifuVScrollBar scrollbar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}