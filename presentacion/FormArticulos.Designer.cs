namespace presentacion
{
    partial class FormArticulos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.limpiar_search = new System.Windows.Forms.Button();
            this.flpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.flpCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.flpMarca = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.flpPrecio = new System.Windows.Forms.FlowLayoutPanel();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.flpPrecioDesde = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.flpPrecioHasta = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.limpiar_cbo = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.flpBotones.SuspendLayout();
            this.flpCategoria.SuspendLayout();
            this.flpMarca.SuspendLayout();
            this.flpPrecio.SuspendLayout();
            this.flp.SuspendLayout();
            this.flpPrecioDesde.SuspendLayout();
            this.flpPrecioHasta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(4, 157);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(170, 48);
            this.BtnModificar.TabIndex = 0;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(4, 213);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 48);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(4, 100);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 49);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btnVerDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnVerDetalle.Image = ((System.Drawing.Image)(resources.GetObject("btnVerDetalle.Image")));
            this.btnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalle.Location = new System.Drawing.Point(4, 269);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(170, 48);
            this.btnVerDetalle.TabIndex = 6;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtSearch.Location = new System.Drawing.Point(63, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(693, 32);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscar.BackgroundImage")));
            this.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Buscar.FlatAppearance.BorderSize = 0;
            this.Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(14, 25);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(50, 40);
            this.Buscar.TabIndex = 8;
            this.Buscar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.limpiar_search);
            this.panel4.Controls.Add(this.Buscar);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(181, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 92);
            this.panel4.TabIndex = 9;
            // 
            // limpiar_search
            // 
            this.limpiar_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.limpiar_search.BackColor = System.Drawing.Color.Transparent;
            this.limpiar_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpiar_search.BackgroundImage")));
            this.limpiar_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.limpiar_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiar_search.FlatAppearance.BorderSize = 0;
            this.limpiar_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.limpiar_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar_search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar_search.ForeColor = System.Drawing.Color.White;
            this.limpiar_search.Location = new System.Drawing.Point(764, 30);
            this.limpiar_search.Margin = new System.Windows.Forms.Padding(4);
            this.limpiar_search.Name = "limpiar_search";
            this.limpiar_search.Size = new System.Drawing.Size(42, 31);
            this.limpiar_search.TabIndex = 9;
            this.limpiar_search.UseVisualStyleBackColor = false;
            this.limpiar_search.Click += new System.EventHandler(this.limpiar_search_Click);
            // 
            // flpBotones
            // 
            this.flpBotones.AutoSize = true;
            this.flpBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.flpBotones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBotones.Controls.Add(this.button1);
            this.flpBotones.Controls.Add(this.btnAgregar);
            this.flpBotones.Controls.Add(this.BtnModificar);
            this.flpBotones.Controls.Add(this.btnEliminar);
            this.flpBotones.Controls.Add(this.btnVerDetalle);
            this.flpBotones.Controls.Add(this.btnBusquedaAvanzada);
            this.flpBotones.Controls.Add(this.flpCategoria);
            this.flpBotones.Controls.Add(this.flpMarca);
            this.flpBotones.Controls.Add(this.flpPrecio);
            this.flpBotones.Controls.Add(this.limpiar_cbo);
            this.flpBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpBotones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBotones.Location = new System.Drawing.Point(0, 0);
            this.flpBotones.Name = "flpBotones";
            this.flpBotones.Size = new System.Drawing.Size(181, 720);
            this.flpBotones.TabIndex = 10;
            this.flpBotones.WrapContents = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 88);
            this.button1.TabIndex = 32;
            this.button1.Text = "GESTOR DE ARTÍCULOS";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.BackColor = System.Drawing.Color.Transparent;
            this.btnBusquedaAvanzada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBusquedaAvanzada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusquedaAvanzada.FlatAppearance.BorderSize = 0;
            this.btnBusquedaAvanzada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBusquedaAvanzada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAvanzada.ForeColor = System.Drawing.Color.Black;
            this.btnBusquedaAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("btnBusquedaAvanzada.Image")));
            this.btnBusquedaAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(4, 325);
            this.btnBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(170, 64);
            this.btnBusquedaAvanzada.TabIndex = 7;
            this.btnBusquedaAvanzada.Text = "Búsqueda Avanzada";
            this.btnBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusquedaAvanzada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // flpCategoria
            // 
            this.flpCategoria.Controls.Add(this.lblCategoria);
            this.flpCategoria.Controls.Add(this.cboCategoria);
            this.flpCategoria.Location = new System.Drawing.Point(3, 396);
            this.flpCategoria.Name = "flpCategoria";
            this.flpCategoria.Size = new System.Drawing.Size(173, 67);
            this.flpCategoria.TabIndex = 31;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(3, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblCategoria.Size = new System.Drawing.Size(93, 33);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(3, 36);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(166, 31);
            this.cboCategoria.TabIndex = 11;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // flpMarca
            // 
            this.flpMarca.Controls.Add(this.lblMarca);
            this.flpMarca.Controls.Add(this.cboMarca);
            this.flpMarca.Location = new System.Drawing.Point(3, 469);
            this.flpMarca.Name = "flpMarca";
            this.flpMarca.Size = new System.Drawing.Size(173, 67);
            this.flpMarca.TabIndex = 31;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarca.Location = new System.Drawing.Point(3, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 23);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(3, 26);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(166, 31);
            this.cboMarca.TabIndex = 10;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // flpPrecio
            // 
            this.flpPrecio.Controls.Add(this.flp);
            this.flpPrecio.Controls.Add(this.flpPrecioDesde);
            this.flpPrecio.Controls.Add(this.flpPrecioHasta);
            this.flpPrecio.Location = new System.Drawing.Point(3, 542);
            this.flpPrecio.Name = "flpPrecio";
            this.flpPrecio.Size = new System.Drawing.Size(173, 125);
            this.flpPrecio.TabIndex = 31;
            // 
            // flp
            // 
            this.flp.Controls.Add(this.lblPrecio);
            this.flp.Location = new System.Drawing.Point(3, 3);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(96, 29);
            this.flp.TabIndex = 31;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(3, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 23);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio:";
            // 
            // flpPrecioDesde
            // 
            this.flpPrecioDesde.Controls.Add(this.label4);
            this.flpPrecioDesde.Controls.Add(this.txtDesde);
            this.flpPrecioDesde.Location = new System.Drawing.Point(3, 38);
            this.flpPrecioDesde.Name = "flpPrecioDesde";
            this.flpPrecioDesde.Size = new System.Drawing.Size(171, 37);
            this.flpPrecioDesde.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Desde";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(68, 3);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(98, 30);
            this.txtDesde.TabIndex = 32;
            this.txtDesde.TextChanged += new System.EventHandler(this.txtDesde_TextChanged);
            // 
            // flpPrecioHasta
            // 
            this.flpPrecioHasta.Controls.Add(this.label5);
            this.flpPrecioHasta.Controls.Add(this.txtHasta);
            this.flpPrecioHasta.Location = new System.Drawing.Point(3, 81);
            this.flpPrecioHasta.Name = "flpPrecioHasta";
            this.flpPrecioHasta.Size = new System.Drawing.Size(171, 39);
            this.flpPrecioHasta.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hasta ";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(69, 3);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(97, 30);
            this.txtHasta.TabIndex = 33;
            this.txtHasta.TextChanged += new System.EventHandler(this.txtHasta_TextChanged);
            // 
            // limpiar_cbo
            // 
            this.limpiar_cbo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.limpiar_cbo.BackColor = System.Drawing.Color.Transparent;
            this.limpiar_cbo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limpiar_cbo.BackgroundImage")));
            this.limpiar_cbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.limpiar_cbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiar_cbo.FlatAppearance.BorderSize = 0;
            this.limpiar_cbo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(232)))));
            this.limpiar_cbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar_cbo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar_cbo.ForeColor = System.Drawing.Color.White;
            this.limpiar_cbo.Location = new System.Drawing.Point(68, 674);
            this.limpiar_cbo.Margin = new System.Windows.Forms.Padding(4);
            this.limpiar_cbo.Name = "limpiar_cbo";
            this.limpiar_cbo.Size = new System.Drawing.Size(42, 31);
            this.limpiar_cbo.TabIndex = 10;
            this.limpiar_cbo.UseVisualStyleBackColor = false;
            this.limpiar_cbo.Click += new System.EventHandler(this.limpiar_cbo_Click);
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToOrderColumns = true;
            this.Dgv.AllowUserToResizeColumns = false;
            this.Dgv.AllowUserToResizeRows = false;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(130)))));
            this.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = "0";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.GridColor = System.Drawing.Color.MediumPurple;
            this.Dgv.Location = new System.Drawing.Point(-1, -7);
            this.Dgv.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.RowTemplate.Height = 30;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(1044, 628);
            this.Dgv.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.Dgv);
            this.panel3.Location = new System.Drawing.Point(181, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 621);
            this.panel3.TabIndex = 31;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1224, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flpBotones);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormArticulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flpBotones.ResumeLayout(false);
            this.flpCategoria.ResumeLayout(false);
            this.flpCategoria.PerformLayout();
            this.flpMarca.ResumeLayout(false);
            this.flpMarca.PerformLayout();
            this.flpPrecio.ResumeLayout(false);
            this.flp.ResumeLayout(false);
            this.flp.PerformLayout();
            this.flpPrecioDesde.ResumeLayout(false);
            this.flpPrecioDesde.PerformLayout();
            this.flpPrecioHasta.ResumeLayout(false);
            this.flpPrecioHasta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button limpiar_search;
        private System.Windows.Forms.FlowLayoutPanel flpBotones;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpPrecioDesde;
        private System.Windows.Forms.FlowLayoutPanel flpPrecioHasta;
        private System.Windows.Forms.FlowLayoutPanel flpCategoria;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpMarca;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.FlowLayoutPanel flpPrecio;
        private System.Windows.Forms.Button limpiar_cbo;
    }
}

