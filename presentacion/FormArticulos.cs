using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using datos;
using modelo;

namespace presentacion
{
    public partial class FormArticulos : Form
    {
        private List<Articulo> _listaArticulo;

        public FormArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flpSearch1.Visible = false;
            flpSearch2.Visible = false;
            flpSearch3.Visible = false;
            CargarDgv();
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
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            FormABM modificar = new FormABM(seleccionado);
            modificar.ShowDialog();
            CargarDgv();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el artículo " + seleccionado.Nombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            FormVerDetalle detalle = new FormVerDetalle(seleccionado);
            detalle.ShowDialog();
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
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
        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            flpSearch1.Visible = !flpSearch2.Visible;
            flpSearch2.Visible = !flpSearch2.Visible;
            flpSearch3.Visible = !flpSearch3.Visible;
            if (flpSearch1.Visible)
            {
                btnBusquedaAvanzada.Text = "Cerrar Búsqueda";
            }
            else
            {
                btnBusquedaAvanzada.Text = "Búsqueda Avanzada";
            }
        }
    }
}
