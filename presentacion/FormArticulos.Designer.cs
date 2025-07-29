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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.limpiar_search = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.flpSearch2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSearch3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSearch1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.panel3.SuspendLayout();
            this.flpSearch2.SuspendLayout();
            this.flpSearch3.SuspendLayout();
            this.flpSearch1.SuspendLayout();
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
            this.BtnModificar.Location = new System.Drawing.Point(4, 61);
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
            this.btnEliminar.Location = new System.Drawing.Point(4, 117);
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
            this.btnAgregar.Location = new System.Drawing.Point(4, 4);
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
            this.btnVerDetalle.Location = new System.Drawing.Point(4, 173);
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
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtSearch.Location = new System.Drawing.Point(50, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(693, 23);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscar.BackgroundImage")));
            this.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.FlatAppearance.BorderSize = 0;
            this.Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.ForeColor = System.Drawing.Color.White;
            this.Buscar.Location = new System.Drawing.Point(1, 26);
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
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1174, 92);
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
            this.limpiar_search.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar_search.ForeColor = System.Drawing.Color.White;
            this.limpiar_search.Location = new System.Drawing.Point(751, 31);
            this.limpiar_search.Margin = new System.Windows.Forms.Padding(4);
            this.limpiar_search.Name = "limpiar_search";
            this.limpiar_search.Size = new System.Drawing.Size(42, 31);
            this.limpiar_search.TabIndex = 9;
            this.limpiar_search.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel1.Controls.Add(this.BtnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Controls.Add(this.btnVerDetalle);
            this.flowLayoutPanel1.Controls.Add(this.btnBusquedaAvanzada);
            this.flowLayoutPanel1.Controls.Add(this.flpSearch1);
            this.flowLayoutPanel1.Controls.Add(this.flpSearch2);
            this.flowLayoutPanel1.Controls.Add(this.flpSearch3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 667);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Format = "N3";
            dataGridViewCellStyle17.NullValue = "0";
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle17;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.GridColor = System.Drawing.Color.MediumPurple;
            this.Dgv.Location = new System.Drawing.Point(178, 0);
            this.Dgv.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowHeadersWidth = 51;
            this.Dgv.RowTemplate.Height = 40;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(996, 667);
            this.Dgv.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Dgv);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1174, 667);
            this.panel3.TabIndex = 31;
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(3, 26);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(166, 31);
            this.cbxMarca.TabIndex = 10;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(3, 79);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(166, 31);
            this.cbxCategoria.TabIndex = 11;
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
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategoria.Location = new System.Drawing.Point(3, 53);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(93, 23);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoría:";
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
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(4, 229);
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
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(3, 113);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblPrecio.Size = new System.Drawing.Size(64, 33);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio:";
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
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(68, 3);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(98, 30);
            this.txtDesde.TabIndex = 32;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(69, 3);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(97, 30);
            this.txtHasta.TabIndex = 33;
            // 
            // flpSearch2
            // 
            this.flpSearch2.Controls.Add(this.label4);
            this.flpSearch2.Controls.Add(this.txtDesde);
            this.flpSearch2.Location = new System.Drawing.Point(3, 464);
            this.flpSearch2.Name = "flpSearch2";
            this.flpSearch2.Size = new System.Drawing.Size(171, 37);
            this.flpSearch2.TabIndex = 31;
            // 
            // flpSearch3
            // 
            this.flpSearch3.Controls.Add(this.label5);
            this.flpSearch3.Controls.Add(this.txtHasta);
            this.flpSearch3.Location = new System.Drawing.Point(3, 507);
            this.flpSearch3.Name = "flpSearch3";
            this.flpSearch3.Size = new System.Drawing.Size(171, 39);
            this.flpSearch3.TabIndex = 31;
            // 
            // flpSearch1
            // 
            this.flpSearch1.Controls.Add(this.lblMarca);
            this.flpSearch1.Controls.Add(this.cbxMarca);
            this.flpSearch1.Controls.Add(this.lblCategoria);
            this.flpSearch1.Controls.Add(this.cbxCategoria);
            this.flpSearch1.Controls.Add(this.lblPrecio);
            this.flpSearch1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSearch1.Location = new System.Drawing.Point(3, 300);
            this.flpSearch1.Name = "flpSearch1";
            this.flpSearch1.Size = new System.Drawing.Size(172, 158);
            this.flpSearch1.TabIndex = 31;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1174, 759);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormArticulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flpSearch2.ResumeLayout(false);
            this.flpSearch2.PerformLayout();
            this.flpSearch3.ResumeLayout(false);
            this.flpSearch3.PerformLayout();
            this.flpSearch1.ResumeLayout(false);
            this.flpSearch1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpSearch2;
        private System.Windows.Forms.FlowLayoutPanel flpSearch3;
        private System.Windows.Forms.FlowLayoutPanel flpSearch1;
    }
}

