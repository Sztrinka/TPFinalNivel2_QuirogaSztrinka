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
    public partial class FormABM : Form
    {
        private Articulo _articulo = null;
        #region Constructores
        public FormABM() //ALTA ARTICULO
        {
            InitializeComponent();
        }

        public FormABM(Articulo articulo) //MODIFICAR ARTICULO
        {
            InitializeComponent();
            _articulo = articulo;
            Text = "Modificar Artículo";
        }
        #endregion

        private void FormABM_Load(object sender, EventArgs e)
        {
            ArticuloDB db = new ArticuloDB();
            try
            {
                cboCategoria.DataSource = db.ListarCategoria();
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.ValueMember = "Id";
                cboMarca.DataSource = db.ListarMarca();
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "Id";
                if (_articulo != null) //MODIFICAR ARTICULO
                {
                    txtNombre.Text = _articulo.Nombre;
                    txtCodigo.Text = _articulo.Codigo;
                    txtDescripcion.Text = _articulo.Descripcion;
                    txtUrl.Text = _articulo.Url_imagen;
                    txtPrecio.Text = _articulo.Precio.ToString();
                    cboCategoria.SelectedValue = _articulo.Categoria.Id;
                    cboMarca.SelectedValue = _articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloDB db = new ArticuloDB();
            try
            {
                if (_articulo == null) //ALTA ARTICULO
                    _articulo = new Articulo();
                _articulo.Nombre = txtNombre.Text;
                _articulo.Codigo = txtCodigo.Text;
                _articulo.Descripcion = txtDescripcion.Text;
                _articulo.Url_imagen = txtUrl.Text;
                _articulo.Precio = decimal.Parse(txtPrecio.Text);


                if (_articulo.Id == 0)
                {
                    db.Agregar(_articulo);
                    MessageBox.Show("Artículo agregado correctamente.");
                }
                else
                {
                    db.Modificar(_articulo);
                    MessageBox.Show("Artículo modificado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Close();
            }
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

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrl.Text);
        }










    }
}
