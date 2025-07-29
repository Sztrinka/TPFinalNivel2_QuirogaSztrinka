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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            FormABM modificar = new FormABM(seleccionado);
            modificar.ShowDialog();
            CargarDgv();
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
    }
}
