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
        #region Declaraciones

        private List<Articulo> _listaArticulo;

        #endregion

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
                _listaArticulo = lista.ListaDB();
                Dgv.DataSource = _listaArticulo;
                Dgv.Columns["Url_imagen"].Visible = false;
                //cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Dgv_SelectionChanged (object sender, EventArgs e)
        {
            //if (Dgv.CurrentRow != null)
            //{
            //    Articulo seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            //    cargarImagen(seleccionado.UrlImagen);
            //}
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)Dgv.CurrentRow.DataBoundItem;
            FormABM modificar = new FormABM(seleccionado);
            modificar.ShowDialog();
            CargarDgv();

        }
    }
}
