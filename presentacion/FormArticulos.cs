using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;
using datos;
using modelo;

namespace presentacion
{
    public partial class FormArticulos : Form
    {
        private List<Articulo> _listaArticulo;
        private bool _cargandoCombo = true; // Para evitar que se ejecute el evento del ComboBox al cargar el form.
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloDB db = new ArticuloDB();
            flpMarca.Visible = false;
            flpCategoria.Visible = false;
            flpPrecio.Visible = false;
            limpiar_search.Visible = false;
            limpiar_cbo.Visible = false;
            CargarDgv();
            try
            {
                cboCategoria.DataSource = db.ListarCategoria();
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "Id";
                cboMarca.DataSource = db.ListarMarca();
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "Id";
                CargarCbo();
                _cargandoCombo = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías y marcas: " + ex.Message);
            }

        }

        private void CargarCbo()
        {
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            cboCategoria.Text = "Seleccione...";
            cboMarca.Text = "Seleccione...";
        }

        private void CargarDgv()
        {
            ArticuloDB lista = new ArticuloDB();
            try
            {
                _listaArticulo = lista.ListarArticulo();
                Dgv.DataSource = _listaArticulo;
                Dgv.Columns["Url_imagen"].Visible = false;
                Dgv.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        #region Botones Agregar, Modificar, Eliminar y Ver Detalle
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (!RowSeleccionada()) //Validamos que tenga una row seleccionada
                return;
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            FormABM modificar = new FormABM(seleccionado);
            modificar.ShowDialog();
            CargarDgv();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!RowSeleccionada()) //Validamos que tenga una row seleccionada
                return;
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el artículo " + seleccionado.Nombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                ArticuloDB db = new ArticuloDB();
                try
                {
                    db.EliminarArticulo(seleccionado.Id);
                    CargarDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el artículo: " + ex.Message);
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormABM alta = new FormABM();
            alta.ShowDialog();
            CargarDgv();
        }
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (!RowSeleccionada()) //Validamos que tenga una row seleccionada
                return;
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            FormVerDetalle detalle = new FormVerDetalle(seleccionado);
            detalle.ShowDialog();
        }
        #endregion


        #region Filtros
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtSearch.Text.ToLower();
            if (filtro.Length < 3)
            {
                Dgv.DataSource = _listaArticulo;
                return;
            }
            var listaFiltrada = _listaArticulo.FindAll(articulo =>
                articulo.Nombre.ToLower().Contains(filtro) ||
                articulo.Descripcion.ToLower().Contains(filtro) ||
                articulo.Codigo.ToLower().Contains(filtro) ||
                articulo.Marca.Descripcion.ToLower().Contains(filtro) ||
                articulo.Categoria.Descripcion.ToLower().Contains(filtro));
            Dgv.DataSource = listaFiltrada;
            limpiar_search.Visible = true;
        }
        private void limpiar_search_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            Dgv.DataSource = _listaArticulo;
            limpiar_search.Visible = false;
        }
        private void limpiar_cbo_Click(object sender, EventArgs e)
        {
            CargarCbo();
            txtDesde.Text = string.Empty;
            txtHasta.Text = string.Empty;
        }
        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            flpMarca.Visible = !flpMarca.Visible;
            flpCategoria.Visible = !flpCategoria.Visible;
            flpPrecio.Visible = !flpPrecio.Visible;

            if (flpMarca.Visible)
            {
                btnBusquedaAvanzada.Text = "Cerrar Búsqueda";
                CargarCbo();
            }
            else
            {
                flpMarca.Visible = false;
                flpCategoria.Visible = false;
                flpPrecio.Visible = false;
                limpiar_cbo.Visible = false;
                CargarDgv();
                btnBusquedaAvanzada.Text = "Búsqueda Avanzada";
            }
        }
        private bool Filtrar()
        {
            ArticuloDB db = new ArticuloDB();

            string marca = "";
            string categoria = "";

            if (cboMarca.SelectedValue != null)
            {
                marca = cboMarca.SelectedValue.ToString();
            }

            if (cboCategoria.SelectedValue != null)
            {
                categoria = cboCategoria.SelectedValue.ToString();
            }
            string desde = txtDesde.Text;
            string hasta = txtHasta.Text;

            try
            {
                Dgv.DataSource = db.Filtrar(marca, categoria, desde, hasta);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoCombo) return; // Evita que se ejecute el evento al cargar el form.
            if (cboMarca.SelectedIndex != -1)
            {
                limpiar_cbo.Visible = true;
                if (!Filtrar())
                {
                    MessageBox.Show("No se pudo filtrar.");
                }
            }
            else { CargarDgv(); }
        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoCombo) return; // Evita que se ejecute el evento al cargar el form.
            if (cboCategoria.SelectedIndex != -1)
            {
                limpiar_cbo.Visible = true;
                if (!Filtrar())
                {
                    MessageBox.Show("No se pudo filtrar.");
                }
            }
            else { CargarDgv(); }
        }
        private void txtDesde_TextChanged(object sender, EventArgs e) //Filtro de precio 'Desde'
        {
            if (!EsValido(txtDesde.Text))
            {
                txtDesde.Text = string.Empty;
                return;
            }
            if (txtDesde.Text != string.Empty)
                limpiar_cbo.Visible = true;
            if (!Filtrar())
            {
                MessageBox.Show("No se pudo filtrar.");
            }
        }
        private void txtHasta_TextChanged(object sender, EventArgs e) //Filtro de precio 'Hasta'
        {
            if (!EsValido(txtHasta.Text))
            {
                txtHasta.Text = string.Empty;
                return;
            }

            if (txtHasta.Text != string.Empty)
                limpiar_cbo.Visible = true;
            if (!Filtrar())
            {
                MessageBox.Show("No se pudo filtrar.");
            }
        }
        #endregion


        #region Validaciones
        private bool EsNumero(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsNumber(c))
                    return false;
            }
            return true;
        }
        private bool EsValido(string a)
        {
            if (!EsNumero(a) && !string.IsNullOrWhiteSpace(a))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el precio.");
                return false;
            }
            return true;
        }
        private bool RowSeleccionada()
        {
            if (Dgv.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un artículo.");
                return false;
            }
            return true;
        }
        #endregion



    }
}


