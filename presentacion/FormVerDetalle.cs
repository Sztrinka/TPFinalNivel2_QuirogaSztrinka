using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;
using datos;

namespace presentacion
{
    public partial class FormVerDetalle : Form
    {
        private Articulo _articulo = null;
        public FormVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            _articulo = articulo;
        }
        private void CargarImagen(string url)
        {
            try
            {
                pbxArticulo.Load(url);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://cdn-icons-png.flaticon.com/512/85/85488.png");
            }
        }
        private void FormVerDetalle_Load(object sender, EventArgs e)
        {
            if (_articulo != null)
            {
                lblNombre.Text = _articulo.Nombre;
                lblCodigo.Text = _articulo.Codigo;
                lblDescripcion.Text = _articulo.Descripcion;
                lblPrecio.Text = _articulo.Precio.ToString("C");
                lblCategoria.Text = _articulo.Categoria.Descripcion;
                lblMarca.Text = _articulo.Marca.Descripcion;
                CargarImagen(_articulo.Url_imagen);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un artículo.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
